using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numUser;
            double sum = 0, avg = 0, number; ;

            Console.WriteLine("Type how many values do you want to enter: ");
            numUser = int.Parse(Console.ReadLine());

            for (int i = 0; i < numUser; i++)
            {
                Console.WriteLine("Type de number do you want to add");
                number = double.Parse(Console.ReadLine());
                sum += number;
                avg = sum / numUser;
            }
            Console.WriteLine($"TOTAL SUM -> {sum}");
            Console.WriteLine($"TOTAL AVERAGE -> {avg}");
            Console.ReadLine();
        }
    }
}
