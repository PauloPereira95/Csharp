namespace exe_2_5_Para_primo_composto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, div = 0;
            // try do this
            try
            {
                // ask for the value
                Console.WriteLine("Type the number :");
                num = int.Parse(Console.ReadLine());
                // do the cicle to verifiy dividers
                for (int i = 2; i<= num/ 2; i ++)
                {
                    //if  remainder of division is 0 then increment there variable div
                    if ( num % i == 0)
                    {   
                        Console.WriteLine(i);
                        div ++;
                    }
                }
                // if dividers is 2 then is a prime if not is a not prime
                if (div == 0)
                {   

                    Console.WriteLine("Prime");
                } else
                {
                    Console.WriteLine("Not Prime !");
                }
            }
            // id something goes wrong then show a error
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}