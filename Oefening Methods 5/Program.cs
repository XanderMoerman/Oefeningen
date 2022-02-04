using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Methods_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float gem = 0;
            bool keuze = Keuze(ref gem);
            if(keuze == true) Console.WriteLine("Het gemmiddelde is: {0}", gem);
            if (keuze == false) Console.WriteLine("Programma stoppen.");
           
        }

        static bool Keuze(ref float gem)
        {
            Console.WriteLine("Gemiddelde = y\nStop = n");
            char keuze = char.Parse(Console.ReadLine());
            if (keuze == 'y' || keuze == 'Y')
            {
                float oplossing = Gemiddelde(ref gem);
                return true;
            }
            if (keuze == 'n' || keuze == 'N') return false;
            else return false;
        }

        static float Gemiddelde(ref float gem)
        {
            Console.WriteLine("Geef het 1ste getal op.");
            short get1 = short.Parse(Console.ReadLine());
            Console.WriteLine("Geef het 2de getal op.");
            short get2 = short.Parse(Console.ReadLine());
            return ((get1 + get2) / 2);
        }
    }
}
