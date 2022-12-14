using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swicth_case_atm_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mini bir atm uygulaması yapcağız.Kullanıcıdan değer alınacak.
            //1-Bakiye görüntüleme
            //2-Para çek
            //3-Para yatır
            //4-Çıkış yapma
            //1-2-3-4 işlem seçilmediyse hata ver

            int bakiye=1000;

            Console.WriteLine("ATM'ye hoşgeldiniz:");
            Console.WriteLine("Lütfen işlem seçiniz:");
            Console.WriteLine("1-Bakiye görüntüleme:");
            Console.WriteLine("2-Para çekme:");
            Console.WriteLine("3-Para yatırma:");
            Console.WriteLine("4-Çıkış yap");

            string secim=Console.ReadLine();
            switch(secim)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz:" + bakiye);
                    break;
                case "2":
                    Console.WriteLine("Çekmek istediğiniz tutarı giriniz: ");
                    int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                    if(cekilecek_tutar>bakiye)
                    {
                        Console.WriteLine("Bakiyenizden fazla para çekemezsiniz:");
                        Console.ReadLine();
                    }
                    else
                        
                    {
                        Console.WriteLine("Kalan Bakiyeniz="+(bakiye - cekilecek_tutar));
                        Console.ReadLine();
                    }
                    break;
                case "3":
                    Console.WriteLine("Yatırmak istediğiniz tutarı giriniz:");
                    int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Yeni bakiyeniz="+(bakiye + yatirilacak_tutar));
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("Hesaptan çıkış yapılıyor.İYİ GÜNLER:");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir seçenek giriniz:");
                    Console.ReadLine();
                    break;

                




            }
        }
    }
}
