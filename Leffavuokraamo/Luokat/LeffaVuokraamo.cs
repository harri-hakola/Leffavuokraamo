using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Leffavuokraamo.Luokat
{
    [Serializable]
    public class LeffaVuokraamo
    {

        public List<VuokraElokuva> vuokraElokuvat = new List<VuokraElokuva>();

        public void Lisaa() //Luetaan elokuvat tekstitiedostosta ja lisätään vuokraElokuvat-listaan
        {
            string vRivi;

            StreamReader vTiedosto = new StreamReader("vuokraelokuvat.txt");
            while ((vRivi = vTiedosto.ReadLine()) != null)
            {
                string[] teksti = vRivi.Split(';');

                int vVuosi = Int32.Parse(teksti[2]);
                vuokraElokuvat.Add(new VuokraElokuva(teksti[0], teksti[1], vVuosi, teksti[3], teksti[4]));

            }
            vTiedosto.Close();
        
        }

        public void VieLista() // Tallennetaan vuokraElokuvat-listan sisältö XML-tiedostoon
        {        
            FileStream fileStream = new FileStream("backup.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<VuokraElokuva>));

            try
            {
                xmlSer.Serialize(fileStream, vuokraElokuvat);
                Console.WriteLine("Tiedosto tallennettu nimellä: backup.txt");
            }
            catch
            {
                Console.WriteLine("Tallennus ei onnistunut");
            }
            finally
            {
                fileStream.Close();
            }
           
        }

        

        public void TulostaElokuvat() // Tulostetaan vuokraElokuvat -listan sisältö konsolille
        {
            foreach (var item in vuokraElokuvat)
            {
                Console.WriteLine(item.Id + item.Nimi + ", " + item.Vuosi + ", " + item.Genre + ", " + item.Raja + ", " + " Vuokrattavissa: " + item.Vuokrattavissa);
            }
        }
    }
}
