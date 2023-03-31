using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.WriteLine("Digite a sua idade :");
            idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("É maior de idade ");
            } else
            {
                Console.WriteLine("É menor de idade");
            }
            Console.ReadLine();
        }
    }
}
