using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint weerstand1, weerstand2;
            Console.WriteLine("Geef de waarden op.");
            weerstand1 = uint.Parse(Console.ReadLine());
            weerstand2 = uint.Parse(Console.ReadLine());
            Console.WriteLine("De vervangingsweerstand is:\t {0:f2} ", (float)(weerstand1*weerstand2)/(weerstand1+weerstand2));
        }
    }
}
