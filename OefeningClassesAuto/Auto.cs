using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningClassesAuto
{
    class Auto
    {
        public string Merk { get; set; }
        public string Eigenaar { get; set; }
        public DateTime BouwJaar { get; set; }
        
        public Auto()
        {
            Merk = "Onbekend";
            Eigenaar = "Onbekend";
            BouwJaar = DateTime.Today;
        }
        public Auto(string merk, string eigenaar, DateTime bouwjaar)
        {
            this.Merk = merk;
            this.Eigenaar = eigenaar;
            this.BouwJaar = bouwjaar;
        }
        public string Afdruk()
        {
            return ("Merk = " + Merk + " Eigenaar = " + Eigenaar + " Bouwjaar = " + BouwJaar);
        }
    }
}
