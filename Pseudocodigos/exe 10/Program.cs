using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            try
            {
                Console.WriteLine("Type the year");
                year = int.Parse(Console.ReadLine());

                if (year % 4 ==0 && year % 100 != 0 || year % 400 == 0)
                {
                    Console.WriteLine($"{year} is leap year");
                } else {
                    Console.WriteLine($"{year} is not a leap year");
                }
            } catch
            {
                Console.WriteLine("ERROR! Value invalid ! Try Again");
            }
            Console.ReadLine();
        }
    }
}
