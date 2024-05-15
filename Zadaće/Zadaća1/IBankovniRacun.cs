using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća1
{
    public interface IBankovniRacun
    {
        void PokaziStanje();
        void Uplati(decimal iznos);
        void Isplati(decimal iznos);
    }
}
