using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningString3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een zin in.");
            string str = Console.ReadLine();
            //verwijder leestekens en spaties.
            str = str.ToLower();
            byte i = 0;
            Console.WriteLine(str);
            while (i != str.Length-1)
            {
                if (char.IsLetter(str[i])) ++i;
                else str.Remove(i, 1);
            }
            Console.WriteLine("Zin is {0}:", str);
        }
    }
}
