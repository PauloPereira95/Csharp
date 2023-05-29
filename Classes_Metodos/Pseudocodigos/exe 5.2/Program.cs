using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, numUser;
            Console.WriteLine("Type the limit number : ");
            numUser = int.Parse(Console.ReadLine());

            for(int i = 0; i< numUser; i++)
            {
                if ( i % 2 > 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Total : {sum}");
            Console.ReadLine();
        }
    }
}
