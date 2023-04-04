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

            double volume, radius, heigth,area,perimiter;
            // ask de diameter
            Console.WriteLine("Insert the cylinder diameter in centimeters: ");
            radius = double.Parse(Console.ReadLine());
            // ask the heigth
            Console.WriteLine("Insert the heigth in centimeters :");
            heigth = double.Parse(Console.ReadLine());

            // find radius 
            radius = radius / 2;
            // area
            area = Math.PI * Math.Pow(radius, 2);
            // perimeter
            perimiter = 2 * Math.PI * radius;
            // volume
            volume = Math.PI * Math.Pow(radius, 2) * heigth;

            // show results
            Console.WriteLine($"Area : {area} || Perimeter: {perimiter} || Volume: {volume}");
            Console.ReadLine();
        }
    }
}
