using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningLoopExtra1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal op tussen 1 en 10");
            byte getal = byte.Parse(Console.ReadLine());
            int teller = 0;
            Console.WriteLine("Vermenigvuldigingen: ");
            while(teller != 11)
            {
                Console.WriteLine(getal * teller);
                teller++;
            }
        }
    }
}
