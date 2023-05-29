using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace libraryFuncoes
{
    public static class Validacoes
    {
        public static bool ValidarNome(string Nome)
        {
            Regex validar = new Regex(@"^[a-zA-ZãáàéêíóõúçÃÁÀÉÊÍÓÕÚÇ\s]+$");
            return validar.IsMatch(Nome);
        }
        public static bool ValidarCodigoPostal(string CP)
        {
            Regex validar = new Regex(@"^[1-9]\d{3}(-\d{3})?$");
            return validar.IsMatch(CP);
        }
        public static bool ValidarTelefone(string Telefone)
        {
            Regex validar = new Regex(@"^[2|3]\d{8}");
            return validar.IsMatch(Telefone);
        }
        public static bool ValidarTelemovel(string telemovel)
        {
            Regex validar = new Regex(@"^[9][1|2|3|4|6]\d{7}");
            return (validar.IsMatch(telemovel) && telemovel.Length == 9);
        }
        public static bool ValidarEmail(string Email)
        {
            Regex validar = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return validar.IsMatch(Email);
        }
    }
}
