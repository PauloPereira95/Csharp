using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            try
            {
                Console.WriteLine("Insert your age :");
                age = int.Parse(Console.ReadLine());

                if (age <= 12)
                {
                    Console.WriteLine("You are adolescent !");
                } else if (age <= 16){
                    Console.WriteLine("You are a Juvenile ");
                } else if (age <= 22 )
                {
                    Console.WriteLine("You are a Youth");
                } else if (age <= 64) 
                {
                    Console.WriteLine("You are a Adult ");
                } else
                {
                    Console.WriteLine("You are a Senior");
                }
            } catch (Exception ex)
            {
                Console.WriteLine("ERROR ->" + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
