namespace exe_2_1_Para_sum_avg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numVal, val, sum = 0, avg = 0;

            Console.WriteLine("Type how many numbers do you want insert ");
            numVal = double.Parse(Console.ReadLine());

            for (int i = 1; i<=numVal ;i++)
            {
                Console.WriteLine($"Insert the {i}º number :");
                val = double.Parse(Console.ReadLine());
                sum += val;
            }
            avg = sum / numVal;
            Console.WriteLine($" Sum -> {sum} || Average -> {avg}");
                    
        }
    }
}