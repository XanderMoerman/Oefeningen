using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            string lines = "****";
            string word = Console.ReadLine();
            string letter = Console.ReadLine();
            Console.WriteLine(lines);
            int index = word.IndexOf(letter);
            lines = lines.Insert(index, letter);
            lines = lines.Remove(index + 1, 1);
            Console.WriteLine(lines);
        }
    }
}
