using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, total = 0;
            // try calculate sum
            try
            {
                // ask one integer number
                Console.WriteLine("Type one integer number");
                num = int.Parse(Console.ReadLine());
                // calculate sum
                for ( int i = 0; i <= num;i++)
                {
                    total += i;
                }
                Console.WriteLine($"The total is : {total}");
            // if the value is not a number
            } catch
            {
                Console.WriteLine("ERROR ! The value is not a number !");
            }
            Console.ReadLine();
        }
    }
}
