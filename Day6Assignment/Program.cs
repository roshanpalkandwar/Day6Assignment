﻿namespace Day6Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welecome to fobonaci series ");
            Console.WriteLine("chooes program\n1. fibonaci series\n2.find perfect number");
            int opt=Convert.ToInt32(Console.ReadLine());

            switch(opt)
            {
                case 1:fibonaciSeries.FibonaciSeries();
                   break;
                    case 2:perfectNumber.PerfectNumber();
                    break;
            }
        }
    }
}