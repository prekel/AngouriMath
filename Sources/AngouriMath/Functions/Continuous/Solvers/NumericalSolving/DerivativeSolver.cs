using System;
using System.Collections.Generic;
using System.Linq;

using AngouriMath.Core;
using AngouriMath.Functions.Continuous.Solvers.NumericalSolving;
using AngouriMath.Functions.Algebra.AnalyticalSolving;

using MyExpression.Core;

using PeterO.Numbers;

using System;
using System.Collections.Generic;
using System.Linq;

using AngouriMath.Core;
using AngouriMath.Extensions;
using AngouriMath.Functions.Algebra.NumericalSolving;

using PeterO.Numbers;

namespace AngouriMath.Functions.Continuous.Solvers.NumericalSolving
{
    internal static class DerivativeSolver
    {
        internal static HashSet<double> SolveDer(Entity expr, Entity.Variable v, double eps)
        {
            if (expr.Vars.Single() != v)
                throw new Core.Exceptions.WrongNumberOfArgumentsException(
                    $"{nameof(expr)} should only contain {nameof(Entity.Variable)} {nameof(v)}");

            expr = expr.Simplify();

            // Safely expand the expression
            // Here we find all terms
            var children = TreeAnalyzer.GatherLinearChildrenOverSumAndExpand(expr, entity => entity.ContainsNode(v));
            if (children is null)
            {
                throw new ApplicationException();
            }
            // // //

            // Check if all are like {1} * x^n & gather information about them
            var monomialsByPower = PolynomialSolver.GatherMonomialInformation
                <EInteger, TreeAnalyzer.PrimitiveInteger>(children, v);
            if (monomialsByPower == null)
            {
                throw new ApplicationException();
            } // meaning that the given equation is not polynomial

            var res = PolynomialSolver.ReduceCommonPower(ref monomialsByPower)
                ? new Entity[] {0} // x5 + x3 + x2 - common power is 2, one root is 0, then x3 + x + 1
                : Enumerable.Empty<Entity>();
            var powers = monomialsByPower.Keys.ToList();
            var gcdPower = powers.Aggregate((accumulate, current) => accumulate.Gcd(current));
            // // //

            if (gcdPower.IsZero)
                gcdPower = EInteger.One;
            // Change all replacements, x6 + x3 + 1 => x2 + x + 1
            if (!gcdPower.Equals(EInteger.One))
            {
                for (int i = 0; i < powers.Count; i++)
                    powers[i] /= gcdPower;
                monomialsByPower = monomialsByPower.ToDictionary(pair => pair.Key / gcdPower, pair => pair.Value);
            }
            // // //

            var gcdPowerRoots = Entity.Number.GetAllRootsOf1(gcdPower);

            //Entity GetMonomialByPower(EInteger power) => monomialsByPower.TryGetValue(power, out var monomial) ? monomial.InnerSimplified : 0;

            powers.Sort();

            var qwe = monomialsByPower.ToDictionary(pair => pair.Key,
                pair => pair.Value.EvalNumerical().RealPart.EDecimal.ToDouble());

            var p = new Polynomial();
            foreach (var i in qwe)
            {
                p.Add(new Monomial(i.Value, i.Key.ToInt32Unchecked()));
            }

            var eq = new PolynomialEquation(p);
            eq.Solve();
            return eq.Roots.ToHashSet();
        }
    }
}

namespace AngouriMath
{
    public abstract partial record Entity : ILatexiseable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="eps"></param>
        /// <returns></returns>
        public HashSet<double> SolveDer(Variable v, double eps) => DerivativeSolver.SolveDer(this, v, eps);
    }
}
