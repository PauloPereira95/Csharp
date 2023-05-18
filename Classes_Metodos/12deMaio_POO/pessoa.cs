using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12deMaio_POO
{
    internal class pessoa
    {
        // fields
        public string nome;
        private DateTime _dataNasc;
        private int _idade;
        
        // propriedade
        public DateTime DataNascimento
        {
            get { return _dataNasc; }
            set { _dataNasc = value; }
        }
        public int Idade
        {
            // apens leitura
            get
            {
                _idade = DateTime.Now.Year - _dataNasc.Year;
                if (_dataNasc > DateTime.Now.AddYears(-_idade))
                    _idade--;
                return _idade;
            }
        }
        //// stter
        //public void DefiniarDataNasc(DateTime d)
        //{
        //    _dataNasc = d;
        //}
        //// Getter
        //public int ObterIdade()
        //{
        //    _idade = DateTime.Now.Year - _dataNasc.Year;
        //    if (_dataNasc > DateTime.Now.AddYears(-_idade))
        //        _idade--;
        //    return _idade;
        //}

    }
}
