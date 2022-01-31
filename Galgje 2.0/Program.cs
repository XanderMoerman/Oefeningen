using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galgje_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een woord in.");
            string word = Console.ReadLine();
            char letter;
            string lines;
            word = word.ToLower();
            lines = word;
            for(int i = 0; i < word.Length; ++i)
            {
                lines = lines.Replace(word[i], '_'); //plaats steepjes
            }
            Console.Clear();
            for(int i = 0; i < 5; ++i) // Main loop, tot 5
            {
                Console.Clear();
                Console.WriteLine(lines);
                Console.WriteLine("Geef een letter in.");
                letter = char.Parse(Console.ReadLine());
                if (word.Contains(letter))
                {
                    Console.WriteLine("Letter zit in het woord.");
                    lines = word;
                    while (word.Contains(letter))
                    {
                        for(int k = 0; i < word.Length; ++i)
                        {
                            if(lines[k] == letter)
                            {
                                // hier
                            }
                        }
                        word = word.Remove(word.IndexOf(letter), 1);
                    }
                    System.Threading.Thread.Sleep(500);
                }
                else if (!word.Contains(letter))
                {
                    Console.WriteLine("Letter zit niet in het woord.");
                    System.Threading.Thread.Sleep(500);
                }
            }
        }
    }
}
