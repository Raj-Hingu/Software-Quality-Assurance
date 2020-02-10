using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius;

            Circle circle = new Circle();

            Console.WriteLine("Please Select from 1 to 5");
            

            Console.WriteLine(" 1. Get Circle Radius");
            Console.WriteLine(" 2. Change Circle Radius");
            Console.WriteLine(" 3. Get Circle Circumference");
            Console.WriteLine(" 4. Get Circle Area");
            Console.WriteLine(" 5. Exit");

            int num1 = int.Parse(Console.ReadLine());

            if (num1 == 1)
            {
              Console.WriteLine ( circle.GetRadius());
                
            }
            else if(num1 == 2)
            {
                Console.WriteLine("Please Enter circle radius");
                radius = int.Parse(Console.ReadLine());
                circle.SetRadius(radius);
                
            }
            else if(num1 == 3)
            {
                circle.GetCircumference();
            }
            else if(num1 == 4)
            {
                circle.GetArea();
            }
            else
            {
                
            }

            Console.ReadLine();

        }
    }
}
