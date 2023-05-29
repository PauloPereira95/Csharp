using System.Text.Json;
using System.Text.Json.Serialization;

namespace c_09_cidades
{
    internal class Program
    {
        static List<Cidades> cidades = new List<Cidades>();
        static string fileName = "";
        static void Main(string[] args)
        {
            string resposta = "";
            do
            {
                MostrarDados();
                Console.WriteLine();
                Menu();
                Console.WriteLine("Terminar ?");
                resposta = Console.ReadLine();
                Console.Clear();
            } while (resposta.ToLower() != "s");


        }
        static void LerFicheiro()
        {
            var fileName = AppDomain.CurrentDomain.BaseDirectory + @"\cidades.json";
            string json = "";
            // ler Ficheiro
            using (StreamReader reader = new StreamReader(fileName))
            {
                json = reader.ReadToEnd();
            }
            cidades = JsonSerializer.Deserialize<List<Cidades>>(json);

        }
        static void AdicCidade()
        {
            string nome = "";
            long pop = 0;

            Console.WriteLine("Digite o nome da Cidade :");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o numero de população");
            pop = long.Parse(Console.ReadLine());

            Cidades cidade = new Cidades(nome,pop);

            cidade.Nome = nome;
            cidade.Populacao = pop;
            cidades.Add(cidade);
            EscreverFicheiro(cidades,"cidades.json");
        }
        static void Menu()
        {
            byte opcao = 0;

            Console.WriteLine("Defina a opção a executar:");
            Console.WriteLine("1 - Adicionar Cidade;");
            Console.WriteLine("2 - Calcular Média da População das Cidades;");
            Console.WriteLine("3 - Listar Cidades Ordenadas de forma ascendente pelo nome;");
            Console.WriteLine("4 - Listar Cidades Ordendas de form aascendente pela população;");
            Console.WriteLine("5 - Listar Cidades com população acima de um valor;");
            Console.WriteLine("6 - Remover uma cidade (pesquisar por nome);");
            //byte.TryParse(Console.ReadLine(), out opcao);
            opcao = byte.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    AdicCidade();
                    break;
            }

        }
        static void MostrarDados()
        {
            LerFicheiro();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{"Cidade",-50} {"População",10}\n");
            Console.ResetColor();
            foreach (var item in cidades)
            {
                Console.WriteLine($"{item.Nome,-50}{item.Populacao,10}");
            }
        }
        private static JsonSerializerOptions _options =
new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
        public static void EscreverFicheiro(object obj, string fileName)
        {
            var jsonString = JsonSerializer.Serialize(obj, _options);
            File.WriteAllText(fileName, jsonString);
        }


    }
}