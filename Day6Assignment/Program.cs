namespace Day6Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welecome to fobonaci series ");
            Console.WriteLine("chooes program\n1. fibonaci series\n2.find perfect number\n3.find prime number or not\n4.reverse a number\n5.stop watch program\n6.Find the Fewest Notes to be returned for Vending Machine\n7.Day of week");
            int opt=Convert.ToInt32(Console.ReadLine());

            switch(opt)
            {
                case 1:fibonaciSeries.FibonaciSeries();
                   break;
                    case 2:perfectNumber.PerfectNumber();
                    break;
                case 3:
                    primeNumber.PrimeNumber();
                    break;
                case 4:
                    reverseNumber.ReverseNumber();
                    break;
                case 5:
                    stopWatch.Stopwatch();
                    break;
                case 6:
                    vedingMachineproblem.VedingMachineProblem();
                    break;
                case 7:
                    dayOffWeek.DayOfWeek();
                    break;
                    default:
                    break;
            }
        }
    }
}