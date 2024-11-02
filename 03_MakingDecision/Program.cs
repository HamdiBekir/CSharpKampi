
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else 
            //Console.Write("Lütfen Şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password=="abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış!");
            //}

            //string capital, country;
            //Console.Write("Başkentinizi Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ulkenizi Giriniz Giriniz: ");
            //country = Console.ReadLine();
            //if (country=="Türkiye"&capital=="Ankara")
            //{
            //    Console.Write("Veriler DoĞru");
            //}
            //else
            //{
            //    Console.Write("Veriler Yanlış");
            //}

            //int number;
            //Console.Write("Sayıyı Girinşz: ");
            //number=int.Parse(Console.ReadLine());
            //if (number==5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}

            //string city;
            //Console.Write("Şehir Seçiniz: ");
            //city = Console.ReadLine();

            //if (city=="Adana"|city=="Ankara"|city=="Bursa"|city=="Trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil!");
            //}

            #endregion
            #region Mod İşlemleri
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("1.Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1.Sayının 2.Sayıya Bölüünden Kalan: " + result);

            //char team;
            //Console.Write("Lütfen Takım Sembolünü Giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatsaray");
            //}
            //if (team == 't' | team == 'T')
            //{
            //    Console.WriteLine("Trabzonspor");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            #endregion
            #region Örnek Proje Uygulama
            //Menü
            //Console.WriteLine("****C# Eğitim Kampı Restorant****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------");
            //Console.WriteLine("|    1-Ana Yemekler   |");
            //Console.WriteLine("|    2-Çorbalar       |");
            //Console.WriteLine("|    3-Pizzalar       |");
            //Console.WriteLine("|    4-Burgerler      |");
            //Console.WriteLine("|    5-İçecekler      |");
            //Console.WriteLine("|    6-Tatlılar       |");
            //Console.WriteLine("-----------------------");
            //Console.WriteLine();
            //string menuItem;
            //Console.Write("Menu Secenekleri: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine("|    1-Ana Yemekler   |");
            //    Console.WriteLine("|                     |");
            //    Console.WriteLine("| 1- Köri Soslu Tavuk |");
            //    Console.WriteLine("| 2- Kızartma Tabağı  |");
            //    Console.WriteLine("| 3- Mantı            |");
            //    Console.WriteLine("| 4- Fırında Tavuk    |");
            //    Console.WriteLine("| 5- Fırında Somon    |");
            //    Console.WriteLine("|                     |");
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine("|    2-Çorbalar       |");
            //    Console.WriteLine("|                     |");
            //    Console.WriteLine("| 1- Mercimek Çorbası |");
            //    Console.WriteLine("| 2- Ezogelin Çorbası |");
            //    Console.WriteLine("|                     |");
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine("|    3-Pizzalar       |");
            //    Console.WriteLine("|                     |");
            //    Console.WriteLine("| 1- Margarita        |");
            //    Console.WriteLine("| 2- Favori Üçlü      |");
            //    Console.WriteLine("| 3- Sucuk Sever      |");
            //    Console.WriteLine("| 4- Mantar Sever     |");
            //    Console.WriteLine("|                     |");
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine("|    4-Burgerler      |");
            //    Console.WriteLine("|                     |");
            //    Console.WriteLine("| 1- Tavuk Burger     |");
            //    Console.WriteLine("| 2- Köfte Burger     |");
            //    Console.WriteLine("|                     |");
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine("|    5-İçecekler      |");
            //    Console.WriteLine("|                     |");
            //    Console.WriteLine("| 1- Su               |");
            //    Console.WriteLine("| 2- Çay              |");
            //    Console.WriteLine("| 3- Kola             |");
            //    Console.WriteLine("| 4- Fanta            |");
            //    Console.WriteLine("| 5- Ayran            |");
            //    Console.WriteLine("|                     |");
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "6")
            //{
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine("|    6-Tatlılar       |");
            //    Console.WriteLine("|                     |");
            //    Console.WriteLine("| 1- Sütlaç           |");
            //    Console.WriteLine("| 2- Baklava          |");
            //    Console.WriteLine("| 3- Soğuk Baklava    |");
            //    Console.WriteLine("| 4- Kadayıf          |");
            //    Console.WriteLine("| 5- Dondurma         |");
            //    Console.WriteLine("|                     |");
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine();
            //}


            #endregion
            #region Switch Case
            //Console.Write("Lütfen Ay Seçiniz: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.Write("Ocak");
            //        break;
            //    case 2:
            //        Console.Write("Şubat");
            //        break;
            //    case 3:
            //        Console.Write("Mart");
            //        break;
            //    case 4:
            //        Console.Write("Nisan");
            //        break;
            //    case 5:
            //        Console.Write("Mayıs");
            //        break;
            //    case 6:
            //        Console.Write("Haziran");
            //        break;
            //    case 7:
            //        Console.Write("Temmuz");
            //        break;
            //    case 8:
            //        Console.Write("Ağustos");
            //        break;
            //    case 9:
            //        Console.Write("Eylül");
            //        break;
            //    case 10:
            //        Console.Write("Ekim");
            //        break;
            //    case 11:
            //        Console.Write("Kasım");
            //        break;
            //    case 12:
            //        Console.Write("Aralık");
            //        break;
            //    default:
            //        Console.Write("Hatalı Veri Girişi");
            //        break;
            //}

            #endregion
            #region Switch Case Hesap Makinesi
            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("İşlem Giriniz: ");
            //symbol=char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case'+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam:" + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("fark:" + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Toplam:" + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Toplam:" + result);
            //        break;
            //}
            #endregion
            Console.Read();
        }
    }
}
