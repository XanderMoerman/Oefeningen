using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef 20 waarden in en een 0 om te stoppen.");
            int stopWaarde = 0;
            string antwoord = "";
            int[] array1 = new int[20];
            for (int i = 0; i < array1.Length; ++i)
            {
                array1[i] = int.Parse(Console.ReadLine());
                if (array1[i] == 0 || array1[i] == array1.Length)
                {
                    stopWaarde = Array.IndexOf(array1, 0);
                    break;
                }
            }
            Console.WriteLine("StopWaarde is: {0}", stopWaarde);
            Console.WriteLine("Druk op een knop om verder te gaan.");
            Console.Read();
            Console.Clear();
            while(antwoord != "stop")
            {
                Console.WriteLine("gem = bereken het Gemiddelde,\t som = bereken de Som,\t groot = bereken het grootste getal,\t stop = sluit af.");
                antwoord = Console.ReadLine();
                //Gemiddelde
                if(antwoord == "gem")
                {
                    int som = 0;
                    for(int i = 0; i < stopWaarde; ++i)
                    {
                        som += array1[i];
                    }
                    Console.WriteLine("Het gemiddelde is: {0}", som / stopWaarde);
                }

                //som
                if (antwoord == "som")
                {
                    int som = 0;
                    for (int i = 0; i < stopWaarde; ++i)
                    {
                        som += array1[i];
                    }
                    Console.WriteLine("De som is: {0}", som);
                }
            }
        }
    }
}
