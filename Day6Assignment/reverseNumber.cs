using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class reverseNumber
    {
        public static void ReverseNumber()
        {
            Console.WriteLine("enter the no which you want revese");
            int number=Convert.ToInt32(Console.ReadLine());
                
            int n1 = 0;
            while (number > 0)
            {
                int remainder = number % 10; 
                n1 = (n1 * 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine("Reverse No. is {0}",n1);
        }
    }
}
