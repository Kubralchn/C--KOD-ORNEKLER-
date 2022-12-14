using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karlı_mal_satıiı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Alış fiyatı girilen malın kullanıcının girdiği yüzdelik karla satış fiyatını bulan program

            double aliş, karOran, satiş;
            Console.WriteLine("Sayıyı giriniz:");
            aliş=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kar oranını giriniz:");
            karOran=Convert.ToDouble(Console.ReadLine());
            satiş = aliş + (aliş * karOran / 100);
            Console.WriteLine("Satış fiyatı :{0}", satiş);
            Console.ReadLine();

        }
    }
}
