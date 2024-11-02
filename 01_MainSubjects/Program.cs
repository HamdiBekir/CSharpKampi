using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırmakomutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1_Çorbalar");
            //Console.WriteLine("2_Ana Yemekler");
            //Console.WriteLine("3_Soğuk Başlangıçlar");
            //Console.WriteLine("4_Salatalar");
            //Console.WriteLine("5_Tatlılar");
            //Console.WriteLine("6_İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** yemek Kategorileri *****");
            #endregion

            #region StringDeğişkenler

            //string
            //değişken_türü Değişken_adı;

            //string name;
            //name = "HaBekir";
            //Console.Write(name);

            //string customerName;
            //string customeSurname;
            //string customerPhone;
            //string customerEmail, city;

            //customerName = "Hamdi";
            //customeSurname = "Yılmaz";
            //customerPhone = "+90 616 161 61 61";
            //customerEmail = "deneme@gmail.com";
            //city = "Trabzon";

            //Console.WriteLine("**** A5_1 Oda Sakinleri ****");
            //Console.Write("1_");
            //Console.WriteLine(" Müşeri: " + customerName + " " + customeSurname);
            //Console.WriteLine("   İletişim: " + customerPhone);
            //Console.WriteLine("   email Adresi: " + customerEmail);
            //Console.WriteLine("   Adres: " + city);
            //Console.WriteLine();

            //customerName = "Alpcan";
            //customeSurname = "Kara";
            //customerPhone = "+90 545 454 54 54";
            //customerEmail = "deneme@gmail.com";
            //city = "Sakarya";

            //Console.Write("2_");
            //Console.WriteLine(" Müşeri: " + customerName + " " + customeSurname);
            //Console.WriteLine("   İletişim: " + customerPhone);
            //Console.WriteLine("   email Adresi: " + customerEmail);
            //Console.WriteLine("   Adres: " + city);
            //Console.WriteLine();

            //customerName = "Burak";
            //customeSurname = "Aksolak";
            //customerPhone = "+90 545 454 54 54";
            //customerEmail = "deneme@gmail.com";
            //city = "Sakarya";

            //Console.Write("3_");
            //Console.WriteLine(" Müşeri: " + customerName + " " + customeSurname);
            //Console.WriteLine("   İletişim: " + customerPhone);
            //Console.WriteLine("   email Adresi: " + customerEmail);
            //Console.WriteLine("   Adres: " + city);
            //Console.WriteLine();

            #endregion

            #region IntDeğikenler

            //int

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 240;
            int cokePrice = 60;
            int waterPrice = 10;
            int friesprice = 50;
            int pizzaPrice = 300;
            int lemonadePrice = 30;
            Console.WriteLine("**** Oda Yemek Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger: " + hamburgerPrice + " Tl");
            Console.WriteLine("----Coke: " + cokePrice + " Tl");
            Console.WriteLine("----Water: " + waterPrice + " Tl");
            Console.WriteLine("----Fries: " + friesprice + " Tl");
            Console.WriteLine("----Pizza: " + pizzaPrice + " Tl");
            Console.WriteLine("----Lemonade: " + lemonadePrice + " Tl");
            Console.WriteLine();
            Console.WriteLine("**** Oda Yemek Fiyatı ****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesprCount;
            int pizzaCount;
            int lemonadeCount;

            int totalPrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesprCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalPrice = hamburgerCount * hamburgerPrice
                + cokeCount * cokePrice
                + waterCount * waterPrice
                + friesprCount * friesprice
                + pizzaCount * pizzaPrice
                + lemonadeCount * lemonadePrice;

            Console.WriteLine("tutar: " + totalPrice + " Tl");
            #endregion

            Console.Read();
        }
    }
}




//Yazdırma Komutları