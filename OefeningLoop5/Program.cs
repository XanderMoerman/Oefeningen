using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningLoop5
{
    class Program
    {
        static void Main(string[] args)
        {
            float term, som = 0;
            float aantal, teller;
            Console.WriteLine("Berekening van 1/1 + 1/2 + ... + 1/n");
            Console.WriteLine("Geef het aantal of n: ");
            aantal = Convert.ToInt32(Console.ReadLine());
            for(teller = 1; teller != aantal; ++teller)
            {
                term = 1 / teller;
                som += term;
            }
            Console.WriteLine("de som is: {0}", som);
        }
    }
}
