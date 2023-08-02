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
                    //db.Add<Supplier>(new()
                    //{
                    //        Name = "Monarq",
                    //        NIF = "5436000",
                    //        Tele = "956789903",
                    //        Adrress = "Rua do carneiro leve 22",

                    //    });
                    //db.SaveChanges();
                    //Console.WriteLine("Supplier Entered Successsfully !");
                    // ------------------- SELECT -------------------
                    //var query_sup_ext = db.Suppliers.Select(s => new { s.Name, s.NIF, s.Adrress });

                    #endregion
                    #region add product
                    //var sup = db.Suppliers.Where(s => s.Name == "Cash an Cary").Single();

                    //db.Product.Add(new()
                    //{

                    //    Name = "Vinho tinto",
                    //    Price = 99.3m,
                    //    Stock = 10,
                    //    Ingredients = "uva,produto conservante,lavanda",
                    //    ExpDate = DateTime.Now,
                    //    Order = null,
                    //    Supplier = new[] { sup }

                    //});
                    //db.SaveChanges();
                    //Console.WriteLine("Product update Successsfully !");

                    #endregion
                    #region add Costumer 
                    //db.Costumer.Add(new()
                    //{
                    //    Name = "Paulo",
                    //    Adress = "Rua dos nortenhos",
                    //    Tele = "912345678"

                    //});
                    //db.SaveChanges();
                    //Console.WriteLine("Costumer Insert Sucessfuly");
                    #endregion
                    #region add Money 
                    //db.Money.Add(new ()
                    //{
                    //    FiveEuro=1,
                    //    OneCent=1,
                    //    OneEuro = 1,
                    //    QuarterCent = 1,
                    //    TenCent = 1,
                    //    TwentyCent = 1,
                    //});
                    //db.SaveChanges();
                    //Console.WriteLine("Money Insert Sucessfuly");
                    #endregion
                    #region atribui money a costumer com update
                    //var cost_Money = (from c in db.Costumer
                    //                  where c.Name == "Paulo"
                    //                  select c).Single();
                    //var money = (from m in db.Money
                    //             select m).Single();
                    ////cost_Money.Money = new[] { money };
                    //db.SaveChanges();
                    //Console.WriteLine("money update sucessfuly");
                    var prod = (from p in db.Product
                                      where p.Name == "Vinho tinto"
                                      select p).Single();
                    var sup = from s in db.Suppliers
                                 select s;
                    prod = new[] { sup };
                    db.SaveChanges();
                    Console.WriteLine("money update sucessfuly");
                    #endregion
                    #region Add Order
                    //var costumer = (from c in db.Costumer
                    //                where c.Name == "Paulo"
                    //                select c).Single();
                    //var product = (from p in db.Product
                    //               where p.Name == "Vinho branco"
                    //               select p).Single();
                    //db.Order.Add(new()
                    //{
                    //    Name = "Encomenda para venda ao publico",
                    //    Date = DateTime.Now,
                    //    Costumer = costumer,
                    //    Product = new[] { product }
                    //});
                    //db.SaveChanges();
                    //Console.WriteLine("Order insert sucessfuly");

                    //var res = db.Product.Where(p => p.Name == "Vinho branco").Include("Supplier");
                    ////Console.WriteLine($"{res.Name} || {res.Supplier.First().Name}");
                    //var res_query = from p in db.Product
                    //                join s in db.Suppliers
                    //                on p.IDProduct equals s.Product.Single().IDProduct
                    //                select new
                    //                {
                    //                    prod = p.Name,
                    //                    forn =s.Name ,
                    //                };

                    //foreach (var item in res_query)
                    //{
                    //    Console.WriteLine($"{item.prod} || {item.forn}");
                    //}
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