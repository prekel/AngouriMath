﻿/*
 * Copyright (c) 2019-2020 Angourisoft
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

namespace AngouriMath
{
    using Core;
    using static Functions.Algebra.LimitFunctional;
    partial record Entity
    {
        /// <summary>
        /// Finds the limit of the given expression over the given variable
        /// </summary>
        /// <param name="x">
        /// The variable to be approaching
        /// </param>
        /// <param name="destination">
        /// A value where the variable approaches. It might be a symbolic
        /// expression, a finite number, or an infinite number, for example,
        /// "sqrt(x2 + x) / (3x + 3)".Limit("x", "+oo", ApproachFrom.BothSides)
        /// </param>
        /// <param name="side">
        /// From where to approach it: from the left, from the right,
        /// or BothSides, implying that if limits from either are not
        /// equal, there is no limit
        /// </param>
        /// <returns>
        /// A result or the <see cref="Limitf"/> node if the limit
        /// cannot be determined
        /// </returns>
        public Entity Limit(Variable x, Entity destination, ApproachFrom side)
        { 
            var res = ComputeLimit(this, x, destination, side); 
            if (res is null || res == MathS.NaN)
                return new Limitf(this, x, destination, side);
            return res;
        }

        /// <summary>
        /// Finds the limit of the given expression over the given variable
        /// </summary>
        /// <param name="x">
        /// The variable to be approaching
        /// </param>
        /// <param name="destination">
        /// A value where the variable approaches. It might be a symbolic
        /// expression, a finite number, or an infinite number, for example,
        /// "sqrt(x2 + x) / (3x + 3)".Limit("x", "+oo")
        /// </param>
        /// <returns>
        /// A result or the <see cref="Limitf"/> node if the limit
        /// cannot be determined
        /// </returns>
        public Entity Limit(Variable x, Entity destination)
        {
            var res = ComputeLimit(this, x, destination, ApproachFrom.BothSides);
            if (res is null || res == MathS.NaN)
                return new Limitf(this, x, destination, ApproachFrom.BothSides);
            return res.InnerSimplified;
        }

        /// <summary>
        /// <a href="https://en.wikipedia.org/wiki/Divide_and_rule"/>
        /// Divide and rule (Latin: divide et impera), or divide and conquer,
        /// in politics and sociology is gaining and maintaining power by
        /// breaking up larger concentrations of power into pieces that
        /// individually have less power than the one implementing the strategy.
        /// 
        /// In computer science, divide and conquer is an algorithm design paradigm
        /// based on multi-branched recursion. A divide-and-conquer algorithm works
        /// by recursively breaking down a problem into two or more sub-problems of
        /// the same or related type, until these become simple enough to be solved
        /// directly. The solutions to the sub-problems are then combined to give a
        /// solution to the original problem.
        /// </summary>
        // here we try to compute limit for each children and then merge them into limit of whole expression
        // theoretically, for cases such limit (x -> -1) 1 / (x + 1)
        // this method will return NaN, but thanks to replacement of x to an non-definite expression,
        // it is somehow compensated
        internal virtual Entity? ComputeLimitDivideEtImpera(Variable x, Entity dist, ApproachFrom side)
            => new Limitf(this, x, dist, side);
    }
}


namespace AngouriMath.Functions.Algebra
{
    using AngouriMath.Core.Exceptions;
    using Core;
    using static Entity;
    using static Entity.Number;
    internal static class LimitFunctional
    {
        private static Entity? SimplifyAndComputeLimitToInfinity(Entity expr, Variable x)
        {
            expr = expr.Simplify();
            return ComputeLimitToInfinity(expr, x);
        }

        private static Entity? ComputeLimitToInfinity(Entity expr, Variable x)
        {
            var substitutionResult = LimitSolvers.SolveBySubstitution(expr, x);
            if (substitutionResult is { }) return substitutionResult;

            var logarithmResult = LimitSolvers.SolveAsLogarithm(expr, x);
            if (logarithmResult is { }) return logarithmResult;

            var polynomialResult = LimitSolvers.SolveAsPolynomial(expr, x);
            if (polynomialResult is { }) return polynomialResult;

            var polynomialDivisionResult = LimitSolvers.SolvePolynomialDivision(expr, x);
            if (polynomialDivisionResult is { }) return polynomialDivisionResult;

            var logarithmDivisionResult = LimitSolvers.SolveAsLogarithmDivision(expr, x);
            if (logarithmDivisionResult is { }) return logarithmDivisionResult;

            return null;
        }

        private static bool IsInfiniteNode(Entity expr)
            => expr.ContainsNode("+oo") || expr.ContainsNode("-oo"); // TODO: is it correct?

        private static Entity EquivalenceTable(Entity expr, Variable x, Entity dest) => expr switch
        {
            // for f(x) -> 0

            // sin(f(x)) ~ f(x)
            Sinf(var arg) when arg.Limit(x, dest).Evaled == 0 => arg,
            // 1 - cos(f(x)) ~ f(x)^2 / 2
            Cosf(var arg) when arg.Limit(x, dest).Evaled == 0 => 1 - arg.Pow(2) / 2,
            // tan(f(x)) ~ f(x)
            Tanf(var arg) when arg.Limit(x, dest).Evaled == 0 => arg,
            // cotan(f(x)) = 1 / tan(f(x)) ~ 1 / f(x)
            Cotanf(var arg) when arg.Limit(x, dest).Evaled == 0 => 1 / arg,
            // sec(f(x)) = 1 / cos(f(x)) ~ 2 / (2 - f(x)2) for f(x) -> 0
            Secantf(var arg) when arg.Limit(x, dest).Evaled == 0 => 1 / (1 - arg.Pow(2) / 2),
            // csc(f(x)) = 1 / sin(f(x)) = 1 / f(x) for f(x) -> 0
            Cosecantf(var arg) when arg.Limit(x, dest).Evaled == 0 => 1 / arg,

            // arcsin(f(x)) ~ f(x)
            Arcsinf(var arg) when arg.Limit(x, dest).Evaled == 0 => arg,
            // arccos(f(x)) = pi/2 - arcsin(f(x)) ~ pi/2 - f(x)
            Arccosf(var arg) when arg.Limit(x, dest).Evaled == 0 => MathS.pi / 2 - arg,
            // arctan(f(x)) ~ f(x)
            Arctanf(var arg) when arg.Limit(x, dest).Evaled == 0 => arg,
            // arccotan(f(x)) = pi/2 - arctan(f(x)) ~ pi/2 - f(x)
            Arccotanf(var arg) when arg.Limit(x, dest).Evaled == 0 => MathS.pi / 2 - arg,
            // arccosec(f(x)) = arcsin(1 / f(x)) ~ 1 / f(x) for 1 / f(x) -> 0
            Arccosecantf(var arg) when (1 / arg).Limit(x, dest).Evaled == 0 => 1 / arg,
            // arcsec(f(x)) = pi / 2 - arccosec(f(x)) ~ pi / 2 - f(x) for 1 / f(x) -> 0
            Arcsecantf(var arg) when (1 / arg).Limit(x, dest).Evaled == 0 => MathS.pi / 2 - 1 / arg,

            // log(c, f(x) + 1) ~ f(x) / ln(a)
            Logf(var @base, var arg) when arg.ContainsNode(x) && !@base.ContainsNode(x) && (arg - 1).Limit(x, dest).Evaled == 0 => (arg - 1) / MathS.Ln(@base),

            // (f(x) + 1) ^ c - 1 ~ c * f(x)
            Minusf(Powf(var xPlusOne, var power), Integer(1)) when xPlusOne.ContainsNode(x) && !power.ContainsNode(x) && (xPlusOne - 1).Limit(x, dest).Evaled == 0 => power * (xPlusOne - 1),

            // c ^ f(x) - 1 ~ f(x) * ln(c)
            Minusf(Powf(var @base, var arg), Integer(1)) when !@base.ContainsNode(x) && arg.ContainsNode(x) && arg.Limit(x, dest).Evaled == 0 => arg * MathS.Ln(@base),

            // f(x)^g(x) for f(x) -> 1, g(x) -> +oo
            // => (1 + (f(x) - 1)) ^ g(x) = ((1 - (f(x) - 1)) ^ (1 / (f(x) - 1))) ^ (g(x) (f(x) - 1))
            // e ^ (g(x) * (f(x) - 1))
            Powf(var xPlusOne, var xPower) when 
            xPlusOne.ContainsNode(x) && xPower.ContainsNode(x) && 
            (xPlusOne - 1).Limit(x, dest).Evaled == Integer.Zero && IsInfiniteNode(xPower.Limit(x, dest)) => 
            MathS.e.Pow(xPower * (xPlusOne - 1)),

            _ => expr
        };

        public static Entity? ComputeLimit(Entity expr, Variable x, Entity dest, ApproachFrom side = ApproachFrom.BothSides)
        {
            if (side is ApproachFrom.Left or ApproachFrom.Right)
                return expr.ComputeLimitDivideEtImpera(x, dest, side);
            if (side is ApproachFrom.BothSides)
            {
                expr = expr.Replace(e => EquivalenceTable(e, x, dest)).InnerSimplified;
                if (!dest.IsFinite)
                    // just compute limit with no check for left/right equality
                    // here approach left will be ignored anyways, as dist is infinite number
                    return expr.ComputeLimitDivideEtImpera(x, dest, ApproachFrom.Left);
                else if (expr.ComputeLimitDivideEtImpera(x, dest, ApproachFrom.Left) is { } fromLeft
                  && expr.ComputeLimitDivideEtImpera(x, dest, ApproachFrom.Right) is { } fromRight)
                {
                    if (fromLeft == fromRight)
                        return fromLeft;
                    if (ExpressionNumerical.AreEqual(fromLeft, fromRight))
                        return fromLeft;
                    return Real.NaN;
                }
                else
                    return null;
            }
            throw new AngouriBugException($"Unresolved enum parameter {side}");
        }

        internal static Entity? ComputeLimitImpl(Entity expr, Variable x, Entity dist, ApproachFrom side) => dist switch
        {
            _ when !expr.ContainsNode(x) => expr,
            // avoid NaN values as non finite numbers
            Real { IsNaN: true } => Real.NaN,
            // if x -> -oo just make -x -> +oo
            Real { IsFinite: false, IsNegative: true } => SimplifyAndComputeLimitToInfinity(expr.Substitute(x, -x), x),
            // compute limit for x -> +oo
            Real { IsFinite: false, IsNegative: false } => SimplifyAndComputeLimitToInfinity(expr, x),
            Complex { IsFinite: false } =>
                throw new LimitOperationNotSupportedException($"Complex infinities are not supported in limits: lim({x} -> {dist}) {expr}"),
            _ => SimplifyAndComputeLimitToInfinity(side switch
            {
                // lim(x -> 3-) x <=> lim(x -> 0+) 3 - x <=> lim(x -> +oo) 3 - 1 / x
                ApproachFrom.Left => expr.Substitute(x, dist - 1 / x),
                // lim(x -> 3+) x <=> lim(x -> 0+) 3 + x <=> lim(x -> +oo) 3 + 1 / x
                ApproachFrom.Right => expr.Substitute(x, dist + 1 / x),
                _ => throw new System.ArgumentOutOfRangeException(nameof(side), side,
                    $"Only {ApproachFrom.Left} and {ApproachFrom.Right} are supported.")
            }, x)
        };
    }
}