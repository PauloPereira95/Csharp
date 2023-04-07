namespace exe_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor, temp;
            Console.WriteLine("Insert the numbner ! ;)");
            valor = int.Parse(Console.ReadLine());

            while (valor!= 0)
            {
                temp = valor % 10;
                Console.WriteLine(temp);
                valor /= 10;
            }

        }
    }
}