using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eni.TP.Module2.Lib
{
    public class Triangle : Forme
    {
        public int A;
        public int B;
        public int C;

        private double CalculeAir()
        {
            double s = (A + B + C) / 2d;
            double air = Math.Sqrt(s * ((s - A) * (s - B) * (s - C)));
            return air;
            
        }
        private double CalculePerimetre()
        {
            return A + B + C;
        }

        public override string ToString()
        {
            return $"Triangle de coté A= {A}, B={B}, C={C}\nAire = {CalculeAir()}\nPérimètre = {CalculePerimetre()}\n";
        }
    }
}
