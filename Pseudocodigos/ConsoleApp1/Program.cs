using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, gender;
            Console.WriteLine("Type your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Type your gender : ");
            gender = Console.ReadLine();
            if ( gender == "m" || gender == "masculine" || gender == "men")
            {
                Console.WriteLine("Exmo. Sr " + name);
            } else if (gender =="woman" || gender =="w" || gender == "feminine") {
                Console.WriteLine("Exma. Sra " + name);
            }
            Console.ReadLine();
        }
    }
}
