using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numOne, numTwo, numThree, sum = 0, avg = 0;
            try
            {
            // ask the numbers
            Console.WriteLine("Type the first number : ");
            numOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number : ");
            numTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the third number : ");
            numThree = double.Parse(Console.ReadLine());
            // calculate ethe sum and average
            sum = numOne + numTwo + numThree;
            avg = sum / 3;
            // show results
            Console.WriteLine($"Sum ->   {Math.Round(sum, 2)}"); // rounds up to decimal cases
            Console.WriteLine($"Avegare -> {Math.Round(avg,2)}"); // rounds up to decimal cases

            } catch
            {
                Console.WriteLine("Invalid input ! Try Again !");
            }
            Console.ReadLine();
        }
    }
}
