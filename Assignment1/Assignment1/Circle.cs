using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Circle
    {
        private int radius;

        
        public Circle()
        {
            this.radius = 1;

        }
        public Circle(int radius){
            this.radius = radius;

        }

        public  int GetRadius() {
           
            return radius;
            
        }

        public void SetRadius(int radius) {
            this.radius = radius;
        }

        public double GetCircumference() {
            return 2 * 3.14 * radius;
        }

        public double GetArea() {
            return 3.14 * radius * radius;
        }
    }
}
