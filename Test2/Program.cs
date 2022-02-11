using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            while (true)
            {
                Console.WriteLine("Current Time: {0}", time);
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                time  = time.AddSeconds(1);
            }
        }
    }
}
