using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_08_opp_heranca
{
    internal class Quadrado
    {
        private double _arestaQuad;
        private double _permitroQuad;
        private double _areaQuad;


        public double ArestaQuad { get => _arestaQuad; set => _arestaQuad = value; }
        public double PermitroQuad { get => ArestaQuad * 4;}
        public double AreaQuad { get => ArestaQuad * 2; }
    }
}
