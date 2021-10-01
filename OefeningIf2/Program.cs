using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningIf2
{
    class Program
    {
        static void Main(string[] args)
        {
            short get1, get2, get3;
            Console.WriteLine("Geef 3 gehele getallen in.");
            get1 = short.Parse(Console.ReadLine());
            get2 = short.Parse(Console.ReadLine());
            get3 = short.Parse(Console.ReadLine());
            if (get1 < get2)
            {
                if (get1 < get3) Console.WriteLine("Getal 1 is het kleinst.");
                else Console.WriteLine("Getal 3 is het kleinst.");
            }
            else if (get2 < get3) Console.WriteLine("Getal 2 is het kleinst.");
            else Console.WriteLine("Getal 3 is het kleinst.");
        }
    }
}
