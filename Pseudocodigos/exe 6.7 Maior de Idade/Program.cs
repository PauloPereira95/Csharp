using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_6._7_Maior_de_Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare var ( age for the value of the user ) numAdults( store the adults, more or
            // equal then 18)
            int age,numAdults =0;
            // try ask's the age of 10 person
            try
            {
                for (int i= 1; i <= 10; i++)
                {
                    Console.WriteLine($"Type the age of the {i}º person : ");
                    age = int.Parse(Console.ReadLine());
                    // verify if is adult
                    if (age >= 18)
                    {
                        numAdults++;
                    }
                }
                // show the total of adults
                Console.WriteLine($"Number of adults is {numAdults}");

            } catch // if something goes wrong
            {
                // show error mesage
                Console.WriteLine("The value is incorrect , Try Again !");
            }
            Console.ReadLine();
        } 
    }
}
