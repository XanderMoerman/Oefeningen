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
            uint getal;
            Console.WriteLine("Geef het getal in.");
            getal = uint.Parse(Console.ReadLine());
            Console.WriteLine("Minuten is: {0:D}", getal / 60);
            Console.WriteLine("Uren is: {0:D}", getal / 3600);
        }
    }
}
