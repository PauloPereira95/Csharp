using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numUser,i = 0,sum = 0;
            do
            {
            Console.WriteLine("Type up to wich number you want to add the pairs");
            numUser = int.Parse(Console.ReadLine());
            } while (numUser == 0);

            while (i <= numUser)
            {
                if ( i % 2 == 0)
                {
                    sum += i;
                }
                i++;
            }
            Console.WriteLine($"The Total is : {sum}");
            Console.ReadLine();
        }
    }
}
