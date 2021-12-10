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
            string geraden = "";
            int fout = 0, juist = 0;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Give a word.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            string woord = Console.ReadLine();
            Console.Clear();
            for(int teller = 0; teller != 5; ++teller)
            {
                woord = woord.ToLower();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Letters you can choose from: {0}", text);
                Console.WriteLine("Letters you already picked: {0}", geraden);
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine();
                Console.WriteLine("Lifes left out of 5: {0}", 5 - fout);
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine();
                Console.WriteLine("Amount of right anwsers: {0}", juist);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Aantal fouten tot nu toe: {0}", fout);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Give a letter.");

                Console.ForegroundColor = ConsoleColor.Magenta;
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

                    geraden = geraden + letter + " ";
                    
                }
                if (juist == woord.Length) break;
                Console.Clear();
            }
            Console.Clear();
            if (juist == woord.Length)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("WINNER WINNER CHICKEN DINER!");
                Console.WriteLine(woord);
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (juist != woord.Length)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Loser! Better luck next time.");
                Console.WriteLine(woord);
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("An error occurred. Please try again.");
            }
            
        }
    }
}