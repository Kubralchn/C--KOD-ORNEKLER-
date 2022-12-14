using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beden_kitle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Beden kitle indeksi=kilo/boy*boy
            //18'e eşit veya düşükse zayıf
            //18 ile 25 arası normal
            //25'den büyükse obez yazdıran programı yazalım.

            Console.WriteLine("Kilonuzu giriniz:");
            int kilo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Boyunuzu giriniz:");
            double boy=Convert.ToDouble(Console.ReadLine());
            double bke = kilo / (boy * boy);
            if (bke < 18)
            {
                Console.WriteLine("Zayıfsınız:");
                Console.ReadLine();

            }
            else if (bke > 18)
            {
                Console.WriteLine("Kilonuz normal");
                Console.ReadLine();
            }
            else if (bke > 25) ;
            {
                Console.WriteLine("Obezsiniz....");
                Console.ReadLine();
            }
        }
    }
}
