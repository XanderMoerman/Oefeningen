using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningClasses
{
    class Persoon
    {
        public string naam { get; set; } // init naam
        private string voornaam; // veld naam
        public string Voornaam // init voornaam
        {
            get { return voornaam; }
            set { voornaam = value; }
        }
        public Persoon() //contructor zonder parameters
        {
            naam = "Onbekend";
            voornaam = "Onbekend";
        }
        public Persoon(string Naam, string Voornaam) // met parameters
        {
            this.naam = Naam;
            this.Voornaam = Voornaam;
        }
        public string VolledigeNaam() // return
        {
            return (naam + " " +  Voornaam);
        }
    }
}
