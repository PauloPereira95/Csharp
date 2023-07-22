using ConsoleSnackMachine.Data;
using ConsoleSnackMachine.Models;

namespace ConsoleSnackMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //using (var conn = new ApplicationDbContext())
                //{
                //    Supplier s = new Supplier();
                //    s.IDSupplier = Guid.NewGuid();
                //    s.Name = "Test 2";
                //    s.NIF = "nif 12";
                //    s.Tele = "tele 12";
                //    s.Adrress = "addres 12";
                //    conn.Add(s);
                //    conn.SaveChanges();
                //    Console.WriteLine("Sucesso");
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}