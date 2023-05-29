namespace exe_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long valor, temp;
            Console.WriteLine("Insert the numbner ! ;)");
            valor = long.Parse(Console.ReadLine());

            while (valor!= 0)
            {
                temp = valor % 10;
                Console.WriteLine(temp);
                valor /= 10;
            }

        }
    }
}