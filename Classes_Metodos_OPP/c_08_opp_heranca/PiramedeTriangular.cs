using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_08_opp_heranca
{
    internal class PiramedeTriangular : Triangulo
    {
        private double _altura;
        private double _volume;
        private double _areaBase;

        public double Altura { get => _altura; set => _altura = value; }
        public double Volume { get => (AreaBase * Altura) / 3;}
        public double AreaBase { get => _areaBase; set => _areaBase = value; }
    }
}
