using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningIf1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint getal;
            Console.WriteLine("Geef een positief groot getal in.");
            getal = uint.Parse(Console.ReadLine());
            if ((getal % 2) == 0) Console.WriteLine("Getal is even.");
            else Console.WriteLine("Getal is oneven.");

        }
    }
}
