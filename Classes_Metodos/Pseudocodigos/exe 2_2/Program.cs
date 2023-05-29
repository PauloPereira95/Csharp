namespace exe_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, sum = 0;
            try
            {
                Console.WriteLine("Type the limit number :");
                num = double.Parse(Console.ReadLine());

                for (double i = 0.000; i <= num; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine($"The total is -> {sum}");

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}