using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_08_opp_heranca
{
    public abstract class Circulo
    {
        protected double _raio;
        public double Perimetro { 
            get {
                return 2 * _raio * Math.PI;
            } 
        }
        public double Area { 
            get
            {
                return Math.Pow(_raio,2) * Math.PI;
            }
            
        }
        public double Diametro { set => _raio = value / 2; }
    }
    
}
