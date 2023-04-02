using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valOne, valTwo, valThree,avg = 0;
            // ask for the values
            Console.WriteLine("Type the First Value : ");
            valOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the second value : ");
            valTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the third value : ");
            valThree = double.Parse(Console.ReadLine());
            // calculate the math
            avg = ((valOne * 5) + (valTwo * 3) + (valThree * 2)) / 10;
            //show result
            Console.WriteLine($"The Average is -> {avg}");
            Console.ReadLine();
        }
    }
}
