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
            Keuze(ref gem);
            Console.WriteLine("Gem = {0}", gem);
        }

        static void Keuze(ref int gem)
        {
            Console.WriteLine("Keuze = y\nStop = n");
            char keuze = char.Parse(Console.ReadLine());
            if (keuze == 'y' || keuze == 'Y') Gemiddelde(ref gem);
            if (keuze == 'n' || keuze == 'N') return;
        }

        static void Gemiddelde(ref int gem)
        {
            Console.WriteLine("Geef de 2 getallen op.");
            short get1 = short.Parse(Console.ReadLine());
            short get2 = short.Parse(Console.ReadLine());
            gem = (get1 + get2) / 2;

        }
    }
}
