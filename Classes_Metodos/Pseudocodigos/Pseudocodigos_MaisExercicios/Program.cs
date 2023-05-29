using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pseudocodigos_MaisExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double side,area,per;
                // ask the side 
                Console.WriteLine("What is the side length of the square in centimeters :");
                side = double.Parse(Console.ReadLine());

                // calculate the area
                area = Math.Pow(side,2);
                // calculate the perimeter
                per = side * 4;

                //show results
                Console.WriteLine($"Area: {area} cm || Permiter: {per} cm");
            } catch
            {
                Console.WriteLine("Wrong Data ! Try Again !");
            }
                Console.ReadLine();
        }
    }
}
