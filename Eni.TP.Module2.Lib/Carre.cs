using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eni.TP.Module2.Lib
{
    public class Carre : Forme
    {
        public int Longueur;

        private double CalculeAir()
        {
            return Longueur * Longueur;
        }
        private double CalculePerimetre()
        {
            return Longueur * 4;
        }

        public override string ToString()
        {
            return $"Carré de coté {Longueur}\nAire = {CalculeAir()}\nPérimètre = {CalculePerimetre()}\n";
        }
    }
}
