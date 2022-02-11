using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Druk op [ENTER] om de starten.");
            DateTime eerste, tweede;
            Console.ReadLine();
            eerste = DateTime.Now;
            Console.Clear();
            Console.WriteLine("Druk op [ENTER] om de stoppen.");
            Console.ReadLine();
            tweede = DateTime.Now;
            TimeSpan tijd = new TimeSpan(tweede.Ticks - eerste.Ticks);
            Console.WriteLine("{0} seconden\n{1} milliseconden", tijd.Seconds, tijd.Milliseconds - tijd.Seconds);
        }
    }
}
