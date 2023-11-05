using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Değer__ve_Referans_Tipleri
{
    internal class Program
    {
        public static void Degistir(ref int a, ref int b)
        {
            int gecici = a;
            a = b;
            b = gecici;
            Console.WriteLine("{0},{1}", a, b);
        }

        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine("{0},{1}",x,y);
            Degistir(ref x, ref y);
        }
    }
}
