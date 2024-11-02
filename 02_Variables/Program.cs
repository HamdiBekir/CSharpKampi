
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("- Elma Birim Fşyatı:" + applePrice + "Tl");
            //Console.WriteLine("- Portakal Birim Fşyatı:" + orangePrice + "Tl");
            //Console.WriteLine("- Çilek Birim Fşyatı:" + strawberryPrice + "Tl");
            //Console.WriteLine("- Patates Birim Fşyatı:" + potatoPrice + "Tl");
            //Console.WriteLine("- Domates Birim Fşyatı:" + tomatoPrice + "Tl");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyatı: " + applePrice + " - Gramaj: " + appleGram + " - Total Tutar: " + appleTotalPrice + "Tl");
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı: " + orangePrice + " - Gramaj: " + orangeGram + " - Total Tutar: " + orangeTotalPrice + "Tl");
            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyatı: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Total Tutar: " + strawberryTotalPrice + "Tl");
            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyatı: " + potatoPrice + " - Gramaj: " + potatoGram + " - Total Tutar: " + potatoTotalPrice + "Tl");
            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyatı: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Total Tutar: " + tomatoTotalPrice + "Tl");

            //Console.WriteLine();
            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.Write("- Toplam Fİyat :");
            //Console.WriteLine(" " + shoppingTotalPrice + " Tl");

            //Console.WriteLine("---- Elma Toplam Fiyat:" + appleGram * applePrice + "Tl");
            //Console.WriteLine("---- Portakal Toplam Fiyat:" + orangeGram * orangePrice + "Tl");
            //Console.WriteLine("---- Çilek Toplam Fiyat:" + strawberryGram * strawberryPrice + "Tl");
            //Console.WriteLine("---- Patates Toplam Fiyat:" + potatoGram * potatoPrice + "Tl");
            //Console.WriteLine("---- Domates Toplam Fiyat:" + tomatoGram * tomatoPrice + "Tl");


            #endregion
            #region char Değişkenler

            //char Symbol;
            //Symbol = 'a';

            //Console.WriteLine(Symbol);

            #endregion
            #region Klavyeden VeriGİrişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerAge,
            //    passengerDistrict, passengerCity,
            //    passengerIdentityNumber;

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("TC no Bilgisi: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------");
            //Console.WriteLine("Yolcu: " + passengerSurname + " " + passengerName + " " + passengerAge +
            //    " " + passengerDistrict + "/" + passengerCity +
            //    " " + passengerIdentityNumber); 

            #endregion
            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler 

            //int computerPrice, chairPrice, tvPrice;
            //computerPrice = 34500;
            //chairPrice = 7999;
            //tvPrice = 24599;

            //int computerCount, chairCount, tvCount;

            //Console.Write("Alınan Bilgisyar Sayısı: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Alınan Sandalye Sayısı: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Alınan Televizyon(TV) Sayısı: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = computerCount * computerPrice +
            //    chairCount * chairPrice +
            //    tvPrice * tvPrice;

            //Console.WriteLine();

            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);

            #endregion
            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exem1, exem2, exem3, result;

            //Console.Write("1.SınavNotu: ");
            //exem1 = double.Parse(Console.ReadLine());

            //Console.Write("2.SınavNotu: ");
            //exem2 = double.Parse(Console.ReadLine());

            //Console.Write("3.SınavNotu: ");
            //exem3 = double.Parse(Console.ReadLine());

            //Console.WriteLine();

            //result = (exem1 + exem2 + exem3) / 3;
            //Console.WriteLine("SıvavBaşarıOrtalaması: " + result);

            #endregion
            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Cinsiyetinizi Giriniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("cinsiyet: " + gender);

            #endregion
            Console.Read();
        }
    }
}
