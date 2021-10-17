using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningLoop4
{
    class Program
    {
        static void Main(string[] args)
        {
            float som = 0;
            byte teller = 0;
            for (float getal = 1; getal != 0; teller++)
            {
                getal = float.Parse(Console.ReadLine());
                som += getal;
            }
            Console.WriteLine("Het gemmiddelde is: {0}", som / --teller);
        }
    }
}
