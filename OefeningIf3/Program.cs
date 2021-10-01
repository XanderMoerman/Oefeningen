using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningIf3
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte getal;
            Console.WriteLine("Geef een klein getal op.");
            getal = sbyte.Parse(Console.ReadLine());
            if (getal < 0) Console.WriteLine("Getal is negatief.");
            else if (getal > 0) Console.WriteLine("Getal is positief.");
            else Console.WriteLine("Getal is 0");
        }
    }
}
