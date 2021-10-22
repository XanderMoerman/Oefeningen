using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningLoopExtra2
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = int.Parse(Console.ReadLine());
            int lijn = 1; // welke lijn hij moet schrijven.
            while(lijn < (getal + 1))
            {
                int tabs = getal - lijn;
                int teller = 0;
                while (teller < tabs)
                {
                    Console.Write(".");
                    teller++;
                }
                teller = 0;

                Console.Write("x");
                             
                teller = 0;
                while (teller < tabs)
                {
                    Console.Write(".");
                    teller++;
                }
                Console.WriteLine("");
                lijn++;
            }
        }
    }
}
