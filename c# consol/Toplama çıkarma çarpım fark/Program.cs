using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplama_çıkarma_çarpım_fark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan 2 sayının toplamını farkını çarpımını ve bölümünü bulan program

            double sayi1, sayi2, toplam, fark, çarpım, bölüm;
            Console.WriteLine("1. sayıyı giriniz:");
            sayi1=Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("2. Sayıyı giriniz:");
            sayi2=Convert.ToDouble(Console.ReadLine()); 
            toplam=sayi1+sayi2;
            Console.WriteLine("{0} ve {1} sayılarının toplamı:{2}",sayi1,sayi2,toplam);
            Console.ReadLine();
            fark=sayi1-sayi2;
            Console.WriteLine("{0} ve {1} sayılarının farkı:{2}",sayi1, sayi2, fark);
            Console.ReadLine();
            çarpım = sayi1 * sayi2;
            Console.WriteLine("{0} ve {1} sayılarının çarpımı:{2}",sayi1, sayi2, çarpım);
            Console.ReadLine();
            bölüm=sayi1/sayi2;
            Console.WriteLine("{0} ve {1} sayılarının bölümü:{2}",sayi1, sayi2, bölüm);
            Console.ReadLine();

        }
    }
}
