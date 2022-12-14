using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullanıcıdan_iki_sayı_alma_topçıkar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınan iki sayının toplamını bulan program

            int sayi1, sayi2, toplam;
            Console.WriteLine("1. sayıyı giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz:");
            sayi2=Convert.ToInt32(Console.ReadLine());
            toplam = sayi1 + sayi2;
            Console.WriteLine("{0} ve {1} sayısının toplamı:{2}", sayi1, sayi2, toplam);
            Console.ReadLine();

        }
    }
}
