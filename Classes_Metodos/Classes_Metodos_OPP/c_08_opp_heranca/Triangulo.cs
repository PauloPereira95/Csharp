using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_08_opp_heranca
{
    internal class Triangulo
    {
        private double _lado_1;
        private double _lado_2;
        private double _lado_3;
        private double _area;
        private double _perimetro;

        public double Lado_1 { get => _lado_1; set => _lado_1 = value; }
        public double Lado_2 { get => _lado_2; set => _lado_2 = value; }
        public double Lado_3 { get => _lado_3; set => _lado_3 = value; }
        public double Area { get => Math.Sqrt(Perimetro * (Perimetro - Lado_1) * (Perimetro - Lado_2) * (Perimetro - Lado_3));}
        public double Perimetro { get => (Lado_1 + Lado_2 + Lado_3) / 2;}
    }
}
