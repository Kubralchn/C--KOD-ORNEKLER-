using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_uygulaması_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı giriş sayfası  uygulaması yapacağız.
            //kullanıcı adı ve şifresini doğru girerse tebrikler başarılı giriş yaptınız.
            //yanlış giriş yaparsa hata verelim ve 3 hak tanıyalım.Kullanıcıya yanlış girdiği sürece döngü dönemeye devam etsin.

            int hak_sayisi=3;
                while (true)
            {
                Console.WriteLine("Kullanıcı adınızı giriniz:");
                string kullaniciadi = Console.ReadLine();
                Console.WriteLine("Şifrenizi giriniz:");
                string sifre=Console.ReadLine();
                if(kullaniciadi=="enes" && sifre=="1234")
                {
                    Console.WriteLine("Tebrikler başarılı bir şekilde giriş yaptınız:");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanıcı adınız ve sifreniz yanlış!!");
                    if(hak_sayisi>0)
                    {
                        hak_sayisi-=1;
                    }
                    if(hak_sayisi==0)
                    {
                        Console.WriteLine("Hakkınız dolmuştur.daha da giriş yapamazsınız:");
                        break;

                    }
                    Console.ReadLine();

                }
            }

        }
    }
}
