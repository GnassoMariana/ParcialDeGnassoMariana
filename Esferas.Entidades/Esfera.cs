using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esferas.Entidades
{
    public class Esfera
    {
        public int  Radio { get; set; }

        public ColorEsfera Color  { get; set; }

        public Trazo Trazo { get; set; }

        public Esfera()
        {

        }

        public double GetArea()
        {
            return 4 * Math.PI * Math.Pow(Radio, 2);
        }

        public double GetVolumen()
        {
            return 4 / 3 * Math.PI * Math.Pow(Radio, 3);
        }

    }
}
