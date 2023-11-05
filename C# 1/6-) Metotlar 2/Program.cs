using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___Metotlar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var odenecekMiktar = SatisYap(100);
            Console.WriteLine(odenecekMiktar);
            var odenecekMiktar2 = SatisYap(100, .1);
            Console.WriteLine(odenecekMiktar2);
        }

        private static double SatisYap(double miktar)
        {
            return miktar * 1.18;
        }
        static double SatisYap(double miktar,double indirim)
        {
            return (miktar * (1.0 - indirim)) *1.18;
        }
    }
}
