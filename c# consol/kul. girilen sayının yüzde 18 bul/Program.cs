using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kul.girilen_sayının_yüzde_18_bul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi, sonuc;
            Console.WriteLine("Bir sayı giriniz:");
            sayi=Convert.ToDouble(Console.ReadLine());
            sonuc = (sayi * 18) / 100;
            Console.WriteLine("Girilen sayının %18'i, {0}", sonuc);
            Console.ReadLine();


        }
    }
}
