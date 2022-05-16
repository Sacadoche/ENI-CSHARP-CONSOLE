using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eni.Demo.Module2.Lib
{
    public abstract class Fruit
    {
        public DateTime DatePeremption { get; set; }

        public Fruit(DateTime consomabilite)
        {
            this.DatePeremption = DateTime.Now.AddDays(consomabilite.Day);
        }
    }
}
