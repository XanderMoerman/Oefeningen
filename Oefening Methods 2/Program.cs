using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Methods_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int verschil = berekening();
            Console.WriteLine("Het verschil is: {0}", verschil);
            Console.ReadLine();
        }
        static int berekening()
        {
            Console.WriteLine("Geef 2 getallen in.");
            int get1 = int.Parse(Console.ReadLine());
            int get2 = int.Parse(Console.ReadLine());
            return get1 - get2;
        }
    }
}
