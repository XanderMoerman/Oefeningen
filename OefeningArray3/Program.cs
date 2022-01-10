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
            int aantal = 1;
            int[] array1 = new int[20];
            for (int i = 0; i < array1.Length; ++i)
            {
                array1[i] = int.Parse(Console.ReadLine());
                if (array1[i] == stopWaarde) break;
                for(int k = 0; k != Array.IndexOf(array1, array1[i]); k++)
                {
                    if (array1[i] == array1[k]) continue;
                    else
                    {
                        aantal++;
                        break;
                    }
                }
                Console.WriteLine("aantal = {0}", aantal);
            }
            Console.WriteLine("Er zijn {0} aantal verschillende getallen.", aantal);
                    

        }
    }
}
