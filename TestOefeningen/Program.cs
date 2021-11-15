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
            Random rnd1 = new Random();
            int Top = rnd1.Next(1, 10);
            int Low = rnd1.Next(1, 10);
            Console.WriteLine("Waardes: {0}, {1}", Top, Low);
        }
    }
}
