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
            string lines = "****";
            Console.WriteLine(lines);
            lines = lines.Insert(2, "a");
            lines = lines.Remove(1, 1);
            Console.WriteLine(lines);
        }
    }
}
