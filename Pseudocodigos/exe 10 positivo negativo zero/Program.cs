using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_10_positivo_negativo_zero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;

            Console.WriteLine("Type the Number :");
            num = double.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("ZERO!");
            } else if (num < 0) 
            {
                Console.WriteLine("Negative Number!");
            } else 
            {
                Console.WriteLine("Positive Number");
            }
            Console.ReadLine();
        }
    }
}
