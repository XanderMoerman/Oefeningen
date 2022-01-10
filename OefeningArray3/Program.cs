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
            int[] array1 = new int[20];
            for (int i = 0; i < array1.Length; ++i)
            {
                array1[i] = int.Parse(Console.ReadLine());
                if (array1[i] == stopWaarde) break;
                if (array1.Contains(array1[i])) aantal++;
            }
            Console.WriteLine("Er zijn {0} aantal verschillende getallen.", aantal);
                    

        }
    }
}
