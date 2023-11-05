using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Liste_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sehirler = new List<string>() 
            {
                "Ankara",
                "İstanbul",
                "Van",
                "Samsun",
                "Ordu"
            };
            // Lambda expression = Bu ifade ile listeler üzerinde dolaşma imkanı tanır.
            sehirler.ForEach(s => Console.WriteLine(s));
            Console.WriteLine(new string('-',80));

            var iller = sehirler;
            iller.ForEach(i => Console.WriteLine(i));

            // Veri Ekleme
            sehirler.Add("Sinop");
            Console.WriteLine(new string('-', 80));
            sehirler.ForEach(s => Console.WriteLine(s));
            Console.WriteLine(new string('-', 80));
            iller.ForEach(i => Console.WriteLine(i));
            Console.WriteLine(new string('-', 80));

            // Veri Silme
            iller.Remove("Ankara");
            iller.ForEach(i => Console.WriteLine(i));
            Console.WriteLine(new string('-', 80));
            sehirler.ForEach(s => Console.WriteLine(s));

            // Referans ve Değer Tipleri Organizasyonu birbirinden farklıdır.
            // Belleğin STACK bölümünde veriler için yer alanır. İller ve Şehirler için iki farklı adres vardır.
            // Belleğin diğer bölümü HEAD bölümüdür. Verilerin değerleri burada tutulur.
            // İller ve şehirler STACK bölümünde veri girişi yapılırken veri değerleri HEAD bölümünde tek adrese işaret eder.
            // Bu tür şeylere ihtiyaç olmasının sebebi verilerin yönetimsel fonksiyonlarını kolayca yapabilmektir.
        }
    }
}
