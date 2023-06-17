using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_08_opp_heranca
{
    internal class Cilindro : Circulo
    {
        private double _alturaCilindro;

        public double AlturaCilindro { get => _alturaCilindro; set => _alturaCilindro = value; }

        public virtual double Volume
        {
            get { return base.Area * AlturaCilindro; }
        }

    }
}
