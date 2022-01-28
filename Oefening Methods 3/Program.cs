using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Methods_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef 2 getalln in.");
            int get1 = int.Parse(Console.ReadLine());
            int get2 = int.Parse(Console.ReadLine());
            int getal = Berekening(get1, get2);
            Console.WriteLine("Verschil is: {0}", getal);
        }
        static int Berekening(int get1, int get2)
        {
            return get1 - get2;
        }
    }
}
