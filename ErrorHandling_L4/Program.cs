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
            try
            {
                string[] months = new string[12];
                months[12] = "December";
            }
            // wat moet er gebeuren als het niet lukt om de code
            // in het try blokje uit te voeren
            catch
            {
                Console.WriteLine("Whoops");
            }

            
        }
    }
}
