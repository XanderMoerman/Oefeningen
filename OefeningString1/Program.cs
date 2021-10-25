using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningString1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            
            while(str.Contains(" "))
            {
                str = str.Remove(str.IndexOf(" "), 1);
                Console.WriteLine(str);
            }
        }
    }
}
