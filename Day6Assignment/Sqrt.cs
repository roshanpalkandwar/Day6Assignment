using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class Sqrt
    { 
        public static void squareRoot()
        {
            Console.WriteLine("Enter a number");
            int c = Convert.ToInt32(Console.ReadLine());
            double t = c;
            double epsilon = 1e-15;
            //check for negative number
            if (t > 0)
            {
                //check condition till (t - c/t) becomes less then (epsilon * t)
                while (Math.Abs(t - c / t) > epsilon * t)
                {
                    t = (t + c / t) / 2.0;  //formula for square root.
                }
                Console.WriteLine("Absoulte square root is: " + t);
            }
            else
                Console.WriteLine("Enter positive number");
        }
    }

}
    

