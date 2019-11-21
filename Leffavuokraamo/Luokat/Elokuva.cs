using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leffavuokraamo.Luokat
{
    [Serializable]
    public class Elokuva : Interfacet.IElokuva
    {
        protected string id;
        protected string nimi;
        protected int vuosi;
        protected string genre;
        private string ikaraja;     
        protected bool vuokrattavissa = true;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nimi
        {
            get { return nimi; }
            set { nimi = value; }
        }

        public int Vuosi
        {
            get { return vuosi; }
            set { vuosi = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }


        public string Raja
        {
            get { return ikaraja; }
            set
            {
                if (value == "S" || value == "K-7" || value == "K-12" || value == "K-16" || value == "K-18")
                {
                    ikaraja = value;
                }
                else
                {
                    ikaraja = "Ei määritelty";
                }
            }
        }

        public bool Vuokrattavissa
        {
            get { return vuokrattavissa; }
            set { vuokrattavissa = value; }
        }

        public Elokuva()
        {
            Console.WriteLine("Elokuva lisätty");
        }

        public virtual void Vuokraa(int id)
        {
            Console.WriteLine("Määrittelemätön vuokraus");
        }

        public virtual void Palauta(int id)
        {
            Console.WriteLine("Määrittelemätön palautus");
        }

    }
}
