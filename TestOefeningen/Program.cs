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
            for(int i = 0; i != 100; ++i)
            {
                switch (i)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        i = 1;
                        break;
                }
                Console.WriteLine("Hoi");
                System.Threading.Thread.Sleep(200);
                Console.Clear();
            }
        }
    }
}
