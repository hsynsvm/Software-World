using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Mutlak_Değer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Mutlak Değer
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi < 0)
            {
                Console.WriteLine($"|{sayi}| = {sayi * -1}");
            }
            else
            {
                Console.WriteLine($"|{sayi}| = {sayi}");
            }
            #endregion

            #region Karakter Sorgulama

            var k = (char)Console.Read();

            if (char.IsDigit(k) )// K karakteri nedir sorusuna cevap verir.
            {
                Console.WriteLine("Rakamdır!");
            }
            else if (char.IsLower(k) )
            {
                Console.WriteLine("Küçük karakterdir!");
            }
            else if(char.IsUpper(k) ) 
            {
                Console.WriteLine("Büyük karakterdir!");
            }
            else 
            {
                Console.WriteLine("Bilinmeyen karakterdir");
            }
            
            #endregion
        }
    }
}
