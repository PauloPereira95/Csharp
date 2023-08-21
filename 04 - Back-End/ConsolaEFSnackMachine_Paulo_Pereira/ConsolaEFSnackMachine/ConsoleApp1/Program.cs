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
                #region insert remove update forma 1
                //Supplier s = new Supplier();
                //using (var conn = new ApplicationDbContext())
                //{
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

                //// --- UPDATE --------------
                //var registo = conn.Suppliers.Where(s => s.Tele == "tele 152").FirstOrDefault();
                //registo.Tele = "123456789";

                ////conn.Suppliers.Where(x => x.NIF == "nif 152").ExecuteUpdate(s => s.SetProperty(s => s.NIF, x => "nif 999"));
                //conn.SaveChanges();
                //Console.WriteLine("update com sucesso");
                // -------------------------
                //}
                #endregion
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    #region add supplier

                    //db.Suppliers.Add(new()
                    //{
                    //    Name = "Queiroz Bebidas",
                    //    NIF = "320900909",
                    //    Tele = "9134568795",
                    //    Adrress = "Rua do passo n245",

                    //});
                    //db.SaveChanges();
                    //Console.WriteLine("Supplier Entered Successsfully !");
                    // ------------------- SELECT -------------------
                    var query_sup_ext = db.Suppliers.Select(s => new { s.Name, s.NIF, s.Adrress });
                    
                    #endregion
                    #region add product
                    var sup = db.Suppliers.Where(s => s.Name == "Queiroz Bebidas").Single();

                    db.Product.Add(new()
                    {
                        
                        Name = "Coca-cola",
                        Price = 2.3m,
                        Ingredients = "laranja,limao,lavanda",
                        ExpDate = DateTime.Now,
                        Position = null,
                        Machine = null,
                        Supplier = new[] { sup }

                    });
                    Console.WriteLine("Product Entered Successsfully !");
                    db.SaveChanges();
                    var product  = db.Product.Where(s => s.Name == "Coca-cola").Single();
                    sup.Product = new[] { product };
                    db.SaveChanges();
                    #endregion
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }





        }
    }
}