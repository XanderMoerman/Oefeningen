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
            Console.WriteLine(RekNr);
            string Rest = RekNr.Substring(10, 2);
            String getal = RekNr.Remove(10, 2);
            Console.WriteLine(Rest);

            
        }
    }
}
