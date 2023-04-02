using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h, m, s, res;
            try
            {
                Console.WriteLine("Type the hours :");
                h = int.Parse(Console.ReadLine());
                Console.WriteLine("Type the minuts :");
                m = int.Parse(Console.ReadLine());
                Console.WriteLine("Type the secunds :");
                s = int.Parse(Console.ReadLine());

                res = (h * 3600) + (m * 60) + s;
                Console.WriteLine($"The time in secunds is : {res}");
                
            } catch (Exception ex)
            {
                Console.WriteLine("ERROR : " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
