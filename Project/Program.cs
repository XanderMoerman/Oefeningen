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
            if(soort == 1)
            {
                Console.WriteLine("Geef je BCD code in.");
                code = Console.ReadLine();
                Console.WriteLine("De ingegeven BCD naar andere codes:");

                //Decimal
                string split1 = code.Remove(4);
                string split2 = code.Remove(0, 4);
                int dec1 = Convert.ToInt32(split1, 2);
                int dec2 = Convert.ToInt32(split2, 2);
                string dec = Convert.ToString(dec1) + Convert.ToString(dec2);
                int number = int.Parse(dec);
                Console.WriteLine("De decimale code: {0}", number);

                //Hex
                string hex = Convert.ToString(number, 16);
                Console.WriteLine("De Hexadecimale code: 0X{0}", hex);
                
            }
        }
    }
}
