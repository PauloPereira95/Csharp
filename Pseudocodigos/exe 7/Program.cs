using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, sum, div, sub, multi;
            try
            { 
                // ask the numbers
                Console.WriteLine("Type the first number");
                n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Type the second number");
                n2 = double.Parse(Console.ReadLine());
                // make calculations
                sum = n1 + n2;
                sub = n1 - n2;
                multi = n1 * n2;
                // check if the user want divde by 0
                // if yes the division is 0 because its not possible to divde by 0
                if (n2 == 0)
                {
                    // if divison is 0 tel the user is not possible  to devide by 0

                    Console.WriteLine($" Its not possibel divide by 0");
                }
                else
                {
                    div = n1 / n2;
                    Console.WriteLine($"/ -> {div}");

                }

                Console.WriteLine($"+ -> {sum}");
                    Console.WriteLine($"- -> {sub} ");
                    Console.WriteLine($"* -> {multi}");
            } catch (Exception ex)
            {
                Console.WriteLine("Error -> " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
