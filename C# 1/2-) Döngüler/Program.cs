using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region While Döngüsü

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("Döngü Sonu");

            2.ÖRNEK

            int sayac = 1;
            while (sayac <= 10)
            {
                Console.WriteLine("{0,-3} {1,-3}", sayac, sayac * sayac); / sayının karesini verir
                sayac += 1;
            }
            #endregion

            #region DoWhile Döngüsü
            Console.WriteLine("Bir sayı giriniz ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            do
            {
                Console.Write("{0,3}", i);
                i += 2;  // i = i + 2 demektir.

            } while (i <= n);
            #endregion

            #region For Döngüsü

            for (int i = 0; i < 50; i += 5) //Aşağıdan Yukarıya
            {
                Console.WriteLine(i);
            }
            2.ÖRNEK Yukarıdan Aşağıya
            for (int i = 50; i >= 0; i -= 5) //Aşağıdan Yukarıya
            {
                Console.WriteLine(i);
            }

            3.ÖRNEK KARESİ ALMA
            for (int i = 1; i < 10; i++) //Aşağıdan Yukarıya
            {
                Console.WriteLine("{0,3} {1,3}", i, i * i);
            }

            4.ÖRNEK SAYILARA SIRALAMA VE TAM BÖLMELERİ SİLME

                int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0) //3'e tam bölünme                
                    continue; //Döngü sonuna giderek bloğu çalıştırır.
                Console.Write("{0,3}", i);
            }

            5.ÖRNEK KONSOLDAN GİRİLEN SAYIDAN BAŞLASIN SONRA KIRSIN(BREAK)
                int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                if (i == 50)
                    break; //Döngüyü kırar
                Console.Write("{0,3}", i);
            }

            6.ÖRNEK TABLO HALİNE GETİRME satır ve sütun
                int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0},{1}", i + 1, j + 1);
                }
                Console.WriteLine();
            }

            7.ÖRNEK MODELLEME
                int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }

            #endregion
        }

    }
}
