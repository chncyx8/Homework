using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, s , area;
            
         try
         {
            Console.WriteLine("Please enter side a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter side b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter side c: ");
            c = double.Parse(Console.ReadLine());

            s = (a + b + c) / 2;
            area = Math.Sqrt(s * ( s - a) * (s - b) * (s - c));

                if (a + b > c && a + c > b && c + b > a)
                {
                    Console.WriteLine("The area is: " + area);
                }
                else
                {
                    Console.WriteLine("This is not a triangle!");
                }
                     
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey(true);
            }
         catch
          {
             Console.WriteLine("You have an error");
          }
        }
       /*
       * a, b, c - three sides of a triangle,  double
       * area - area of the triangle, double 
       * 
       * summary: This method first check if three sides can consist a triangle, 
       * if yes, it calculates the area of the triangle using Heron's formula, if no,
       * it would show a error message.
       * For example, a=3, b=4, c=5. Area = 6,
       * a=4, b=6, c=17, the system would show: This is not a triangle!
       * Tip: Use if else to control the results. 
       *
       * returns      : result
       * return type  : void
       *
       */

        public static void Checknumber(int n)
        {

            try
            {
                Console.WriteLine("Please enter number n: ");
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine("{0} is even. ");
                }
                else
                {
                    Console.WriteLine("{0} is odd. ");
                }

                Console.WriteLine("Press any key to exit..");
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Checknumber()");
            }
        }
        /*
        * n -the number user input, integer(int)
        * 
        * summary: This method check a number (n) from the user and check if it is even or odd.
        * For example, n=10, 10 is even. n=13, 13 is odd.
        * 
        * Tip: Use n % 2 == 0 to distinguish even or odd. 
        *
        * returns      : N/A
        * return type  : void
        *
        */


        public static void Maxnumber(double x, double y, double z)
        {

            try
            {
                Console.WriteLine("Please enter x: ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter y: ");
                y = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter z: ");
                z = double.Parse(Console.ReadLine());

                if (x > y && x > z)
                {
                    Console.WriteLine("The greatest number is: " + x);
                }
                else if (y > x && y > z)
                {
                    Console.WriteLine("The greatest number is: " + y);
                }
                else
                {
                    Console.WriteLine("The greatest number is: " + z);
                }

                Console.WriteLine("Press any key to exit..");
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Maxnumber()");
            }
        }
        /*
       * x, y, z - three starting numbers,  double
       * 
       * summary: This method compares three numbers each other, 
       * then find the greastest one.
       * For example, a=23, b=45, c=75. The greatest number is: 75,
       * 
       * Tip: Use if else to control the results, 
       * for example, if (x > y && x > z), the greatest number is x, 
       * the logic here is to compare three numbers each other. 
       *
       * returns      : result
       * return type  : void
       *
       */


    }
}
