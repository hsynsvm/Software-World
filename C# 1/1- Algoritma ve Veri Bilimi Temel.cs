    using System;
    namespace BtkAkademi
    {
      class Program
      {
        static void Main(string[] args)
        {
            int x;
            x = 2;
            int y = 2 * x;

            Console.WriteLine(y);
            Console.ReadKey();
        }
      }  
    }    
// var = tipin ne olduğu bilinmeyen durumdur.
// Console.Writeline yazdırma işlemidir.
// GetType tipi getirir
// F12 Sisteme gider
// Değişkenler:
// 1-) Tip(Type) 1.1 Yerleşik Tip: int,double float,datetime,bool,char,string... 1.2 Kullanıcı taraflı: Öğrenci numara,adı ve soyadı,cinsiyet - int,string,
//1.3 bool = Struct class  1.4 Örtülü değişken: var ifade = Console.ReadKey();

//2-) İsimlendirme: 1- Rakamla int sayı = 3 2-Semboller #,?,!,...;_ 

//3-) Değer: 1- UpperCase= uzun_fonksiyon_adi  2- CamelCase = uzunFonksiyonAdi 3- Türkçe karakter yok

// Karakter Dizeleri: 1- Yorum satırları // 2- Yorum bloğu /*...*/ 3- Refactoring(iyileştirme)(ctrl + .) 4- Escape \n(yeni satır açma) - \t(sekme açma) - \a(alart verme)
// NOT: C:\user\zcomert ifadesi yazmak için C:\\user\\zcomert yada @C:\user\zcomert yazılmalıdır.

//4-) CHAR : Dize değişmezleri ve Sabit Tanımlama  ASCII: American Standart Code for Informatıon Interchange
// 7 bitlik bir sayı 2 üzeri 7 şeklinde 128 karakter ile kodlanabilir demektir. 2 üzeri olmasının sebebi 1 ve 0'lardır.
// En küçük veri birimi bit. 8 bit= 1 byte / 1024 byte= 1Kb / 1024 Kb = 1 Mb / 1024 Mb = 1 Gb
// var ifade = "Merhaba Programlama"
// Console.Writeline(ifade);
// Console.Writeline(ifade.Length); (UZUNLUK)
// Console.Writeline(ifade.ToUpper); (HEPSİ BÜYÜK HARF)
// Console.Writeline(ifade.ToLower); (HEPSİ KÜÇÜK HARF)
// Console.Writeline(ifade.TrimStart()); (Boşluk alma)
// Console.Writeline(ifade.TrimEnd()); (Boşluk alma)
// Console.Writeline(ifade[0]); İlk karakter
// Console.Writeline(ifade.[ifade.Length-1]); (Son karakter)

// 5-) Operatörler : 1-Aritmetik 2-İlişkisel(karşılaştırma) 3-Mantıksal (&& ve değeri gibi) (|| veya) (! değil)

// 6-) Koşul İfadeleri: 1- IF 2-ELSE  3-Mutlak Değer= Console.Writeline($"|{n}| = {n}"); 4-Char = Karakter

// 7-) Switch-Case (Anahtar-Kutu Yapısı): listeler ve seçimleri break ile işlem haline getirir.

// 8-) Döngüler : For,While,Do-while,Foreach

// 9-) Diziler: Temel Veri yapısıdır. -Sabit boyutludur -Char [] 1byte iken int[] için 4 byte alan kullanır -Sıfır tabanlı modelleme -Rank(Boyut bilgisi) -Length(Veri Uzunluğu) -İndexOf(Metot Desteği) -Copy(Metot Desteği)

// 10-) Çok Boyutlu Dizi: double[,](2 boyutlu)- double[,,](3 boyutlu) = double[,] matris = new double [,] {{1,2,3}, {1,2,3}}; (Manuel veri verme)

// 11-) Arraylist ve List <T> : Arraylist için using System Collections kullanacağız.

// 12-) Metotlar = return - void - params

// 13-) Değer ve Referans Tipler = reference(ref) 

// 14-) Listeler = (List) - Lambda expression(Listeler üzerinde dolaşma işlemi sağlar)

