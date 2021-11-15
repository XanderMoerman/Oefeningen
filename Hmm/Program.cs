using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Hmm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een waarde in.");
            int waarde = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Geef een snelheid in.(in ms)");
            int snelheid = int.Parse(Console.ReadLine());
            for (int counter = 0; waarde >= counter; ++counter)
            {
                Console.Clear();
                Console.WriteLine(counter);
                Thread.Sleep(snelheid);
            }
        }
    }
}
