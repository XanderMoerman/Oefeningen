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
        private string Voornaam; // veld voornaam
        public string voornaam // init voornaam
        {
            get { return Voornaam; }
            set { Voornaam = value; }
        }
        public Persoon() //contructor zonder parameters
        {
            naam = "Onbekend";
            voornaam = "Onbekend";
        }
        public Persoon(string Naam, string Voornaam) // met parameters
        {
            this.naam = Naam;
            this.voornaam = Voornaam;
        }
        public string VolledigeNaam() // return
        {
            return (naam + " " +  voornaam);
        }
    }
}
