using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća1
{
    public abstract class Transakcija : ITransakcija
    {
        public decimal Iznos { get; set; }
        public abstract void IzvrsiTransakciju();
    }
}
