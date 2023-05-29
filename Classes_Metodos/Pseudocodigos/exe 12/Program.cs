using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nOne, nTwoo, nThree;

            Console.WriteLine(" Number 1 :");
            nOne = double.Parse(Console.ReadLine());
            Console.WriteLine(" Number 2 :");
            nTwoo = double.Parse(Console.ReadLine());
            Console.WriteLine(" Number 3 : ");
            nThree = double.Parse(Console.ReadLine());

            if (nOne == nTwoo && nOne == nThree)
            {
                Console.WriteLine("Equals !");
            } else if (nOne < nTwoo && nOne < nThree)
            {
                Console.WriteLine($"Smallest Number: {nOne}");
            } else if (nTwoo < nThree)
            {
                Console.WriteLine($"Smallest Number: {nTwoo}");
            } else
            {
                Console.WriteLine($"Smallest Number: {nThree}");
            }
            Console.ReadLine();
        }
    }
}
