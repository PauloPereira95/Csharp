using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_6._4_sub_div_adic_multi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            double numOne, numTwo, res = 0;

            Console.WriteLine("Type the first number : ");
            numOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number : ");
            numTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("What operation do you intend to perform, + or - or / or * ?");
            op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    res = numOne + numTwo;
                    break;
                case '*':
                    res = numOne * numTwo;
                    break;
                case '/':
                        if (numOne > numTwo)
                        {
                            res = numOne / numTwo;
                        } else
                        {
                        res = numTwo / numOne;                           
                        }
                        break;
                case '-':
                    if (numOne > numTwo)
                    {
                        res = numOne - numTwo;
                    } else
                    {
                        res = numTwo - numOne;
                    }
                    break;
            }
            Console.WriteLine($"The result of the operation ({op}) is {res} .");
            Console.ReadLine();
        }
    }
}
