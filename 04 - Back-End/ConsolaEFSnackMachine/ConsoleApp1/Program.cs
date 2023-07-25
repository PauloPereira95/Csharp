using ConsoleSnackMachine.Data;
using ConsoleSnackMachine.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleSnackMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Supplier s = new Supplier();
                using (var conn = new ApplicationDbContext())
                {
                    // ---- Insert -----------
                    //s.IDSupplier = Guid.NewGuid();
                    //s.Name = "Test 52";
                    //s.NIF = "nif 152";
                    //s.Tele = "tele 152";
                    //s.Adrress = "addres 152";
                    //conn.Add(s);
                    //conn.SaveChanges();

                    //s.IDSupplier = Guid.NewGuid();
                    //s.Name = "Test 32";
                    //s.NIF = "nif 32";
                    //s.Tele = "tele 332";
                    //s.Adrress = "addres 332";

                    //conn.Add(s);
                    //conn.SaveChanges();
                    //Console.WriteLine(" Inserido com Sucesso");
                    //----------------------------

                    // ---- Remove -----------------
                    //conn.Suppliers.Where(sup => sup.Name == "test 32").ExecuteDelete();
                    //conn.SaveChanges();
                    ////Console.WriteLine(" Removido com Sucesso");
                    //--------------------------

                    // --- UPDATE --------------
                    var registo = conn.Suppliers.Where(s => s.Tele == "tele 152").FirstOrDefault();
                    registo.Tele = "123456789";

                    //conn.Suppliers.Where(x => x.NIF == "nif 152").ExecuteUpdate(s => s.SetProperty(s => s.NIF, x => "nif 999"));
                    conn.SaveChanges();
                    Console.WriteLine("update com sucesso");
                    // -------------------------

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}