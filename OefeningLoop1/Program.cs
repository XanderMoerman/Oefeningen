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
            byte aantalGetallen = byte.Parse(Console.ReadLine());
            short som;
            for (short tellerWaarde = 0,getal = 0; tellerWaarde < aantalGetallen; tellerWaarde++)
            {
                getal = int.Parse(Console.ReadLine());
                som += getal;
            }
        }
    }
}
