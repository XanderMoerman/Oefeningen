using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningArray3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef 20 waarden in en een -1 om te stoppen.");
            int stopWaarde = -1;
            int aantal = 0;
            int t1; // teller
            int[] array1 = new int[20];
            for (t1 = 0; t1 < array1.Length; ++t1)
            {
                array1[t1] = int.Parse(Console.ReadLine());
                if (array1[t1] == stopWaarde) break;
            }

            for(int t2 = 0; t2 < t1; ++t2) // loop tot teller 1, tot laatst ingegeven waarde
            {
                for(int t3 = 0; t3 <= t2; t3++)
                {
                    if (t3 == t2) aantal++; // teller 3 is gelijk aan teller 2 dus getal is nieuw
                    if (array1[t3] == array1[t2]) break; // getal zit al in de array
                    else continue; // getal zit nog niet in array
                }
            }
            Console.WriteLine("Er zijn {0} aantal verschillende getallen.", aantal);
        }
    }
}
