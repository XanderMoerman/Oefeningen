using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClasses
{
    static class Berekenen
    {
        static int getal1=0, getal2=0;
        public static int som(int get1, int get2)
        {
            getal1 = get1; getal2 = get2;
            return (get1 + get2);
        }
        public static void afdruk()
        {
            Console.WriteLine("Getal1 = {0}\nGetal2 = {1}", getal1, getal2);
        }
    }
}
