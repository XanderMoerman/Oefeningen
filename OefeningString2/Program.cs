using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningString2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een zin op.");
            string str = Console.ReadLine();
            string newStr = str;
            Console.WriteLine("Geef een woord op.");
            string str2 = Console.ReadLine();
            short count = 0;
            while (newStr.Contains(str2))
            {
                newStr = newStr.Remove(newStr.IndexOf(str2), str2.Length);
                count++;
            }
            Console.WriteLine("Het woord komt er {0} keer in.", count);
            Console.WriteLine("Zin: {0}\t New zin: {1}", str, newStr);
        }
    }
}
