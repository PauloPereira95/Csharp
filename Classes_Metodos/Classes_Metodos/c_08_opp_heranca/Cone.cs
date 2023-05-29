using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_08_opp_heranca
{
    internal class Cone : Cilindro
    {
        public override double Volume => Volume / 3;
       
    }
}
