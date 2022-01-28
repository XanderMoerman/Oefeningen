using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Methods_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal in.");
            int getal = int.Parse(Console.ReadLine());
            bool antwoord = Berekening(getal);
            Console.WriteLine(antwoord);
        }

        static bool Berekening(int getal)
        {
            if (Math.Sqrt(getal) * Math.Sqrt(getal) == getal) return true;
            else return false;
        }
    }
}
