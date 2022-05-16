using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eni.Demo.Module2.Console
{
    using Eni.Demo.Module2.Lib;
    class Program
    {
        static void Main(string[] args)
        {
            var personne = new Personne(0);
            for (int i = 0;i<50; i++)
            {
                System.Console.WriteLine(personne.Age++);
            }

            System.Console.Read();
        }
    }

}

