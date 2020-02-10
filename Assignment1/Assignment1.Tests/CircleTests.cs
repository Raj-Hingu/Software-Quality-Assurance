using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment1.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void getRadiusMethod_InputIs0_RadiusIs1()
        {
            int radius = 0;

            Circle circle = new Circle();
            radius = circle.GetRadius();


            Assert.AreEqual( radius, 1);
        }

        [Test]
        public  void setRadiusMethod_Input5_output5()
        {
            int radius=5;

            Circle circle = new Circle(radius);

            radius = int.Parse(Console.ReadLine());
            circle.SetRadius(radius);
            


            Assert.AreEqual(radius, 5);
        }

        [Test]
        public void getCircumferenceMethod_InputIsNone_AnswerIs6point28()
        {
            double radius = 0;

            Circle circle = new Circle();
            radius = circle.GetCircumference();


            Assert.AreEqual(radius, 6.28);
        }

        [Test]
        public void getAreaMethod_InputIsNone_AnswerIsPi()
        {
            double radius = 0;

            Circle circle = new Circle();
            radius = circle.GetArea();


            Assert.AreEqual(radius, 3.14);
        }
    }
}
