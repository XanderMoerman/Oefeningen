using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon pers1 = new Persoon("Ik", "Jij");
            Console.WriteLine(pers1.VolledigeNaam());
            Persoon pers2 = new Persoon();
            Console.WriteLine(pers2.VolledigeNaam());
        }
    }
}
