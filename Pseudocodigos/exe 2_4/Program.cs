namespace exe_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int num;
            // try do this
                try
            {

                // ask for the value 
                Console.WriteLine("Which multiplication table do you want to see ? ");
                num = int.Parse(Console.ReadLine());
                // do the multiplication table
                for (int i = 1; i<=10;i++)
                {   
                    // if is the first row
                    if ( i == 1)
                    {
                        // insert a line to sperate de line from the input
                        Console.WriteLine("-------------------");
                        Console.WriteLine($"{num} * {i} = {num * i}");

                    } else
                    // else continue show the multiplication
                    {
                        Console.WriteLine($"{num} * {i} = {num * i}");

                    }
                }
            // if something goes wrong show a error message
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}