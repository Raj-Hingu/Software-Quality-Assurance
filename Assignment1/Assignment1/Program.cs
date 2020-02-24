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
            int i = 1;

            Circle circle = new Circle();

            do
            {
                Console.WriteLine("Please Select from 1 to 5");


                Console.WriteLine(" 1. Get Circle Radius");
                Console.WriteLine(" 2. Change Circle Radius");
                Console.WriteLine(" 3. Get Circle Circumference");
                Console.WriteLine(" 4. Get Circle Area");
                Console.WriteLine(" 5. Exit");

                int num1 = int.Parse(Console.ReadLine());
                try
                {
                    if (num1 == 1)
                    {
                        Console.WriteLine("The Radius of Default Circle is : "+ circle.GetRadius());

                    }
                    else if (num1 == 2)
                    {
                        Console.WriteLine("Please Enter circle radius");
                        radius = int.Parse(Console.ReadLine());
                        circle.SetRadius(radius);

                    }
                    else if (num1 == 3)
                    {
                        Console.WriteLine("The Circumference of Default Circle is : " + circle.GetCircumference());
                    }
                    else if (num1 == 4)
                    {
                        Console.WriteLine("The Area of Default Circle is : " + circle.GetArea());
                    }
                    else if(num1 == 5)
                    {
                        Console.WriteLine("Thank You");
                        i = 0;
                    }
                   
                }
                catch (Exception e)
                {

                    Console.WriteLine("Please select from the above options" + e);
                }
                 
            } while (i == 1);

          

            Console.ReadLine();

        }
    }
}
