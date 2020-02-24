using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideA;
            int sideB;
            int sideC;
            int i = 0;


            do
            {
                Console.WriteLine(" 1. Enter Triangle Dimensions");
                Console.WriteLine(" 2. Exit");
               
                

                try
                {
                    int num1 = int.Parse(Console.ReadLine());

                    if (num1 == 1)
                    {
                        Console.WriteLine("Enter Sides");

                        sideA =  int.Parse(Console.ReadLine());
                        sideB = int.Parse(Console.ReadLine());
                        sideC = int.Parse(Console.ReadLine());

                        string answer = Assignment2.TriangleSolver.Analyze(sideA, sideB, sideC);


                    }
                    else if (num1 == 2)
                    {
                        i = 1;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Please Select from these options.");
                }

            } while (i==0);


        }
    }
}
