namespace exe_2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100;i++)
            {
                if ( i % 2 == 0 && i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}