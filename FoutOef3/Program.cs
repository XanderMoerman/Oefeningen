using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoutOef3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] reeks = new int[3];
            Console.WriteLine("Geef de getallen in voor de array.");
            string Error = Opvullen(reeks);
            
        }

        static string Opvullen(reeks)
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    reeks[i] = int.Parse(Console.ReadLine());
                }
            }
            catch (System.IndexOutOfRangeException) { return "OutOfRange"; }
            catch (System.Exception e) { return e.Message; }
        }
    }
}
