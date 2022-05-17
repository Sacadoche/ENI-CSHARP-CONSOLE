using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eni.TP.Module2.Lib
{
    public class Cercle : Forme
    {
        public int Rayon;

        private double CalculeAir()
        {
            return Math.PI * Rayon * Rayon;
        }

        private double CalculePerimetre()
        {
            
            return Math.PI * 2 * Rayon;
        }

        public override string ToString()
        {
            return $"Cercle de rayon {Rayon}\nAire = {CalculeAir()}\nPérimètre = {CalculePerimetre()}\n";
        }
    }
}
