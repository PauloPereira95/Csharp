using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;
using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {
        static List<Produto> produtos = new List<Produto>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            lerFicheiro();
            #region Mostrar Ficheiro
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{"Produto",-30}{"Marca",-20}{"Categoria",-15}" +
                $"{"Peco S/Iva",-25}{"Preço C/IVA",-25}{"Stock",-10}" +
                $"{"Data de Inicio de Venda",30}\n");
            Console.ResetColor();
            foreach (var item in produtos)
            {
                Console.WriteLine($"{item.Nome, -30}{item.Marca,-20}{item.Categoria,-15}" +
               $"{item.Preco,-25:C}{item.PrecoFinal,-25:C}{item.Stock,-10}" +
               $"{item.DataInicioVenda.ToShortDateString(),30}");
            }
            #endregion
            #region Questoes
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------- Questões --------------------");
            Console.ResetColor();
            exe_06();
            #endregion

        }
        static void lerFicheiro()
        {
            // Definição da Localização do Ficheiro
            // A opção AppDomain.CurrentDomain.BaseDirectory aponta para
            // a pasta \bin\Debug\Net7.0 (onde é colocada a Assembly - exe, do projeto)
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\produtos.txt";

            // A Class StreamReader permite ler informação do ficheiro texto
            using (StreamReader sr = new StreamReader(path))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    //no ficheiro, os dados encontram-se separados pelo caracter |
                    //o método Split permite obter um Array do tipo string, com os 
                    // valores definifos em cada linha
                    string[] parts = linha.Split('|');

                    // criar novo Produto e definir Valores das propriedades
                    Produto produto = new Produto();

                    produto.Nome = parts[0];
                    produto.Preco = decimal.Parse(parts[1]);
                    switch (parts[2])
                    {
                        case "0": produto.Iva = TaxasIva.Isento; break;
                        case "6": produto.Iva = TaxasIva.Reduzida; break;
                        case "13": produto.Iva = TaxasIva.Intermedia; break;
                        case "23": produto.Iva = TaxasIva.Normal;break;
                    }
                    produto.Stock= short.Parse(parts[3]);
                    produto.DataInicioVenda = DateTime.Parse(parts[4]);
                    produto.Marca = parts[5];
                    produto.Categoria = parts[6];
                    // Adicionar á lista produtos
                    produtos.Add(produto);

                }
            }

        }
        static void exe_06()
        {
            // 3.1. Listar os produtos ordenados de forma ascendente pelo atributo preço final;
            // mostrar nome do produto, preço final, marca e categoria;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------ ORDER BY DESCENDING -----------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{"Produto",-30}{"Preço Final",-15}{"Marca",-20}{"Categoria",-20}\n");
            Console.ResetColor();
            foreach (var item in produtos.OrderBy(p => p.PrecoFinal))
            {
                Console.WriteLine($"{item.Nome,-30}{item.PrecoFinal,-15:C}{item.Marca,-20}{item.Categoria,-20}");
            }
            // 3.2. Indicar o preço médio dos produtos da categoria Periféricos;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---- Preço Medio da Categoria Perifericos ------------");
            Console.ResetColor();
            Console.WriteLine($"Preço Médio Perifericos -> {Math.Round(produtos.Where(c => c.Categoria.Contains("Periféricos")).Average(p => p.PrecoFinal),2):C}");
            // 3.3. Listar todos os produtos cujo nome inclua a palavra SSD;
            // mostrar nome do produto, marca e categoria;
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("---------- Produtos SSD --------------------");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{"Produto",-30}{"Marca",-20}{"Categoria",-20}\n");
            Console.ResetColor();
            foreach (var item in produtos.Where(c => c.Nome.Contains("SSD")))
            {
                Console.WriteLine($"{item.Nome,-30}{item.Marca,-20}{item.Categoria,-20}");
            }
            // 3.4. Indicar o total de produtos (Count) da marca Asus;
            Console.WriteLine();
            Console.WriteLine("-------------- Total Produtos Asus --------");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{"Produto",-30}{"Marca",-20}{"Categoria",-20}{"Preço Final",-20}{"IVA",-20}\n");
            Console.ResetColor();
            foreach (var item in produtos.Where(c => c.Marca.Contains("Asus")))
            {
                Console.WriteLine($"{item.Nome,-30}{item.Marca,-20}{item.Categoria,-20}{item.PrecoFinal,-20:C}{item.Iva,-20}");
            }
            Console.WriteLine($"\nTotal Produtos Asus -> {produtos.Where(c => c.Marca.Contains("Asus")).Count()}");
            //3.5.Listar todos os produtos cuja venda se iniciou em 2019 ou 2020; mostrar nome do produto, data de início de venda, marca e categoria;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------------------- Produtos Vendidos em 2019 e 2020 -----------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{"Produto",-30}{"Data Inicio de Venda",-30}{"Marca",-20}{"Categoria",-30}\n");
            Console.ResetColor();
            foreach (var item in produtos.Where(f => f.DataInicioVenda.Year == 2019 || f.DataInicioVenda.Year == 2020))
            {
                Console.WriteLine($"{item.Nome,-30}{item.DataInicioVenda.ToShortDateString(),-20}{item.Marca,-20}{item.Categoria,-20}");
            }


        }
    }
}