using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoutOef2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = int.Parse("2147498545");
            }
            catch (System.OverflowException e) { Console.WriteLine(e.Message); } //eerst een overflow als de waarde te groot of te klein is.
            catch (System.ArithmeticException e) { Console.WriteLine(e.Message); } // dan deze als de parse niet goed verlopen is
            catch (System.Exception e) { Console.WriteLine(e.Message); } // daarna de andere indien er zijn
        }
    }
}
