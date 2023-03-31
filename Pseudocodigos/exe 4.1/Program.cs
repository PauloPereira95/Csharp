using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace exe_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nVal = 0, i = 0;
            double average = 0, sum = 0, val = 0;
            // Equanto o numero de digitos for 0 o programa pergunta ao ulizador
            // Quantos numeros pretende calcular a soma e a média
            do
            {
            Console.WriteLine("How many values do you want to enter ?");
            nVal = int.Parse(Console.ReadLine());

            } while (nVal == 0);

            // Enquanto o contador for menor que o input do user (Numero de numeros)
            // ele calcula a soma e a média
            while (i < nVal)
            {
                Console.WriteLine("Digite o valor");
                val = double.Parse(Console.ReadLine());
                sum += val;
                average = sum / nVal;
                i++;
            }
            // Apresenta os resultados com String Format
            Console.WriteLine($"A soma é {sum}");
            Console.WriteLine($"A Media é {average}");
            Console.ReadLine();
        }
    }
}
