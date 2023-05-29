using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_6._2_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculat the IMC taking into acount the person gender (M/F)
            double height,perfectW = 0;
            string gender;
            //---------------------------
            // ask the gender and height
            Console.WriteLine("Tell me, you are a Men or a Woman ? ");
            gender = Console.ReadLine();
            Console.WriteLine("Height: ");
            height = double.Parse(Console.ReadLine());
            //----------------------------
            // Check the gender and calculate da perfect weight wich gender
            if (gender == "men" || gender == "Men")
            {
                perfectW = ((72.7 * height) - 58);
            } else if (gender == "woman" || gender == "Woman")
            {
                perfectW = ((62.1 * height) - 44.7);
            }
            //------------------------------
            // Show Results and round 1 decimal 
            Console.WriteLine($"Your Perfect Weigth is : {Math.Round(perfectW,1)}");
            Console.ReadLine();
        }
    }
}
