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
            bool keuze = Keuze();
            if (keuze == true)
            {
                float gem = Gemiddelde();
                Console.WriteLine("Gemiddelde is: {0}", gem);
            }
            else Console.WriteLine("Gemiddelde is 0");
        }

        static bool Keuze()
        {
            Console.WriteLine("Wil je het gemiddelde bereken van 2 getallen? [y/n]");
            char antwoord = char.Parse(Console.ReadLine());
            if (antwoord == 'y' || antwoord == 'Y') return true;
            else return false;
        }

        static float Gemiddelde()
        {
            Console.WriteLine("Geef 2 getallen op.");
            int get1 = int.Parse(Console.ReadLine());
            int get2 = int.Parse(Console.ReadLine());
            return (get1 + get2) / 2;
        }
    }
}
