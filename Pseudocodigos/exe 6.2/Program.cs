using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Type the number to check:");
            number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Number is Negative !");
            } else if (number > 0)
            {
                Console.WriteLine("Number is Positive !");
            } else
            {
                Console.WriteLine("Number is Zero !");
            }
            Console.ReadLine();
        }
    }
}
