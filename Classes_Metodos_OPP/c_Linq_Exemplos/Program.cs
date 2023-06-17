using System.Linq;

namespace c_Linq_Exemplos
{
    internal class Program
    {
        static List<Produto> produtos = Dados.Produtos();
        static List<Categoria> categorias = Dados.Categorias();
        static List<Marca> marcas = Dados.Marcas();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // 1 - Query
            var q1 = from p in produtos select p;
            // method syntax
            var _q1 = produtos.Select(p => p);

            // 2 - Query
            var q2 = from p in produtos select new { p.Nome, p.Preco, p.Stock };
            // method Sintax

            var _q2 = produtos.Select(p => new { p.Nome, p.Preco, p.Stock });
            // 3 - Query
            var q3 = from p in produtos where p.Preco > 250 select new { p.Nome, p.Preco };
            // Method Sintax
            var _q3 = produtos.Where(p => p.Preco > 250).Select(p => new { p.Nome, p.Preco });

            // 4 - Query
            var q4 = from p in produtos where p.DataInicioVenda.Year == 2020 && p.Preco > 250 select new { p.Nome, p.Preco, p.DataInicioVenda };
            // Method 
            var _q4 = produtos.Where(p => p.DataInicioVenda.Year == 2020 && p.Preco > 250).Select(p => new { p.Nome, p.Preco, p.DataInicioVenda });

            // 5 - Query 
            var q5 = from p in produtos where p.Preco < 100 && p.DataInicioVenda.Year == 2020 select new { p.Nome, p.Preco, p.DataInicioVenda };
            // Method 
            var _q5 = produtos.Where(p => p.Preco < 100 && p.DataInicioVenda.Year == 2020).Select(p => new { p.Nome, p.Preco, p.DataInicioVenda });

            // 6 - Query 
            var q6 = from p in produtos where p.Nome.Contains("SSD") select new { p.Nome, p.Preco };
            // Method Query 
            var _q6 = produtos.Where(p => p.Nome.Contains("SSD")).Select(p => new { p.Nome, p.Preco });

            // 7 - Query 
            var q7 = from p in produtos orderby p.Preco select new { p.Nome, p.Preco, p.DataInicioVenda };
            // Method 
            var _q7 = produtos.OrderBy(p => p.Preco).Select(p => new { p.Nome, p.Preco }); ;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{"NomeMarca",-40}{"Nome Prod",-80}{"Preço",-20}");
            Console.ResetColor();
            foreach (var item in produtos)
            {
                Console.WriteLine($"{item.Nome,-80}{item.DataInicioVenda.ToShortDateString(),-50}{item.Stock,-3}{item.Preco,-10}");
            }
            //foreach (var item in categorias)
            //{
            //    Console.WriteLine(item.Nome);
            //}
            // Query Join

            var q = from p in produtos
                    join c in categorias on p.IdCategoria equals c.IdCategoria
                    select new
                    {
                        Produto = p.Nome,
                        Categoria = c.Nome
                    };
            var _q = produtos.Join(categorias, p => p.IdCategoria, c => c.IdCategoria, (p, c) => new
            { produtos = p.Nome, Categoria = c.Nome });
            //foreach (var item in q)
            //{
            //    Console.WriteLine($"{item.Produto,-80}{item.Categoria,-20}");
            //}

            var q8 = from p in produtos
                     join c in categorias on p.IdCategoria equals c.IdCategoria
                     join m in marcas on p.IdMarca equals m.IdMarca
                     select new
                     {
                         Produto = p.Nome,
                         p.Preco,
                         Categoria = c.Nome,
                         marca = m.Nome
                     };
            var _q8 = produtos.Join(categorias, p => p.IdCategoria, c => c.IdCategoria,
                (p, c) => new { p, c }).Join(marcas, prod => prod.p.IdMarca, m => m.IdMarca,
                (prod, m) => new { prod, m }).Select(x => new
                {
                    Produto = x.prod.p.Nome,
                    x.prod.p.Preco,
                    Categoria = x.prod.c.Nome,
                    Marca = x.m.Nome
                });
            var teste = from m in marcas select new { m.IdMarca, m.Nome };
            //foreach (var item in _q8)
            //{
            //    Console.WriteLine($"{item.Produto,-80}{item.Preco,-20}{item.Categoria,-30}{item.Marca,-40}");
            //}
            // 3.9. Lista de produtos com stock inferior a 3; mostrar nome e stock do produto e nome da respetiva categoria;
            var q9 = from p in produtos
                     join c in categorias
                     on p.IdCategoria equals c.IdCategoria
                     select new
                     {
                         NomeProduto = p.Nome,
                         StockProduto = p.Stock,
                         NomeCategoria = c.Nome
                     };
            var _q9 = produtos.Join(categorias, p => p.IdCategoria, c => c.IdCategoria, (p, c) => new { p, c })
                .Select(x => new
                {
                    NomeProd = x.p.Nome,
                    StockProd = x.p.Stock,
                    NomeCate = x.c.Nome
                });
            //foreach (var item in _q9)
            //{
            //    Console.WriteLine($"{item.NomeProd,-80}{item.StockProd,-20}{item.NomeCate,-40}");
            //}
            // 3.10 Lista de marcas que tenham produtos com preço superior a 150€; mostrar nome da marca, nome e preço do produto;
            var q10 = from m in marcas
                      join p in produtos
                      on m.IdMarca equals p.IdMarca
                      where p.Preco > 150
                      select new
                      {
                          NomeMarca = m.Nome,
                          NomeProd = p.Nome,
                          PrecoProduto = p.Preco
                      };
            var _q10 = produtos.Where(p => p.Preco > 150).Join(marcas, p => p.IdMarca, m => m.IdMarca, (p, m) => new { p, m }).Select(s => new
            {
                NomeProd = s.p.Nome,
                NomeMarca = s.m.Nome,
                PrecoProd = s.p.Preco
            });
            //foreach (var item in _q10)
            //{
            //    Console.WriteLine($"{item.NomeMarca,-40}{item.NomeProd,-80}{item.PrecoProd,-20:C}");
            //}
            // 3.11 3.11. Lista de produtos cujo nome inclua o termo SATA; mostrar nome do produto, nome da categoria e da marca;
            var q11 = from p in produtos
                      join c in categorias on p.IdCategoria equals c.IdCategoria
                      join m in marcas on p.IdMarca equals m.IdMarca
                      where p.Nome.Contains("SATA")
                      select new
                      {
                          NomeProd = p.Nome,
                          NomeCat = c.Nome,
                          NomeMarca = m.Nome
                      };
            var _q11 = produtos.Join(categorias, p => p.IdCategoria, c => c.IdCategoria, (p, c) => new { p, c }).
                Join(marcas, prod => prod.p.IdMarca, m => m.IdMarca, (prod, m) => new { prod, m }).Select(s => new
                {
                    NP = s.prod.p.Nome,
                    NC = s.prod.c.Nome,
                    NM = s.m.Nome
                });
            //foreach (var item in _q11)
            //{
            //    Console.WriteLine($"{item.NP,-80}{item.NC,-30}{item.NM,-30}");
            //}
            // 3.12. Lista de produtos das marcas Asus e Samsung; mostrar nome do produto e da marca; ordenar a lista de forma ascendente pelo nome do produto;
            var q12 = from p in produtos
                      join m in marcas on p.IdMarca equals m.IdMarca
                      where m.Nome.Contains("Asus") || m.Nome.Contains("Samsung")
                      orderby p.Nome
                      select new
                      {
                          NomeProd = p.Nome,
                          NomeMarca = m.Nome
                      };
            var _q12 = produtos.Where(p => p.Nome.Contains("Asus") || p.Nome.Contains("Samsung")).
                Join(marcas, p => p.IdMarca, m => m.IdMarca, (p, m) => new { p, m }).
                Select(s => new
                {
                    NP = s.p.Nome,
                    NM = s.m.Nome
                });
            //foreach (var item in q12)
            //{
            //    Console.WriteLine($"{item.NomeProd,-80}{item.NomeMarca,-20}");
            //}
            // 3.13. Lista de marcas que tenha produtos cuja venda se tenha iniciado no primeiro semestre de 2021; mostrar nome da marca e nome e data de início de venda do produto;
            Console.WriteLine("\n");
            var q13 = from p in produtos
                      join m in marcas on p.IdMarca equals m.IdMarca
                      where p.DataInicioVenda.Year == 2021 && p.DataInicioVenda.Month <= 6
                      select new
                      {
                          NomeProduto = p.Nome,
                          NomeMarca = m.Nome,
                          DataVenda = p.DataInicioVenda
                      };
            var _q13 = produtos.Where(dt => dt.DataInicioVenda.Month < 6 && dt.DataInicioVenda.Year == 2021)
                .Join(marcas, p => p.IdMarca, m => m.IdMarca, (p, m) => new { m, p }).
                Select(S => new
                {
                    NP = S.p.Nome,
                    NM = S.m.Nome,
                    DT = S.p.DataInicioVenda.ToShortDateString()
                });
            //foreach (var item in _q13)
            //{
            //    Console.WriteLine($"{item.NP,-80}{item.NM,-30}{item.DT,-50}");
            //}
            // 3.14 Lista de produtos das categorias Armazenamento e Periféricos que tenham preço entre 50€ e 125€; mostrar nome da categoria, nome e preço do produto;
            var q14 = from p in produtos
                      join c in categorias on p.IdCategoria equals c.IdCategoria
                      where (p.Preco >= 50 && p.Preco <= 125) && (c.Nome.Contains("Armazenamento") || c.Nome.Contains("Perifericos") )
                      select new
                      {
                          NomeProd = p.Nome,
                          PrecoProd = p.Preco,
                          NomeCate = c.Nome

                      };

            var _q14 = produtos.Where(p => p.Preco >= 50 && p.Preco <= 125).
                Join(categorias.Where(c => c.Nome.Contains("Armazenamento") || c.Nome.Contains("Perifericos")), p => p.IdCategoria, c => c.IdCategoria, (p, c) => new { p, c }).

                Select(s => new
                {
                    NP = s.p.Nome,
                    PP = s.p.Preco,
                    NC = s.c.Nome
                });
            //foreach (var item in q14)
            //{
            //    Console.WriteLine($"{item.NomeProd,-80}{item.PrecoProd,-10:C}{item.NomeCate,-40}");
            //}
            //3.15.Lista de produtos; mostrar nome da categoria, nome e preço do produto; ordenar a lista de forma ascendente pelo nome da categoria, seguida de ordenação ascendente pelo nome do produto;
            var q15 = from p in produtos
                      join c in categorias on p.IdCategoria equals c.IdCategoria 
                      orderby c.Nome, p.Nome
                      

                      select new
                      {
                          NomeCat = c.Nome ,
                          NomeProd = p.Nome,
                          PrecoProd = p.Preco
                      };
            var _q15 = produtos.Join(categorias, p=> p.IdCategoria , c => c.IdCategoria, (p,c) => new {p,c}).
                Select(s => new
                {
                    NC = s.c.Nome,
                    NP = s.p.Nome,
                    PP = s.p.Preco
                }).OrderBy(s => s.NC).ThenBy(s => s.NP);
            foreach (var item in _q15)
            {
                Console.WriteLine($"{item.NC,-30}{item.NP,-80}{item.PP}");
            }

        }

    }

}