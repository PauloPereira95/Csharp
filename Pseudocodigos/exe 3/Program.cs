using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempC, tempF;

            Console.WriteLine($"Type de Celsius temperature :");
            tempC = double.Parse(Console.ReadLine());

            tempF = (tempC * 1.8) + 32;
            Console.WriteLine($"Temperature in Fahrenheit: -> {tempF}F ");
            Console.ReadLine();
        }
    }
}
