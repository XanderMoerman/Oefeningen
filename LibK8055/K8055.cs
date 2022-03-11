using System;
using System.Runtime.InteropServices;

namespace LibK8055
{
    public class K8055
    {
        [DllImport("K8055.dll")]
        public static extern int OpenDevice(long CardAdress);
        [DllImport("K8055.dll")]
        public static extern void CloseDevice();
        [DllImport("K8055.dll")]
        public static extern void SetAllDigital();
    }
}
