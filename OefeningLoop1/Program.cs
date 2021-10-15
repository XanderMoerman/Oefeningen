using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningLoop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef het aantal getallen in.");
            byte aantal = byte.Parse(Console.ReadLine());
            short som = 0;
            Console.WriteLine("Geef {0} getallen in.", aantal);
            for(byte getal = 0, teller = 1; teller <= aantal; teller++)
            {
                getal = byte.Parse(Console.ReadLine());
                som += getal;
                
            }
            Console.WriteLine("Som is: {0}", som);
        }
    }
}
