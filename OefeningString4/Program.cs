using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningString4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef uw rekeningnummer in.");
            Console.Write("BE");
            string RekNr = Console.ReadLine();

            RekNr = RekNr.Remove(0, 2);
            while(RekNr.Contains(" "))
            {
                 RekNr = RekNr.Remove(RekNr.IndexOf(" "), 1);
            }
            Console.WriteLine("Nr is {0}", RekNr);
            string Rest = RekNr.Substring(10, 2);
            RekNr = RekNr.Remove(10, 2);
            Console.WriteLine("rest is {0} en getal is {1}", Rest, RekNr);

            
            
        }
    }
}
