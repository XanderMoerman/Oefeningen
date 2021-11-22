using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galgje
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
            int fout = 0, juist = 0;
            Console.WriteLine("Geef een woord in.");
            string woord = Console.ReadLine();
            Console.Clear();
            for(int teller = 0; teller != 10; ++teller)
            {
                woord = woord.ToLower();
                Console.WriteLine(text);
                Console.WriteLine("Nog {0} fout(en) te gaan.", 10 - fout);
                Console.WriteLine("Aantal juiste letters : {0}\nAantal foute letters : {1} \n", juist, fout);
                
                Console.WriteLine("Geef een letter in.");
                string letter = Console.ReadLine();
                if (woord.Contains(letter) && text.Contains(letter))
                {
                    ++juist;
                    --teller;
                }
                else if (!text.Contains(letter)) --teller;
                else ++fout;
                if (text.Contains(letter))
                {
                    text = text.Remove(text.IndexOf(" ", text.IndexOf(letter)), 1);
                    text = text.Replace(letter, "");
                    
                }
                Console.Clear();
            }
            Console.WriteLine("DOOD");
        }
    }
}
