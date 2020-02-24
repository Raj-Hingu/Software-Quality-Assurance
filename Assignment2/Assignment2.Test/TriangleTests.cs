using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Assignment2.Test
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


            bool answer = Assignment2.TriangleSolver.equilateral(a, b, c);

            Assert.AreEqual(true, answer);
           


        }
    }
}
