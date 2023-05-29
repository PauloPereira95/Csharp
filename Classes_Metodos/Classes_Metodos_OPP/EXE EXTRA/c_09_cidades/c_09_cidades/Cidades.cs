using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace c_09_cidades
{
    internal class Cidades
    {
        // Propriedades 
        public string Nome { get; set; }
        public long Populacao { get; set; }
        // Construtor
        public Cidades(string nome, long populacao)
        {
            Nome = nome;
            Populacao = populacao;
        }
    }
}
