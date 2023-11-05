using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Diziler
            /* Temel veri yapısıdır.
             * Sabit boyutludur
             * Sıfır tabanlı modelleme
             * Rank işleminde uygunluk
             * Lenght işleminde uygunluk
             * Index of metot desteği var
             * Copy metot desteği var 
             */
            #endregion

            #region Dizi Tanımlama
            Tanımlama ve Referans tipine göre başlatma ve Atama
            int[] numaralar = new int[] { 3, 5, 7, 8, 10 };      //new int olmasada çalışır               

            for (int i = 0; i <= numaralar.Length; i++)
            {
                //Console.WriteLine(numaralar[i]);
                Console.WriteLine($"Numaralar[{i}] = " +
                    $"{numaralar[i]}");
            }
            #endregion

            #region Dizi Örneği (Foreach ve Random)
            Console.WriteLine("Dizi boyutunu giriniz: ");
            int boyut = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[boyut];

            var r = new Random(); // Random classtır. Karışık şekilde random olarak sayı atar.

            for (int i = 0; i < sayilar.Length; i++)
                sayilar[i] = r.Next(1, 10);

            foreach (int s in sayilar) // Koleksiyonlar üzerinde dolaşmak için kullanılır.
            {
                //Console.WriteLine(s);
                Console.WriteLine($"{s,5} {s * s,5}");
            }
            #endregion

            #region Çok Boyutlu Diziler
            double[,] matris = new double[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
            };

            double toplam = 0; //Matristeki değerleri toplamak için önce değer atama yapılır. (1)

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    if (i == j) //Diyagon eleman tanımlama (i == j) index değerlerine göre 0,0 = 1,1 = 2,2 değerlerinin değişimini sağlamak
                    {
                        matris[i, j] = -1;
                    }

                    if (matris[i, j] % 2 == 0)
                        matris[i, j] = 0; // Çift elemanları 0 yapma

                    toplam += matris[i, j]; // (2)

                    Console.Write($"{matris[i, j],5}");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Toplam: {toplam}"); // (3)
            #endregion



        }
    }
}
