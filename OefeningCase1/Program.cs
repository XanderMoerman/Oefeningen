using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningCase1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Antwoord = Console.ReadLine();
            switch (Antwoord)
            {
                case "hello": Console.WriteLine("Hallo iedereen!");
                    break;
                case "Goodbye": Console.WriteLine("Tot ziens!");
                    break;
                default: Console.WriteLine("Wat zeg je?");
                    break;
            }
        }
    }
}
