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
            int gem = 0;
            char keuze = Keuze();
            if (keuze == 'y' || keuze == 'Y')
            {
                Gemiddelde(ref gem);
                Console.WriteLine("gem = {0}", gem);
            }
            if (keuze == 'n' || keuze == 'N') Console.WriteLine("Programma Stoppen.");
           
        }

        static char Keuze()
        {
            Console.WriteLine("Keuze = y\nStop = n");
            char keuze = char.Parse(Console.ReadLine());
            return keuze;
        }

        static void Gemiddelde(ref int gem)
        {
            Console.WriteLine("Geef de 2 getallen op.");
            short get1 = short.Parse(Console.ReadLine());
            short get2 = short.Parse(Console.ReadLine());
            gem = (get1 + get2) / 2;
            return;
        }
    }
}
