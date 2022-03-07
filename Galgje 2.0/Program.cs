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
            string StartWord = word;
            char letter;
            string lines = "";
            word = word.ToLower();
            Console.Clear();
            for(int i = 0; i < word.Length; ++i)
            {
                lines = lines.Insert(i, "*");
            }
            for(int i = 0; i < 5; ++i) // Main loop, tot 5
            {
                if (word == "") break; // als woord is geraden, break de loop
                Console.Clear();
                Console.WriteLine(lines);
                Console.WriteLine("Geef een letter in.");
                letter = char.Parse(Console.ReadLine());
                if (word.Contains(letter)) //als de ingelezen letter in het woord zit
                {
                    Console.WriteLine("Letter zit in het woord.");
                    
                    while (word.Contains(letter))
                    {
                        for (int k = 0; k < word.Length; k++) //here
                        {
                            if (word[k] == letter)
                            {
                                lines = lines.Replace(lines[k], letter);
                                break;
                            }
                        }
                        word = word.Remove(word.IndexOf(letter), 1);   
                    }
                    System.Threading.Thread.Sleep(1000);
                }
                else if (!word.Contains(letter)) // anders als de ingelezen letter niet in het woord zit
                {
                    Console.WriteLine("Letter zit niet in het woord.");
                    System.Threading.Thread.Sleep(500);
                }
                
            }
            Console.Clear();
            Console.WriteLine("Het woord was: {0}", StartWord);
            if (word == "") Console.WriteLine("Woord geraden");
            else Console.WriteLine("Probeer nog een keer.");
            System.Threading.Thread.Sleep(500);
        }
    }
}
