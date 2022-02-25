using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningClassesAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            string Merk, Eigenaar;
            DateTime BouwJaar = new DateTime();

            Auto Auto1 = new Auto(); //leeg

            Console.WriteLine("Geef de info op.");
            Merk = Console.ReadLine();
            Eigenaar = Console.ReadLine();
            BouwJaar = DateTime.Parse(Console.ReadLine());
            Auto Auto2 = new Auto(Merk, Eigenaar, BouwJaar); //vol

            Console.WriteLine("Auto1:\nMerk = {0}\nEigenaar = {1}\nBouwJaar = {2}", Auto1.Merk, Auto1.Eigenaar, Auto1.BouwJaar);
            Console.WriteLine();
            Console.WriteLine("Auto2:\nMerk = {0}\nEigenaar = {1}\nBouwJaar = {2}", Auto2.Merk, Auto2.Eigenaar, Auto2.BouwJaar);

            //kan ook
            //Console.WriteLine(Auto1.Afdruk());
            //Console.WriteLine(Auto2.Afdruk());
        }
    }
}
