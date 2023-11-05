using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___ArrayList_ve_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList                 
            // Diziler sabit boyutludur ancak ArrayList yapının boyutu dinamik olarak artırılabilir.
            // Using System Collections ile kullanılır.

            // Tanımlama
            var arrayList = new ArrayList()
            { 10, "Hüseyin SEVİM", true, "e" }; // Ekleme (2)

            //// Ekleme Yapma (Boxing)(1)
            //arrayList.Add(10);
            //arrayList.Add("Hüseyin SEVİM");
            //arrayList.Add("true");
            //arrayList.Add("e");

            // Dolaşma
            foreach (var e in arrayList)
            {
                Console.Write($"{e} ");
            }

            // Arraylistime yeni dizi ekleme

            int[] sayilar = new int[] { 23, 44, 55 }; //ArrayListime yeni dizi ekleme (1)
            arrayList.AddRange(sayilar); // (2) 

            Console.WriteLine();
            foreach (var e in arrayList)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();
            //Elemana Erişme
            Console.WriteLine(arrayList[4]);

            // Eleman Erişme - Atama
            int x = (int)arrayList[0]; // kutudan çıkarma
            Console.WriteLine(x + 10);

            // Eleman çıkarma
            //arrayList.Remove(10);
            //arrayList.RemoveAt(1); // 1. index gidecek.
            arrayList.RemoveRange(3, 3); // 3-5 arasındaki elemanları siler 
            foreach (var e in arrayList)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();

            #endregion

            #region Listeler
            // Liste oluşturmak için "List <T> yapısını kullanılır.
            // T ifadesi = Type yer tutucudur. List <int>(), List <double>(),
            // Generic bir ifadedir.

            // Tanımlama
            //List<int> sayilar = new List<int>();
            var sayilar = new List<int>();

            int x = 55; // Bu şekilde de ekleme yapılır. (1)
            int[] Seri = new int[] { 1, 2, 3, }; // (3)

            // Ekleme
            sayilar.Add(10);
            sayilar.Add(15);
            sayilar.Add(20);
            sayilar.Add(x); // (2)
            sayilar.AddRange(Seri); // (4)
            sayilar.AddRange(new int[] {4,5,6});

            // Araya Ekleme
            sayilar.Insert(3, 7); // 3. indekse 7 değerini atar
            sayilar.InsertRange(4, new int[] {8,9,10}); // 4. indeksten sonra değerleri atar.

            // Değeri Dinamik Olarak Bilmek 
            sayilar.RemoveAt(sayilar.IndexOf(55)); // 55 değerini sil demektir.

            // Silme
            sayilar.RemoveAt(3); // 3. elemanı atar

            // Dolaşma
            foreach (var s in sayilar)
            {
                Console.Write($"{s,-5}");
            }
            

            #endregion
        }
    }
}
