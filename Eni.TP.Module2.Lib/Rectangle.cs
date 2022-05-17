using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eni.TP.Module2.Lib
{
    public class Rectangle : Forme
    {
        public double Longueur;
        public double Largeur;
        private double CalculeAir()
        {
            return Longueur * Largeur;
        }
        private double CalculePerimetre()
        {
            return Longueur * 2 + Largeur * 2;
        }

        public override string ToString()
        {
            return $"Triangle de longueur={Longueur} at largeur={Largeur}\nAire = {CalculeAir()}\nPérimètre = {CalculePerimetre()}\n";
        }
    }
}
