using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var rand = new Random();
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int[] array3 = new int[5];
            for (int i = 0; i < array1.Length; ++i)
            {
                array1[i] = rand.Next(0, 10);
                array2[i] = rand.Next(0, 10);
                Console.WriteLine("Array1: {0}\tArray2: {1}", array1[i], array2[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < array3.Length; ++i)
            {
                array3[i] = array1[i] + array2[i];
                Console.WriteLine("Array3: {0}", array3[i]);
            }
            Console.ReadLine();
        }
    }
}
