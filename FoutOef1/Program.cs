using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoutOef1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] reeks = new int[3];
            Console.WriteLine("Geef de getallen in voor de array.");
            try
            {
                for(int i = 0;i < 10; i++)
                {
                    reeks[i] = int.Parse(Console.ReadLine());
                }
            }
            catch (System.IndexOutOfRangeException) { Console.WriteLine("De index van de array is de klein"); }
            catch(System.Exception e) { Console.WriteLine(e.Message); }
            
        }
    }
}
