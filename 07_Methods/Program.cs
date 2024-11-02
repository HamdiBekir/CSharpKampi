using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Methods

            //void CustomerList()
            //{
            //    Console.WriteLine("Hamdi Bekir Yılmaz");
            //    Console.WriteLine("Burak Aksolak");
            //    Console.WriteLine("Alp Can Kara");
            //    Console.WriteLine("MallBora Boyacı");
            //}
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //}
            //Sum();

            #endregion

            #region GeriyeDegerDondormeyenParametreliMethods

            //void WriteMethods(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethods("HaBekir");

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(33, 66, 99);
            #endregion

            #region Musteri Kard

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");
            #endregion

            #region  GeriyeDegerDondurenParametreliMethods

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Maraz";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());


            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke Adını: "+ countryName + "Başkenti: " + capital + "Bayrak Rengini: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x= Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Gİriniz: ");
            //z= Console.ReadLine();

            //CountryCard(x, y, z);

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " İsimli öğrenci Dersi Geçti Ortalaması: " + result;
                }
                else
                {
                    return student + " İsimli öğrenci Dersi Geçemedi Ortalaması: " + result;
                }
            }

            Console.WriteLine(ExamResult("HBY", 54, 54, 61));
            Console.WriteLine(ExamResult("BA", 45, 78, 41));
            Console.WriteLine(ExamResult("ACK", 31, 69, 52));
            #endregion
            Console.Read();
        }
    }
}