using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningLoop1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (byte tellerwaarde = 0, totwaarde = 0; tellerwaarde < 5; tellerwaarde++)
            {
                totwaarde += tellerwaarde;
                Console.WriteLine("De tellerwaarde is {0} en totaal is {1}", tellerwaarde, totwaarde);
            }
        }
    }
}
