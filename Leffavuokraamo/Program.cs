using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leffavuokraamo.Luokat;
using Leffavuokraamo.Interfacet;

namespace Leffavuokraamo
{
    class Program
    {
        static void TulostaValikko()
        {
            Console.WriteLine("\nValitse seuraavista:\n\n");
            Console.WriteLine("[k] Näytä kaikki elokuvat:\n");
            Console.WriteLine("[v] Vuokraa elokuva:\n");
            Console.WriteLine("[p] Palauta elokuva:\n");
            Console.WriteLine("[m] Päävalikko:\n");
            Console.WriteLine("[t] Tallenna elokuvat tiedostoon:\n");
            Console.WriteLine("[q] Lopetus:\n");
        }
        static void Main(string[] args)
        {
            LeffaVuokraamo leffaVuokraamo = new LeffaVuokraamo();

            leffaVuokraamo.Lisaa();  //Vuokraelokuvien lisäys
            
            Console.WriteLine("\nJatka painamalla mitä tahansa näppäintä");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("***LEFFAVUOKRAAMO***");

            TulostaValikko();
            bool jatka = true;

            while (jatka)
            {               
                Console.Write("\nAnna komento: ");
                string komento = Console.ReadLine();

                switch (komento)
                {
                    case "k": 
                        leffaVuokraamo.TulostaElokuvat();
                        break;

                    case "v": //Vuokraa Elokuva
                        leffaVuokraamo.TulostaElokuvat();

                        Console.Write("\nAnna vuokrattavan elokuvan numero: ");
                        int vuokraId = int.Parse(Console.ReadLine());
                        vuokraId = vuokraId - 1;

                        if (vuokraId < leffaVuokraamo.vuokraElokuvat.Count)
                        {
                            leffaVuokraamo.vuokraElokuvat[vuokraId].Vuokraa(vuokraId);
                        }
                        else
                        {
                            Console.WriteLine("Tarkista ID");
                        }
                                            
                        break;

                    case "p": //Palauta elokuva
                        leffaVuokraamo.TulostaElokuvat();

                        Console.Write("\nAnna palautettavan elokuvan numero: ");
                        int palautusId = int.Parse(Console.ReadLine());
                        palautusId = palautusId - 1;

                        if (palautusId < leffaVuokraamo.vuokraElokuvat.Count)
                        {
                            leffaVuokraamo.vuokraElokuvat[palautusId].Palauta(palautusId);
                        }
                        else
                        {
                            Console.WriteLine("Tarkista ID");
                        }
                       break;

                    case "m": //Päävalikko
                        Console.Clear();
                        TulostaValikko();
                        break;

                    case "q": //Sulje ohjelma
                        jatka = false;
                        break;

                    case "t": // Tallennetaan elokuvat XML tiedostoon
                        leffaVuokraamo.VieLista();
                        break;
                    

                }
            }

         

        }
    }
}
