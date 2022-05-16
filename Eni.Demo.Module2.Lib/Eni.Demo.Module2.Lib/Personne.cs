using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eni.Demo.Module2.Lib
{
    public class Personne
    {
        private int age;

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Prenom { get; set; }

        public Personne(int age)
        {
            this.age = age;
        }
    }
}
