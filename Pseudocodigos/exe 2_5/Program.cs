﻿namespace exe_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, major, minor;
            try
            {
                Console.Write("Type the number : ");
                num = double.Parse(Console.ReadLine());
                major = num;
                minor = num;
                for ( int i = 1; i<=9;i++)
                {
                    Console.Write("Type the number : ");
                    num = double.Parse(Console.ReadLine());
                    if ( num > major)
                    {
                        major = num;
                    } else if (num < minor)
                    {
                        minor = num;
                    }
                }
                Console.WriteLine($"Minor -> {minor} || Major -> {major}");

            } catch (Exception e)
            {
                Console.WriteLine(e.Message + " Type a integer number !");
            }
        }
    }
}