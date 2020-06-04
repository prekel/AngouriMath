/*
 * This file was auto-generated by TestGenerator.jar
 * Do not modify it; modify TestGenerator.java and rerun it instead.
 */


using AngouriMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Algebra.PolynomialSolverTests
{
    [TestClass]
    public class ClassRealCardanoNumericRoots
    {
        public static VariableEntity x = "x";


        [TestMethod]
        public void TestAllcomplexNumeric1_3()
        {
            var expr = (x - 4) * (x - 3) * (x - 2);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric2_3()
        {
            var expr = (x - 5) * (x - 8) * (x - 0);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric3_3()
        {
            var expr = (x - 8) * (x - 5) * (x - 2);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric4_3()
        {
            var expr = (x - 0) * (x - 8) * (x - 3);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric5_3()
        {
            var expr = (x - 4) * (x - 8) * (x - 6);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric6_3()
        {
            var expr = (x - 8) * (x - 6) * (x - 9);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric7_3()
        {
            var expr = (x - 5) * (x - 6) * (x - 9);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric8_3()
        {
            var expr = (x - 5) * (x - 7) * (x - 4);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric9_3()
        {
            var expr = (x - 6) * (x - 0) * (x - 3);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric10_3()
        {
            var expr = (x - 7) * (x - 3) * (x - 3);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric11_3()
        {
            var expr = (x - 3) * (x - 3) * (x - 5);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric12_3()
        {
            var expr = (x - 3) * (x - 4) * (x - 1);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric13_3()
        {
            var expr = (x - 5) * (x - 1) * (x - 9);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric14_3()
        {
            var expr = (x - 0) * (x - 6) * (x - 7);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric15_3()
        {
            var expr = (x - 0) * (x - 7) * (x - 6);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric16_3()
        {
            var expr = (x - 0) * (x - 1) * (x - 3);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric17_3()
        {
            var expr = (x - 4) * (x - 4) * (x - 9);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric18_3()
        {
            var expr = (x - 4) * (x - 3) * (x - 5);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric19_3()
        {
            var expr = (x - 4) * (x - 3) * (x - 5);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric20_3()
        {
            var expr = (x - 3) * (x - 7) * (x - 6);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
    }
}

namespace UnitTests.Algebra.PolynomialSolverTests
{
    [TestClass]
    public class ClassComplexCardanoNumericRoots
    {
        public static VariableEntity x = "x";


        [TestMethod]
        public void TestAllcomplexNumeric1_3()
        {
            var expr = (x - 4 + MathS.i * 3) * (x - 2 + MathS.i * 5) * (x - 8 + MathS.i * 0);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric2_3()
        {
            var expr = (x - 8 + MathS.i * 5) * (x - 2 + MathS.i * 0) * (x - 8 + MathS.i * 3);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric3_3()
        {
            var expr = (x - 4 + MathS.i * 8) * (x - 6 + MathS.i * 8) * (x - 6 + MathS.i * 9);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric4_3()
        {
            var expr = (x - 5 + MathS.i * 6) * (x - 9 + MathS.i * 5) * (x - 7 + MathS.i * 4);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric5_3()
        {
            var expr = (x - 6 + MathS.i * 0) * (x - 3 + MathS.i * 7) * (x - 3 + MathS.i * 3);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric6_3()
        {
            var expr = (x - 3 + MathS.i * 3) * (x - 5 + MathS.i * 3) * (x - 4 + MathS.i * 1);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric7_3()
        {
            var expr = (x - 5 + MathS.i * 1) * (x - 9 + MathS.i * 0) * (x - 6 + MathS.i * 7);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric8_3()
        {
            var expr = (x - 0 + MathS.i * 7) * (x - 6 + MathS.i * 0) * (x - 1 + MathS.i * 3);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric9_3()
        {
            var expr = (x - 4 + MathS.i * 4) * (x - 9 + MathS.i * 4) * (x - 3 + MathS.i * 5);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric10_3()
        {
            var expr = (x - 4 + MathS.i * 3) * (x - 5 + MathS.i * 3) * (x - 7 + MathS.i * 6);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric11_3()
        {
            var expr = (x - 0 + MathS.i * 7) * (x - 4 + MathS.i * 1) * (x - 1 + MathS.i * 3);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric12_3()
        {
            var expr = (x - 7 + MathS.i * 4) * (x - 7 + MathS.i * 9) * (x - 4 + MathS.i * 7);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric13_3()
        {
            var expr = (x - 4 + MathS.i * 6) * (x - 8 + MathS.i * 4) * (x - 2 + MathS.i * 0);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric14_3()
        {
            var expr = (x - 8 + MathS.i * 7) * (x - 6 + MathS.i * 4) * (x - 4 + MathS.i * 3);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric15_3()
        {
            var expr = (x - 7 + MathS.i * 2) * (x - 9 + MathS.i * 1) * (x - 5 + MathS.i * 7);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric16_3()
        {
            var expr = (x - 2 + MathS.i * 5) * (x - 2 + MathS.i * 8) * (x - 7 + MathS.i * 9);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric17_3()
        {
            var expr = (x - 5 + MathS.i * 0) * (x - 3 + MathS.i * 3) * (x - 7 + MathS.i * 5);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric18_3()
        {
            var expr = (x - 6 + MathS.i * 8) * (x - 6 + MathS.i * 0) * (x - 8 + MathS.i * 3);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric19_3()
        {
            var expr = (x - 9 + MathS.i * 0) * (x - 9 + MathS.i * 9) * (x - 3 + MathS.i * 9);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric20_3()
        {
            var expr = (x - 3 + MathS.i * 7) * (x - 6 + MathS.i * 0) * (x - 2 + MathS.i * 4);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric21_3()
        {
            var expr = (x - 4 + MathS.i * 6) * (x - 1 + MathS.i * 8) * (x - 5 + MathS.i * 9);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric22_3()
        {
            var expr = (x - 9 + MathS.i * 8) * (x - 5 + MathS.i * 4) * (x - 7 + MathS.i * 8);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric23_3()
        {
            var expr = (x - 3 + MathS.i * 3) * (x - 2 + MathS.i * 9) * (x - 5 + MathS.i * 4);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric24_3()
        {
            var expr = (x - 9 + MathS.i * 3) * (x - 0 + MathS.i * 3) * (x - 4 + MathS.i * 2);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric25_3()
        {
            var expr = (x - 1 + MathS.i * 6) * (x - 6 + MathS.i * 7) * (x - 1 + MathS.i * 3);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric26_3()
        {
            var expr = (x - 7 + MathS.i * 4) * (x - 8 + MathS.i * 8) * (x - 4 + MathS.i * 2);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric27_3()
        {
            var expr = (x - 2 + MathS.i * 2) * (x - 4 + MathS.i * 3) * (x - 2 + MathS.i * 8);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric28_3()
        {
            var expr = (x - 0 + MathS.i * 5) * (x - 6 + MathS.i * 3) * (x - 4 + MathS.i * 8);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric29_3()
        {
            var expr = (x - 9 + MathS.i * 2) * (x - 2 + MathS.i * 4) * (x - 2 + MathS.i * 3);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric30_3()
        {
            var expr = (x - 4 + MathS.i * 9) * (x - 7 + MathS.i * 8) * (x - 4 + MathS.i * 9);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
    }
}

namespace UnitTests.Algebra.PolynomialSolverTests
{
    [TestClass]
    public class ClassRealFerrariNumericRoots
    {
        public static VariableEntity x = "x";


        [TestMethod]
        public void TestAllcomplexNumeric1_4()
        {
            var expr = (x - 4) * (x - 3) * (x - 2) * (x - 5);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric2_4()
        {
            var expr = (x - 8) * (x - 0) * (x - 8) * (x - 5);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric3_4()
        {
            var expr = (x - 2) * (x - 0) * (x - 8) * (x - 3);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric4_4()
        {
            var expr = (x - 4) * (x - 8) * (x - 6) * (x - 8);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric5_4()
        {
            var expr = (x - 6) * (x - 9) * (x - 5) * (x - 6);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric6_4()
        {
            var expr = (x - 9) * (x - 5) * (x - 7) * (x - 4);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric7_4()
        {
            var expr = (x - 6) * (x - 0) * (x - 3) * (x - 7);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric8_4()
        {
            var expr = (x - 3) * (x - 3) * (x - 3) * (x - 3);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric9_4()
        {
            var expr = (x - 5) * (x - 3) * (x - 4) * (x - 1);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric10_4()
        {
            var expr = (x - 5) * (x - 1) * (x - 9) * (x - 0);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric11_4()
        {
            var expr = (x - 6) * (x - 7) * (x - 0) * (x - 7);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric12_4()
        {
            var expr = (x - 6) * (x - 0) * (x - 1) * (x - 3);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
    }
}

namespace UnitTests.Algebra.PolynomialSolverTests
{
    [TestClass]
    public class ClassComplexFerrariNumericRoots
    {
        public static VariableEntity x = "x";


        [TestMethod]
        public void TestAllcomplexNumeric1_4()
        {
            var expr = (x - 4 + MathS.i * 3) * (x - 2 + MathS.i * 5) * (x - 8 + MathS.i * 0) * (x - 8 + MathS.i * 5);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric2_4()
        {
            var expr = (x - 2 + MathS.i * 0) * (x - 8 + MathS.i * 3) * (x - 4 + MathS.i * 8) * (x - 6 + MathS.i * 8);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric3_4()
        {
            var expr = (x - 6 + MathS.i * 9) * (x - 5 + MathS.i * 6) * (x - 9 + MathS.i * 5) * (x - 7 + MathS.i * 4);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric4_4()
        {
            var expr = (x - 6 + MathS.i * 0) * (x - 3 + MathS.i * 7) * (x - 3 + MathS.i * 3) * (x - 3 + MathS.i * 3);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric5_4()
        {
            var expr = (x - 5 + MathS.i * 3) * (x - 4 + MathS.i * 1) * (x - 5 + MathS.i * 1) * (x - 9 + MathS.i * 0);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric6_4()
        {
            var expr = (x - 6 + MathS.i * 7) * (x - 0 + MathS.i * 7) * (x - 6 + MathS.i * 0) * (x - 1 + MathS.i * 3);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric7_4()
        {
            var expr = (x - 4 + MathS.i * 4) * (x - 9 + MathS.i * 4) * (x - 3 + MathS.i * 5) * (x - 4 + MathS.i * 3);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
        [TestMethod]
        public void TestAllcomplexNumeric8_4()
        {
            var expr = (x - 5 + MathS.i * 3) * (x - 7 + MathS.i * 6) * (x - 0 + MathS.i * 7) * (x - 4 + MathS.i * 1);
            var newexpr = expr.Expand();
            foreach (var root in newexpr.SolveEquation(x).FiniteSet())
                SolveOneEquation.AssertRoots(newexpr, x, root);
        }
    }
}