using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valOne, valTwo, valThree, semiP, Per, area;
            Console.WriteLine("Insert Value One :");
            valOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert Value Two :");
            valTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert value Three : ");
            valThree = double.Parse(Console.ReadLine());

            if ((valOne < valTwo + valThree) && (valTwo < valOne + valThree) && (valThree < valOne + valTwo) )
            {
                if ((valOne == valTwo) && (valTwo == valThree))
                {
                    Console.WriteLine("Equilatero !");
                } else if (valOne == valTwo || valTwo == valThree || valOne == valThree)
                {
                        Console.WriteLine("Isosceles");
                } else
                {
                    Console.WriteLine("Escaleno");
                }
            } else
            {
                Console.WriteLine("Não é possivel formar um triangulo");

            }
            semiP = (valOne + valTwo + valThree);
            Per = semiP + semiP;
            area = Math.Sqrt(Per * (Per - valOne) * (Per - valTwo) * (Per - valThree));
            Console.WriteLine($"SemiPerimetro -> {semiP}");
            Console.WriteLine($"Area -> {area}");
            Console.ReadLine();
        }
    }
}
