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
            float Get1, Get2;
            string stand;
            Console.WriteLine("Geef 2 weestands waarden.");
            Get1 = float.Parse(Console.ReadLine());
            Get2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Geef de stand van de weestanden: serie of parallel.");
            stand = Console.ReadLine();
            switch (stand)
            {
                case "serie": Console.WriteLine("De vervangingsweerstand is: {0}", Get1 + Get2);
                    break;
                case "parallel": Console.WriteLine("De vervangingsweerstand is: {0}", 1 / (1 / Get1) + (1 / Get2));
                    break;
            }
        }
    }
}
