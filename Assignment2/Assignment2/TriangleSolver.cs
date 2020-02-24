using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2
{
   public static class TriangleSolver
    {
        public static Boolean equilateral(int a ,int b, int c)
        {
            if (a == b && b == c)
            {
               
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean isosceles(int a, int b, int c)
        {
            if ((a == b) || (b == c) || (a == c))
            {
               
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean scalene(int a, int b, int c)
        {
            if ((a != b) || (b != c) || (a != c))
            {
                
                return true;
            }
            else
            {
                return false;
            }
        }

        public static  string Analyze(int a, int b, int c)
        {

            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                Console.WriteLine("These sides can form a triangle");
               if( equilateral(a, b, c)== true)
                {
                    Console.WriteLine("Triangle is Equilateral");
                }
               else if(isosceles(a, b, c) == true)
                {
                    Console.WriteLine("Triangle is Isosceles");
                }
               else if (scalene(a, b, c) == true)
                {
                    Console.WriteLine("Triangle is Scalene");
                }
                
               
                 
               

            }
            else
            {
                Console.WriteLine("those sides do not produce a triangle, please try again");
            }
            return "True";

        }
    }
}
