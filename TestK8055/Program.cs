using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibK8055;

namespace TestK8055
{
    class Program
    {
        static void Main(string[] args)
        {
            K8055.OpenDevice(0);
            K8055.SetAllDigital();
            K8055.CloseDevice();
        }
    }
}
