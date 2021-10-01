using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningIf4
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte getal;
            Console.WriteLine("Geef een getal in tussen -10 en 40.");
            getal = sbyte.Parse(Console.ReadLine());
            if (getal > 30 || getal < 0) Console.WriteLine("getal is extreem");
            else Console.WriteLine("getal is normaal");
        }
    }
}
