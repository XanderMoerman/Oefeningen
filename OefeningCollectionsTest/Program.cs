using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OefeningCollectionsTest
{
    public class Klant2 : IComparable
    {
        public string Naam { get; set; }
        public Klant2(string naam)
        {
            this.Naam = naam;
        }
        public int CompareTo(object obj)
        {
            return (this.Naam).CompareTo(((Klant2)obj).Naam);
        }
    }

    class Program
    {
        public class Klant
        {
            public string Naam;
            public Klant(string naam) { Naam = naam; }
        }
        static void Main(string[] args)
        {
            ArrayList lijst = new ArrayList();
            Klant k = new Klant("Klant 1");
            lijst.Add(k);
            lijst.Add(new Klant("Klant 2"));
            lijst.Add(new Klant("Klant 3"));

            Console.WriteLine("Object op index 0");
            Klant hulp = (Klant)lijst[0]; // hulp is de class op index 0
            Console.WriteLine(hulp.Naam);

            Console.WriteLine("Alle objecten");
            for(int i = 0; i < lijst.Count; i++)
            {
                Klant hulpje = (Klant)lijst[i]; // hulpje is de class op index i
                Console.WriteLine(hulpje.Naam);
            }

            Console.WriteLine("na wissen");
            lijst.Remove(k); // verwijder "klant 1"
            lijst.RemoveAt(0); // verwijder index 0

            ArrayList lijst2 = new ArrayList();
            lijst2.Add(new Klant2("Klant 2"));
            lijst2.Add(new Klant2("Klant 3"));
            lijst2.Add(new Klant2("Klant 1"));
            lijst2.Sort(); // sorteert de lijst
            for(int i = 0; i < lijst2.Count; i++)
            {
                Console.WriteLine(((Klant2)lijst2[i]).Naam);
            }
        }
    }
}
