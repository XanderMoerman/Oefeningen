using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesRekenmachineLib
{
    public class Class1
    {
        public static int som(int get1, int get2)
        {
            return (get2 + get1);
        }
        public static int min(int get1, int get2)
        {
            return (get2 - get1);
        }
        public static int delen(int get1, int get2)
        {
            return (get2 / get1);
        }
        public static int maal(int get1, int get2)
        {
            return (get2 * get1);
        }
        public static int macht(int get1, int get2)
        {
            double Macht1 = Math.Pow(Convert.ToDouble(get2), Convert.ToDouble(get1));
            return Convert.ToInt32(Macht1);
        }

        public static int wortel(int get1, int get2)
        {
            double Wortel1 = Math.Pow(Convert.ToDouble(get2), 1 / (Convert.ToDouble(get1)));
            return Convert.ToInt32(Wortel1);
        }
    }
}
