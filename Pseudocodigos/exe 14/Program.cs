using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            try
            {
                Console.WriteLine("Type de Year");
                year = int.Parse(Console.ReadLine());

                if ( year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                {
                    Console.WriteLine(" Leap Year");
                } else
                {
                    Console.WriteLine(" Normal Year");
                }

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
