using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leeftijdfuncties
{
    public class Leeftijd
    {
        public static double BerekenLeeftijd (DateTime geboortedatum)
        {
            TimeSpan leeftijdSpan = DateTime.Now.Subtract(geboortedatum);
            return leeftijdSpan.TotalDays / 365;
        }
    }
}