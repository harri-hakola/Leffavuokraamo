using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Leffavuokraamo.Luokat
{
    [Serializable]
    public class VuokraElokuva : Elokuva
    {
        
        public VuokraElokuva()
        {
        }

        public VuokraElokuva(string vId, string vNimi, int vVuosi, string vGenre, string vIkaraja)
        {
            Id = vId;
            Nimi = vNimi;
            Vuosi = vVuosi;
            Genre = vGenre;
            Raja = vIkaraja;
        }

        
        private DateTime pvm = DateTime.Now; // Lainauspäivä

        private DateTime palautusPvm = DateTime.Now.AddDays(3); // Palautuspäivä

        public override void Vuokraa(int vuokraId)
        {

            if (Vuokrattavissa == true)
            {
                Console.WriteLine("{0} vuokrattu {1}\nPalautus viimeistään {2}", nimi, pvm, palautusPvm);
                Vuokrattavissa = false;
                
            }
            else
                Console.WriteLine("Elokuvaa ei pysty vuokraamaan");

        }

        public override void Palauta(int palautusId)
        {
            if (Vuokrattavissa == false)
            {
                Console.WriteLine("{0} palautettu {1}", nimi, pvm);
                Vuokrattavissa = true;
            }
            else
                Console.WriteLine("Elokuvaa ei pysty palauttamaan");

        }

        


    }
}
