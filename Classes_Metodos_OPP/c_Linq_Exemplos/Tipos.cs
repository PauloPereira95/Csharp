using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Linq_Exemplos
{
    internal class Categoria
    {
        public int IdCategoria { get; set; }
        public string Nome { get; set; }
    }
    internal class Marca
    {
        public int IdMarca { get; set; }
        public string Nome { get; set; }
    }
    internal class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public short Stock { get; set; }
        public DateTime DataInicioVenda { get; set; }
        public int IdCategoria { get; set; }
        public int IdMarca { get; set; }

    }
    static class Dados
    {
        internal static List<Categoria> Categorias()
        {
            List<Categoria> categorias = new List<Categoria>()
           {
               new Categoria {IdCategoria = 1, Nome ="Computadores"},
               new Categoria {IdCategoria = 2, Nome = "Componentes"},
               new Categoria {IdCategoria = 3, Nome ="Armazenamento"},
               new Categoria {IdCategoria = 4, Nome = "Perifericos"},
               new Categoria {IdCategoria = 5,Nome="Mobilidade"}
           };
            return categorias;
        }
        internal static List<Marca> Marcas()
        {
            List<Marca> marcas = new List<Marca>()
            {
                new Marca {IdMarca = 1, Nome = "Asus"},
                new Marca { IdMarca = 2, Nome ="CREATIVE"},
                new Marca { IdMarca = 3, Nome ="JBL"},
                new Marca { IdMarca = 4, Nome ="Canon"},
                new Marca { IdMarca = 5, Nome ="Kingston"},
                new Marca { IdMarca = 6, Nome ="Logitech"},
                new Marca { IdMarca = 7, Nome ="Samsung"},
                new Marca { IdMarca = 8, Nome ="Western Digital"},
                new Marca { IdMarca = 9, Nome ="Acer"},
            };
            return marcas;
        }
        internal static List<Produto> Produtos()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\produtos.txt";
            List<Produto> produtos = new List<Produto>();
            int id = 0;
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
                    Marca marca = new Marca();
                    Categoria categoria = new Categoria();


                    produto.Nome = parts[0];
                    produto.Preco = decimal.Parse(parts[1]);
                    #region TaxasIva
                    //switch (parts[2])
                    //{
                    //    case "0": produto.Iva1 = TaxasIva.Isento; break;
                    //    case "6": produto.Iva1 = TaxasIva.Reduzida; break;
                    //    case "13": produto.Iva1 = TaxasIva.Intermedia; break;
                    //    case "23": produto.Iva1 = TaxasIva.Normal; break;
                    //}
                    #endregion
                    produto.Stock = short.Parse(parts[3]);
                    produto.DataInicioVenda = DateTime.Parse(parts[4]);
                    switch (parts[5])
                    {
                        case "Asus":
                            produto.IdMarca = 1;
                            break;
                        case "CREATIVE":
                            produto.IdMarca = 2;
                            break;
                        case "JBL":
                            produto.IdMarca = 3;
                            break;
                        case "Canon":
                            produto.IdMarca = 4;
                            break;
                        case "Kingston":
                            produto.IdMarca = 5;
                            break;
                        case "Logitech":
                            produto.IdMarca = 6;
                            break;
                        case "Samsung":
                            produto.IdMarca = 7;
                            break;
                        case "Western Digital":
                            produto.IdMarca = 8;
                            break;
                        case "Acer":
                            produto.IdMarca = 9;
                            break;
                    }
                    switch (parts[6])
                    {
                        case "Computadores":
                            produto.IdCategoria = 1;
                            break;
                        case "Componentes":
                            produto.IdCategoria = 2;
                            break;
                        case "Armazenamento":
                            produto.IdCategoria = 3;
                            break;
                        case "Mobilidade":
                            produto.IdCategoria = 4;
                            break;
                        case "Periféricos":
                            produto.IdCategoria = 5;
                            break;
                    }
                    produto.IdProduto = id++;
                    produtos.Add(produto);

                }
            }
            return produtos;
        }





    }
}
