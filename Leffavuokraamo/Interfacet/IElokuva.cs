using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leffavuokraamo.Interfacet
{
    public interface IElokuva
    {
        void Vuokraa(int id);

        void Palauta(int id);

      


    }
}
