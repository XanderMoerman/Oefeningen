using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for(short soort = 1; soort != 0;)
            {
                Console.WriteLine("Welke soort code wil je?\nGeef 1 voor BCD.\nGeef 2 voor decimaal.\nGeef 0 om te eindigen.");
                soort = short.Parse(Console.ReadLine());
                string code;

                if (soort == 1) // keuze is BDC
                {
                    Console.WriteLine("Geef je BCD code in van 8 karakters.");
                    code = Console.ReadLine();
                    if(code.Length != 8) //als de waarde geen 8 karakters bevat, geef error
                    {
                        Console.WriteLine("Error, geef een BDC waarde in van 8 karakters.");
                        System.Threading.Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("De ingegeven BCD {0} naar andere codes:", code);
                        //Decimal
                        string split1 = code.Remove(4);
                        string split2 = code.Remove(0, 4);
                        int dec1 = Convert.ToInt32(split1, 2);
                        int dec2 = Convert.ToInt32(split2, 2);
                        string dec = Convert.ToString(dec1) + Convert.ToString(dec2);
                        int number = int.Parse(dec);
                        Console.WriteLine("De decimale code: {0}", number);

                        //Hex
                        string hex = Convert.ToString(number, 16);
                        Console.WriteLine("De Hexadecimale code: 0X{0}", hex);

                        //binair
                        int bin1 = Convert.ToInt32(hex, 16);
                        string binair = Convert.ToString(bin1, 2);
                        Console.WriteLine("Binair: 0b{0}", binair);

                        //Ascii
                        Console.WriteLine("ASCII waarde: {0}", (char)number);
                    }
                    

                }
                if (soort == 2) //keuze is decimaal
                {
                    Console.WriteLine("Geef de decimale waarde:");
                    code = Console.ReadLine();
                    int number = int.Parse(code);
                    if (number > 99 || number < 0) //als de waarde kleiner dan 0 of groter dan 99 is, geef error.
                    {
                        Console.WriteLine("Error, Geef een waarde in tusssen 0 en 99.");
                        System.Threading.Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("De decimale code {0} geconverteerd naar andere codes:", code);
                        //hex
                        string hex = Convert.ToString(number, 16);
                        Console.WriteLine("De Hex code: 0x{0}", hex);

                        //binair
                        int bin1 = Convert.ToInt32(hex, 16);
                        string binair = Convert.ToString(bin1, 2);
                        Console.WriteLine("Binair: 0b{0}", binair);

                        //ASCII
                        Console.WriteLine("ASCII waarde: {0}", (char)number);

                        //BDC
                        string split1 = code.Remove(1, 1);
                        string split2 = code.Remove(0, 1);
                        int dec1 = Convert.ToInt32(split1, 8);
                        int dec2 = Convert.ToInt32(split2, 8);
                        string BCD1 = Convert.ToString(dec1, 2);
                        string BCD2 = Convert.ToString(dec2, 2);
                        Console.WriteLine("BCDD code: {0} {1}", BCD1, BCD2);
                    }
                }
            }
            //keuze is 0, stop programma.
            Console.Clear();
            Console.WriteLine("Programma Stoppen.");
            System.Threading.Thread.Sleep(2000);

        }
    }
}