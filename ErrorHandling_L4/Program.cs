using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling_L4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // welke code wil je 'proberen' uit te voeren
            /*try
            {
                string[] months = new string[12];
                months[12] = "December";
            }
            // wat moet er gebeuren als het niet lukt om de code
            // in het try blokje uit te voeren
            catch (Exception e) 
            {
                //Console.WriteLine(e);
                Console.WriteLine(e.Message);
            }*/

            try
            {
                string[] months = new string[12];
                //months[12] = "December";
                months[0] = "Januari";
                int number = Convert.ToInt32(months[0]);
            }
            // specifiek fout afhandelen voor index
            // buiten de grenzen van de array
            catch (IndexOutOfRangeException e) 
            {
                Console.WriteLine("Arrays beginnen vanaf nul!");
            }
            // conversie error opvangen
            catch (FormatException e)
            {
                Console.WriteLine("Je probeert een onmogelijke conversie te doen!");
            }
            // andere fouten opvangen
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Er is iets fout gelopen: " +
                    e.Message); 
            }
            // code die altijd uitgevoerd wordt, of de try
            // nu goed of slecht afgelopen is
            finally
            {
                Console.WriteLine("Dit zie je altijd");
            }
        }
    }
}
