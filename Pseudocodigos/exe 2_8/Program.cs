namespace exe_2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
                for (int i = 1; i<=10;i++)
                {
                    for ( int j = 1; j<=10;j++)
                    {
                        Console.WriteLine($"{i} * {j} = {i*j}");
                        if (j == 10)
                        {
                            // just for better view
                            Console.WriteLine("-------------------");
                        }
                    }
                }
        }
    }
}