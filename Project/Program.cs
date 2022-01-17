using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welke soort code wil je?\nGeef 1 voor BCD.\nGeef 2 voor decimaal.\nGeef 0 om te eindigen.");
            short soort = short.Parse(Console.ReadLine());
            string code;
            string hex, bin;
            if(soort == 1)
            {
                Console.WriteLine("Geef je BCD code in.");
                code = Console.ReadLine();
                Console.WriteLine("De ingegeven BCD naar andere codes:");
                
            }
        }
    }
}
