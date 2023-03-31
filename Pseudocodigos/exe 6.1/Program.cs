using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Whats your name ? ");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name} ! :)");
            Console.ReadLine();
        }
    }
}
