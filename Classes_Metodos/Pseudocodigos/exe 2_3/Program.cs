namespace exe_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double val, sum = 0, avg = 0;
            for ( int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Digite the {i}º value");
                val = double.Parse(Console.ReadLine());
                sum += val;
            }
            avg = sum / 10;
            Console.WriteLine($"The sum is -> {sum} || The avg is  -> {avg}");
        }
    }
}