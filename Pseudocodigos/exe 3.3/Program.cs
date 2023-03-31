using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a suda idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade <=12) 
            {
                Console.WriteLine("Criança");

            } else if(idade > 12 && idade <=16)
            {
                Console.WriteLine("Adolescente");

            } else if (idade > 16 && idade <= 22)
            {
                Console.WriteLine("Jovem");

            } else if (idade > 22 && idade <=64)
            {
                Console.WriteLine("Adulto");
            } else
            {
                Console.WriteLine("Sénior");
            }
            Console.ReadLine();

        }
    }
}
