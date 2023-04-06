namespace exe_2_Sum_Pares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double i = 0, sum = 0, val;
                Console.WriteLine("Type the value to sum the pairs ");
                val = double.Parse(Console.ReadLine());

                while (i <= val)
                {
                    sum += i;
                    i += 2;
                }
                Console.WriteLine($"Total -> {sum}");

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}