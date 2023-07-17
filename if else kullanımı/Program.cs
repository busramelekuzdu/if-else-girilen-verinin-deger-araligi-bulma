using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());


            if (sayi > 0 && sayi <= 100)
            {
                Console.WriteLine("sayı 0 ile 100 arasındadır");
            }
            else if (sayi > 100 && sayi <= 200)
            {
                Console.WriteLine("sayi 100 ile 200 arasındadır");
            }
            else if (sayi < 0 || sayi > 200)
            {
                Console.WriteLine("sayı 0dan küçük veya 200den büyüktür");
            }
            Console.ReadLine();
        }
    }
}
