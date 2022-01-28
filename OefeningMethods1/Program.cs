using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningMethods1
{
    class Program
    {
        static void Main(string[] args)
        {
            Optellen();
            
        }
        static void Optellen()
        {
            Console.WriteLine("Geef 2 getallen in.");
            int get1 = int.Parse(Console.ReadLine());
            int get2 = int.Parse(Console.ReadLine());
            int som = get1 + get2;
            Console.WriteLine("De som is: {0}", som);
            Console.ReadLine();
            return;
        }
    }
}
