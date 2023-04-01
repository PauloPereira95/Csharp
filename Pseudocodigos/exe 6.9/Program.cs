using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_6._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i <= 100; i++) {
                // check if is multiple of 10, devide by 10
                if (i % 10 == 0)
                {
                    Console.WriteLine($"Multiplo de 10 : {i}");
                }
            }
            Console.ReadLine();
        }
    }
}
