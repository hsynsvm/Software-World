using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _5___Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            // Metot - Fonksiyon - Yordam - Altyordam
            // 1-Erişim belirteci = (public, internal, protectat, private)
            // 2-Dönüş tipi = void
            // 3-Metot Adı
            // 4-Parametre Listesi
            // Static = Nesneye ihtiyaç duymadan çalışır. (static)
            // Metodun imzası = Metot adı + veri tipi + dönüş tipi (int-MetodunAdi-(int,int))
            #endregion    

            int buyuk = Karsilastir(3, 5); // Sayı değerleri
            Console.WriteLine(buyuk);
            var x = KareAl(3);
            double y = KareAl(x);
            double toplam = SeriToplami(5.7, 15.12, 25.5);    // Statik metot bağlama (1)
            Console.WriteLine("{0,5:0.##}", toplam);  // (8)
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        private static double SeriToplami(params double[] seri) // (3)
        {
                        
                double toplam = 0;  // (4)
                foreach (double s in seri)   //(5)
                    toplam += s;   // (7)
            return toplam;  // (6)           
        }
        public static int Karsilastir(int A, int B)
        {
            //if (A > B)
            //{
            //    return A;
            //}
            //else 
            //{
            //    return B;
            //}
            return A > B ? A : B;  // Kısa Yöntem

        }
        static double KareAl(double sayi) // Sayının karesini alma
        {
            double kare = sayi * sayi;
            return kare;
        }
        
        
        

    }
}        
              

