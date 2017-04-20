using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Assignment_4.Test
{
    [TestFixture]
    public class TriangleSolverTest
    {
        [Test]
        public void AllSidesZeroTest()
        {
            //Initialize test string
            string result = null;
            //Input zero values for sides of triangle
            result = TriangleSolver.analyze(0, 0, 0);
            //Testing the result against expected result
            NUnit.Framework.StringAssert.IsMatch("Triangle sides cannot be 0", result);
        }
        [Test]
        public void BoundariesTest()
        {
            //Initialize test string
            string result = null;
            //Input boundary values for sides of triangle
            result = TriangleSolver.analyze(-1, 0, 1);
            //Testing the result against expected result
            NUnit.Framework.StringAssert.IsMatch("Triangle sides cannot be 0", result);
        }
        [Test]
        public void NegativeInputTest()
        {
            //Initialize test string
            string result = null;
            //Input negative values for sides of triangle
            result = TriangleSolver.analyze(-8, -11, -1);
            //Testing the result against expected result
            NUnit.Framework.StringAssert.IsMatch("Triangle sides cannot be negative", result);
        }
        [Test]
        public void EquilateralTest()
        {
            //Initialize test string
            string result = null;
            //Input equal values for sides of triangle
            result = TriangleSolver.analyze(10, 10, 10);
            //Testing the result against expected result
            NUnit.Framework.StringAssert.IsMatch("Triangle is Equilateral", result);
        }
        [Test]
        public void IsoscelesTest()
        {
            //Initialize test string
            string result = null;
            //Input two equal and one different values for sides of triangle
            result = TriangleSolver.analyze(5, 9, 5);
            //Testing the result against expected result
            NUnit.Framework.StringAssert.IsMatch("Triangle is Isosceles", result);
        }
        [Test]
        public void ScaleneTest()
        {
            //Initialize test string
            string result = null;
            //Input three different values for sides of triangle
            result = TriangleSolver.analyze(6, 9, 7);
            //Testing the result against expected result
            NUnit.Framework.StringAssert.IsMatch("Triangle is Scalene", result);
        }
        [Test]
        public void TriangleTest()
        {
            //Initialize test string
            string result = null;
            //Input one side bigger than the sum of the other two for sides of triangle
            result = TriangleSolver.analyze(6, 5, 12);
            //Testing the result against expected result
            NUnit.Framework.StringAssert.IsMatch("Triangle cannot be formed with the given sides", result);
        }
        [Test]
        public void NegativeEquilateralTest()
        {
            //Initialize test string
            string result = null;
            //Input equilateral but negative values for sides of triangle
            result = TriangleSolver.analyze(-11, -11, -11);
            //Testing the result against expected result
            NUnit.Framework.StringAssert.IsMatch("Triangle sides cannot be negative", result);
        }
    }
}