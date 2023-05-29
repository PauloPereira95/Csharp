namespace _12deMaio_POO
{
    internal class Program
    {
        static int global = 5;
        static void Main(string[] args)
        {
            pessoa pessoa1 = new pessoa();
            pessoa1.nome = "Ana";
            pessoa1.DataNascimento= new DateTime(2000,6,23);
            Console.WriteLine($"{pessoa1.nome} {pessoa1.Idade}");
        }
    }
    
}