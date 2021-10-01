using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningIf5
{
    class Program
    {
        static void Main(string[] args)
        {
            short get1, get2;
            Console.WriteLine("Geet 2 getallen in.");
            get1 = short.Parse(Console.ReadLine());
            get2 = short.Parse(Console.ReadLine());
            Console.WriteLine((get1 > get2) ? "Getal 1 is groter." : "Getal 2 is groter.");
            
        }
    }
}
