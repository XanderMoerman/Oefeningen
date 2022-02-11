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
            DateTime eerste, tweede;
            Console.WriteLine("Druk op [ENTER] om de starten.");
            Console.ReadLine();
            eerste = DateTime.Now;
            Console.WriteLine("Druk op [ENTER] om de stoppen.");
            Console.ReadLine();
            tweede = DateTime.Now;
            TimeSpan tijd = new TimeSpan(tweede.Ticks - eerste.Ticks);
            Console.WriteLine("{0} seconden\n{1} milliseconden", tijd.Seconds, tijd.Milliseconds - tijd.Seconds);
        }
    }
}
