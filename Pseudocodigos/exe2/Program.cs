using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double volume, raio, heigth, diameter,area,perimiter;
            // ask de diameter
            Console.WriteLine("Insert the cylinder diameter in centimeters: ");
            diameter = double.Parse(Console.ReadLine());
            // ask the heigth
            Console.WriteLine("Insert the heigth in centimeters :");
            heigth = double.Parse(Console.ReadLine());

            // find raio 
            raio = diameter / 2;

            // area
            area = pi * Math.Pow(raio, 2);
            // perimeter
            perimiter = 2 * pi * raio;
            // volume
            volume = pi * Math.Pow(raio, 2) * heigth;

            // show results
            Console.WriteLine($"Area : {area} || Perimeter: {perimiter} || Volume: {volume}");
            Console.ReadLine();
        }
    }
}
