using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nOne, nTwo;

            Console.WriteLine("Number 1 :");
            nOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Number 2 :");
            nTwo = double.Parse(Console.ReadLine());

            if (nOne > nTwo)
            {
                Console.WriteLine($"The biggest number is : {nOne}");
            } else if (nOne < nTwo)
            {
                Console.WriteLine($"The biggest number is  : {nTwo}");
            } else
            {
                Console.WriteLine("Equals !");
            }
            Console.ReadLine();
        }
    }
}
