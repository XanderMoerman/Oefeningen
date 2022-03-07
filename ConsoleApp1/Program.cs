using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leeftijdfuncties;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Leeftijd.BerekenLeeftijd(DateTime.Parse("02/09/2005")));
        }
    }
}