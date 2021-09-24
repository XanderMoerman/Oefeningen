using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            int intGetal1 = 20, intGetal2 = 20, intRes;
            float floatRes;
            intRes = intGetal1++; floatRes = ++intGetal1;
            Console.WriteLine("res1 = {0} en res2 = {1} ", intRes, floatRes);
            intGetal2++;
            intRes = (intGetal1 + intGetal2) / 2;
            floatRes = (float)((intGetal1 + intGetal2) / 2.0);
            Console.WriteLine("res1 = {0} en res2 = {1:f2} ", intRes, floatRes);
        }
    }
}
