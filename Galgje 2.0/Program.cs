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
            string letter;
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
                letter = Console.ReadLine();
                if (word.Contains(letter)) //als de ingelezen letter in het woord zit
                {
                    Console.WriteLine("Letter zit in het woord.");
                    while (word.Contains(letter))
                    {
                        int index = word.IndexOf(letter);
                        lines = lines.Insert(index, letter);
                        lines = lines.Remove(index+1,1);
                        word = word.Remove(index, 1); //de letter word uit het woord verwijdert
                        i--; //teller gaat omlaag met 1
                        System.Threading.Thread.Sleep(500); // wacht 500ms
                    }
                    
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
