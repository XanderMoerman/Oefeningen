using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningLoop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef het aantal getallen in.");
            byte aantal = byte.Parse(Console.ReadLine());
            float getal2 = 0; //op een na grootste getal
            float getal3 = 0; // grootste getal
            for(byte teller = 1; teller<=aantal; teller++)
            {
                float getal = float.Parse(Console.ReadLine()); // ingelezen getal
                if (getal > getal2) getal2 = getal;
                else if (getal > getal3) getal3 = getal;
                if (getal2 > getal3) getal3 = getal2;
                
                
            }
            Console.WriteLine("Het op een na grootste getal is {0}", getal2);
        }
    }
}
