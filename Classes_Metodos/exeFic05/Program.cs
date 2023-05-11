using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;

namespace exeFic05
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // exe2();
           exe3();
        }
        static void exe2()
        {
            // Definição
            List<int> numeros = new List<int>();

            // Preechimento da Lista
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                numeros.Add(random.Next(-10, 11));
            }
            // Mostrar Valores 
            Console.WriteLine("\n------ Lista de Numeros ---------------");

            foreach (int i in numeros)
            {
                Console.Write($"{i,-10}");
            }

            Console.WriteLine("\n------ 2.1 Soma / Media ---------------");

            // 2.1. Indicar a soma e a média dos valores da lista
            int soma = numeros.Sum(); // calcula a soma
            double media = numeros.Average(); // calcula a media
            Console.WriteLine($"Soma -> {soma}");
            Console.WriteLine($"Media -> {media}");

            // 2.2 Indicar os valores máximo e mínimo existentes na lista;
            Console.WriteLine("\n------ 2.1 Minimo ---------------");
            int valMax = numeros.Max(); // Calcula o Maximo
            int valMin = numeros.Min(); // Calcula o Minimo
            Console.WriteLine($"Valor Maximo -> {valMax}");
            Console.WriteLine($"Valor Minimo -> {valMin}");

            Console.WriteLine("\n------ 2.3 Ordenados de Forma Decrescente ---------------");
            // 2.3. Apresentar os valores da lista ordenados de forma decrescente;
            numeros.Sort(); // Ordena de Forma Crescente
            numeros.Reverse(); // Ordena de Forma Decrescente
            foreach (var item in numeros)
            {
                Console.Write($"{item,-10}");
            }
            // 2.4.Indicar o total de valores negativos, iguais a zero e negativos;
            Console.WriteLine("\n------ 2.4 Total Negativos , = 0 e Positivos ---------------");
            int totalNeg = numeros.Where(x => x < 0).Count();
            int totalZero = numeros.Where(x => x == 0).Count();
            int totalPos = numeros.Where(x => x > 0).Count();

            Console.WriteLine($"Positivos -> {totalPos}");
            Console.WriteLine($"Zero -> {totalZero}");
            Console.WriteLine($"Negativos -> {totalNeg}");
            //2.5.Indicar a média dos valores positivos;
            Console.WriteLine("\n------ 2.5 Media Positivos ---------------");
            double mediaNumPositivos = Math.Round(numeros.Where(x => x > 0).Average(), 2);
            Console.WriteLine($"Media dos Numeros Positivos -> {mediaNumPositivos}");
            // 2.6. Criar uma nova lista com os valores ímpares existentes na lista;
            Console.WriteLine("\n------ 2.6 Lista Impares ---------------");
            var total_pares = numeros.Where(n => n % 2 != 0).ToList();
            foreach (var item in total_pares)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            // 2.7. Solicitar um valor ao utilizador e verificar se o valor se encontra na lista;
            Console.WriteLine("\n------ 2.7 Vereificar Valor ---------------");
            string numuserString = "";
            int numUser = 0;
            Console.WriteLine("Digite o numero que deseja verificar :");
            numuserString = Console.ReadLine();
            int.TryParse(numuserString, out numUser);
            int resultado = numeros.Where(c => c == numUser).Count();
            if (resultado > 0)
                Console.WriteLine($"O valor esta na lisa {resultado}x !");
            else
                Console.WriteLine("O valor não esta na lista !");
            // 2.8. Solicitar um valor ao utilizador e remover todas as ocorrências do valor na lista; depois de remover, mostrar valores da lista;
            Console.WriteLine("\n------ 2.8 Eliminar Valor ---------------");
            Console.WriteLine("Digite o numero que pretende Eliminar :");
            numuserString = Console.ReadLine();
            int.TryParse(numuserString, out numUser);
            numeros.RemoveAll(x => x == numUser);
            foreach (var item in numeros)
            {
                Console.Write($"{item,-10}");
            }
        }
        static void exe3()
        {
            // Para mostrar o simbolo do euro
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Definição da Lista
            List<ClasseProduto> produtos = new List<ClasseProduto>();
            produtos.Add(new ClasseProduto()
            {
                nome = "TravelMate P215-53",
                categoria = "Computador",
                preco = 764.90m,
                stock = 3,
                dataInicioVenda = new DateTime(2021, 10, 20)

            });
            produtos.Add(new ClasseProduto()
            {
                nome = "ASUS 15.6\" F515EP-51DM3SB1",
                categoria = "Computador",
                preco = 749.90m,
                stock = 2,
                dataInicioVenda = new DateTime(2022,1,23)
            });
            produtos.Add(new ClasseProduto()
            {
                nome = "SSD WESTERN DIGITAL 480GB SATA III",
                categoria = "Armezenamento",
                preco = 57.90m,
                stock = 6,
                dataInicioVenda = new DateTime(2019, 8, 5)
            });
            produtos.Add(new ClasseProduto()
            {
                nome = "SSD SAMSUNG 2TB SATA III Serie 870 QVO",
                categoria = "Armezenamento",
                preco = 205.90m,
                stock = 2,
                dataInicioVenda = new DateTime(2021,2,16)
            });
            produtos.Add(new ClasseProduto()
            {
                nome = "Teclado LOGITECH G413 Carbon",
                categoria = "Acessórios",
                preco = 78.35m,
                stock = 7,
                dataInicioVenda = new DateTime(2021, 4, 2)
            });
            produtos.Add(new ClasseProduto()
            {
                nome = "Teclado LOGITECH G413 Carbon",
                categoria = "Acessórios",
                preco = 28.85m,
                stock = 1,
                dataInicioVenda = new DateTime(2020,6,29)
            });
            produtos.Add(new ClasseProduto()
            {
                nome = "CANON LBP633Cdw",
                categoria = "Impressora",
                preco = 239.90m,
                stock = 4,
                dataInicioVenda = new DateTime(2021,11,8)
            });
            produtos.Add(new ClasseProduto()
            {
                nome = "HP LaserJet M110we",
                categoria = "Impressora",
                preco = 109.90m,
                stock = 5,
                dataInicioVenda = new DateTime(2020,9,23)
            });
            produtos.Add(new ClasseProduto()
            {
                nome = "SAMSUNG Galaxy TAB A8 X200 10.5\"",
                categoria = "Mobilidade",
                preco = 255.90m,
                stock = 3,
                dataInicioVenda = new DateTime(2021,3,24)
            });
            produtos.Add(new ClasseProduto()
            {
                nome = "SAMSUNG Galaxy TAB A7 LITE 8.7\"",
                categoria = "Mobilidade",
                preco = 145.90m,
                stock = 7,
                dataInicioVenda = new DateTime(2021,1,22)
            });
            produtos.Add(new ClasseProduto()
            {
                nome= "Auriculares JBL T290",
                categoria = "Som",
                preco = 22.90m,
                stock = 6,
                dataInicioVenda = new DateTime(2019,3,20)
            });
            produtos.Add(new ClasseProduto()
            {
                nome = "Auriculares JBL Tune 130C True Wireless",
                categoria = "Som",
                preco = 24.90m,
                stock = 8,
                dataInicioVenda = new DateTime(2021, 8, 30)
            });
            produtos.Add(new ClasseProduto()
            {
                nome = "Auriculares CREATIVE Bluetooth Outlier Active V2",
                categoria = "Som",
                preco = 24.90m,
                stock = 8,
                dataInicioVenda = new DateTime(2021,8,30)
            });
            // Mostrar Valores da Lista
            Console.WriteLine($"{"Produto", -50}{"Categoria", -25}"
                + $"{"Preço",15}{"Stock",10}{"Data de Inicio de Venda",30}\n");
           
            foreach (var item in produtos)
            {
                Console.WriteLine ($"{item.nome, -50}{item.categoria,-25}" +
                    $"{item.preco,15:C}{item.stock,10}{item.dataInicioVenda.ToShortDateString(),30}");
            }
            // 4.1. Indicar o preço médio dos produtos;
            Console.WriteLine();
            Console.WriteLine("---- 4.1 Preço Medio do Produtos -------------------");
            Console.WriteLine($"Preço Medio -> {Math.Round(produtos.Average(p => p.preco),2)}");
            // 4.2 Indicar os preços mais elevado e mais baixo;
            Console.WriteLine();
            Console.WriteLine("---- 4.2 Preço Mais Elevado e Mais Baixo -----------");
            Console.WriteLine($"Preço Mais Elevado -> {produtos.Max(p => p.preco):C}");
            Console.WriteLine($"Preço Mais Baixo -> {produtos.Min(p => p.preco):C}");
            // 4.3. Indicar o total de produtos em Stock (soma do atributo stock);
            Console.WriteLine();
            Console.WriteLine("---- 4.3 Total de Strock ----------------------------");
            Console.WriteLine($"Total de Stock -> {produtos.Sum(p => p.stock)}");
            // 4.4. Listar os produtos ordenados de forma ascendente pelo atributo preço;
            Console.WriteLine();
            Console.WriteLine("---- 4.4 Ordenação Desc Preço ----------------------------");
            foreach (var i in produtos.OrderByDescending(p => p.preco))
            {
                Console.WriteLine($"{i.nome,-50}\t{i.preco,20:C}\t");
            }
            // 4.5. Listar os produtos em função da data de início de venda, do mais recente para o mais antigo (ordenação descendente pelo atributo data de início de venda);
            Console.WriteLine();
            Console.WriteLine("---- 4.6 Ordenar Por Data Inicio De Venda ----------------");
            foreach (var item in produtos.OrderByDescending(p => p.dataInicioVenda))
            {
                Console.WriteLine($"{item.nome, -50}\t {item.dataInicioVenda.ToShortDateString()}\t");
            }
            //4.6. Indicar o preço médio dos produtos da categoria Som;
            Console.WriteLine();
            Console.WriteLine("----- 4.6 Preço Medio dos Produtos de Som ----------------");
            decimal precoMedioProdSom = produtos.Where(x => x.categoria == "Som").Average(p => p.preco);
            Console.WriteLine(Math.Round(precoMedioProdSom, 2));
            // 4.7. Listar todos os produtos cujo nome inclua a palavra SAMSUNG;
            Console.WriteLine();
            Console.WriteLine("---- 4.7 Produtos Samsung --------------------------------");
            var prodSamsung = produtos.Where(c => c.nome.Contains("SAMSUNG")).ToList();
            foreach (var i in prodSamsung)
            {
                Console.WriteLine(i.nome, -10);
            }
            // 4.8. Listar todos os produtos cuja venda se iniciou antes de 2021;
            Console.WriteLine();
            Console.WriteLine("-- 4.8 Produtos Vendidos antes de 2021");
            var prodVendasAntigas = produtos.Where(x => x.dataInicioVenda.Year < 2021);
            foreach (var i in prodVendasAntigas)
            {
                Console.WriteLine(i.nome);
            }
        }
    }
}