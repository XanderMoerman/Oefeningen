using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningClasses1
{
    class Program
    {
        static void Main(string[] args)
        {
            int get1=0, get2=0;
            string teken = "";
            while(teken != "=")
            {   
                string lees = Console.ReadLine();
                if (char.IsNumber(lees[0])) get1 = Convert.ToInt32(lees);
                else Console.WriteLine("Geef een goede waarde in."); continue;
                lees = Console.ReadLine();
                if (char.IsLetter(lees[0])) teken = lees;
                else Console.WriteLine("Geef een goed teken in."); continue;
                //here

                switch (teken)
                {
                    
                    case "+":
                        Console.WriteLine("De som is: {0}", Rekenmachine.som(get1, get2));
                        break;
                    case "-":
                        Console.WriteLine("Het verschil is: {0}", Rekenmachine.min(get1, get2));
                        break;
                    case "/":
                        Console.WriteLine("Het quotient is: {0}", Rekenmachine.delen(get1, get2));
                        break;
                    case "*":
                        Console.WriteLine("Het product is: {0}", Rekenmachine.maal(get1, get2));
                        break;
                }
            }
            
        }
    }
}
