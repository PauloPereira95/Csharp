using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_08_opp_heranca
{
    internal class PiramideQuadrangular : Cubo
    {
        private double _alturaPiramide;

        public double AlturaPiramide
        {
            get
            {
                return _alturaPiramide;
            }
            set
            {
                AlturaPiramide = value;
            }
        }
        public override double Volume
        {
            get { return Volume; }
            set { base.Volume = value; }
        }

    }
}
