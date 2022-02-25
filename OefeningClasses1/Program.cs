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
            string teken = "+";
            Console.WriteLine("Tekens:\nplus: +\nmin: -\ndelen: /\nmaal: *\nmacht: ²\nwortel: V\n");
            while(teken != "=")
            {   
                string lees = Console.ReadLine();
                if (char.IsNumber(lees[0])) 
                {
                    get1 = Convert.ToInt32(lees);
                    switch (teken)
                    {

                        case "+":
                            get2 = Rekenmachine.som(get1, get2);
                            //Console.WriteLine("De som is: {0}", get2);
                            break;
                        case "-":
                            get2 = Rekenmachine.min(get1, get2);
                            //Console.WriteLine("Het verschil is: {0}", get2);
                            break;
                        case "/":
                            get2 = Rekenmachine.delen(get1, get2);
                            //Console.WriteLine("Het quotient is: {0}", get2);
                            break;
                        case "*":
                            get2 = Rekenmachine.maal(get1, get2);
                            //Console.WriteLine("Het product is: {0}", get2);
                            break;
                        case "^":
                            get2 = specialeRekenMachine.macht(get1, get2);
                            //Console.WriteLine("De macht is: {0}", get2);
                            break;
                        case "V":
                            get2 = specialeRekenMachine.wortel(get1, get2);
                            break;
                    }
                }
                
                switch (lees)
                {
                    case "+":
                        teken = "+";
                        //Console.WriteLine("teken");
                        break;
                    case "-":
                        teken = "-";
                        //Console.WriteLine("teken");
                        break;
                    case "/":
                        teken = "/";
                        //Console.WriteLine("teken");
                        break;
                    case "*":
                        teken = "*";
                        //Console.WriteLine("teken");
                        break;
                    case "^":
                        teken = "^";
                        //Console.WriteLine("teken");
                        break;
                    case "V":
                        teken = "V";
                        //Console.WriteLine("teken");
                        break;
                    case "=":
                        teken = "=";
                        break;
                }
            }
            Console.WriteLine(get2);
        }
    }
}
