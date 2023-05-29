using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            try
            {
                // ask age
                Console.WriteLine("Tell me, whats your age ? ");
                age = int.Parse(Console.ReadLine());
                // check if as adult or not
                if (age >= 18)
                {
                    Console.WriteLine("You are a adult");
                } else
                {
                    Console.WriteLine("You are a minor");
                }

            } catch (Exception ex)
            {
                Console.WriteLine("Error ->" + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
