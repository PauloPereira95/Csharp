using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Produto
    {
        // fields
        private string _nome;
        private decimal _preco;
        private short stock;
        private DateTime _dataInicioVenda;
        private string _marca;
        private string _categoria;
        private decimal _precoFinal;
        internal TaxasIva Iva;

        // propriedades
        public string Nome { get => _nome; set => _nome = value; }
        public decimal Preco { get => _preco; set => _preco = value; }
        public DateTime DataInicioVenda { get => _dataInicioVenda; set => _dataInicioVenda = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
        public decimal PrecoFinal { 
            get
            {

                return _preco * (1 + (decimal)Iva / 100);
            }
        }
        public short Stock { get => stock; set => stock = value; }

        // Construtores
        //public Produto (string nome, decimal preco, DateTime DataInicVenda,string marca, string categoria,
        //    decimal pre)
        //{

        //}
    }
    enum TaxasIva
    {
        Isento = 0,
        Reduzida = 6,
        Intermedia = 13,
        Normal = 23
    }
}
