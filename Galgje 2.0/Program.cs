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
            string letter;
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
                letter = Console.ReadLine();
                letter = letter.ToLower();
                if (word.Contains(letter))
                {
                    while (word.Contains(letter))
                    {
                        word = word.Remove(word.IndexOf(letter), 1);
                        Console.WriteLine(word);
                        System.Threading.Thread.Sleep(500);
                        lines = lines.Replace();
                    }
                    
                }
            }
        }
    }
}
