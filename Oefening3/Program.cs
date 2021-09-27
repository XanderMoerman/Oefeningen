using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong getal;
            Console.WriteLine("Geef het getal in.");
            getal = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Uren is: {0}", getal / 3600);
            Console.WriteLine("Minuten is: {0}", (getal % 3600) / 60);
            Console.WriteLine("Seconden is: {0}", (getal % 3600) % 60);

        }
    }
}
