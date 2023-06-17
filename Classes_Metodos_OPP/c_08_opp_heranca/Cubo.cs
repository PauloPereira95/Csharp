using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_08_opp_heranca
{
    internal class Cubo : Quadrado
    {
        private double _volume;
		public virtual double Volume
		{
			get
			{
				return ArestaQuad * 3;
			}
			set
			{
				Volume = value;
			}
		}

	}
}
