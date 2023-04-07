namespace exe_3_decompor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val, inverse = 0, temp;
            Console.WriteLine("Type the number");
            val = int.Parse(Console.ReadLine());
            
            while (val != 0)
            {
                temp = val % 10;
                inverse = inverse * 10 + temp;
                val = val / 10;

            }
            Console.WriteLine($"Result : {inverse}");
        }
    }
}