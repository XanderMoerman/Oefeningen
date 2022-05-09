using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OefeningCollections1
{
    class Program
    {

        public class ClassPersoon
        {
            private string Naam;
            private string Voornaam;
            private DateTime Tijd;

            public ClassPersoon(string naam, string voornaam, DateTime tijd)
            {
                this.Naam = naam;
                this.Voornaam = voornaam;
                this.Tijd = tijd;
            }
            public void Afdruk()
            {
                Console.WriteLine("Naam: {0}\nVoornaam: {1}\nTijd: {2}", Naam, Voornaam, Tijd);
            }

        }
        static void Main(string[] args)
        {
            //ClassPersoon persoonTest = new ClassPersoon("Moerman", "Xander", DateTime.Now);
            //persoonTest.Afdruk();


            string Naam = "", Voornaam = "";
            DateTime GeboorteTijd = new DateTime();
            ArrayList PersonenLijst = new ArrayList();
            Console.WriteLine("Geef de Naam, Voornaam, en Geboortedatum in. stop om te stoppen");
            while(true)
            {
                Console.WriteLine("Naam: ");
                Naam = Console.ReadLine();
                if (Naam == "stop") break;
                Console.WriteLine("Voornaam: ");
                Voornaam = Console.ReadLine();
                Console.WriteLine("Geboorte Datum: (dd/mm/yyyy)");
                GeboorteTijd = DateTime.Parse(Console.ReadLine());
                PersonenLijst.Add(new ClassPersoon(Naam, Voornaam, GeboorteTijd));

            }
            Console.Clear();
            for(int i = 0; i < PersonenLijst.Count; i++) // afrukken
            {
                ClassPersoon persoon = (ClassPersoon)PersonenLijst[i];
                persoon.Afdruk();
            }
        }
    }
}
