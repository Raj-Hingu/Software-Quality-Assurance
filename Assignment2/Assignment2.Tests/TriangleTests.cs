using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2;

namespace Assignment2.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void isEquilateral_Input222_ResultYes()
        {
            int a = 2;
            int b = 2;
            int c = 2;

            bool answer = TriangleSolver.equilateral(a, b, c);

            Assert.IsTrue(answer);
        }
        [Test]
        public void isIsoscles_Input445_ResultYes()
        {
            int a = 4;
            int b = 4;
            int c = 5;

            bool answer = TriangleSolver.isosceles(a, b, c);

            Assert.IsTrue(answer);
        }

        [Test]
        public void isScalene_Input456_ResultYes()
        {
            int a = 4;
            int b = 5;
            int c = 6;

            bool answer = TriangleSolver.scalene(a, b, c);

            Assert.IsTrue(answer);
        }

        [Test]
        public void isATriangle_Input456_ResultTrue()
        {
            int a = 4;
            int b = 5;
            int c = 6;

            string answer = TriangleSolver.Analyze(a, b, c);

            Assert.AreEqual("True" , answer);
        }

        [Test]
        public void isNotATriangle_Input448_Resultfalse()
        {
            int a = 4;
            int b = 4;
            int c = 8;

            string answer = TriangleSolver.Analyze(a, b, c);

            Assert.AreEqual("false", answer);
        }

        [Test]
        public void isNotAEquilateral_Input456_ResultYes()
        {
            int a = 4;
            int b = 5;
            int c = 6;

            bool answer = TriangleSolver.equilateral(a, b, c);

            Assert.IsFalse(answer);
        }
    }
}
