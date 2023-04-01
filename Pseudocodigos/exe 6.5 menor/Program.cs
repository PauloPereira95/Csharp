using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_6._5_menor
{
    internal class Program
    {
        static void Main(string[] args)
        {
             // declare variables
            double numOne,numTwo,numThree,res;
            // as the user the values 
            Console.WriteLine(" Type the first number :");
            numOne = double.Parse(Console.ReadLine());
            Console.WriteLine(" Type the second number :");
            numTwo = double.Parse(Console.ReadLine());
            Console.WriteLine(" Type the third number :");
            numThree = double.Parse(Console.ReadLine());
            // iniciate res (the variable in wich we will store the smallest number)
            res = numOne;
            // create array (the array in wich we will store the 3 numbers)
            double[] minor = new double[3] { numOne, numTwo, numThree};
            // go through the array
            foreach (double i in minor)
            {
                // we compare the current value with the value of the array
                // if de current value is smallest
               if (i < res )
               {
                    // res receives the value of the array
                    res = i;
               }
            }
            // show result
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
