
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.DesignerServices;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //Console.WriteLine();

            //int[] numbers = { 48, 84, 13, 31, 54, 65, 61 };

            //foreach (var number in numbers) { Console.WriteLine(number); }

            //Console.WriteLine();

            //foreach (var number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //Console.WriteLine();

            //int[] numbers2 = { 48, 84, 13, 31, 54, 65, 61 };

            //int total = 0;

            //foreach (var i in numbers2)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //Console.WriteLine();

            //string world = "HamdiBekirYilmaz";

            //foreach (char worlds in world)
            //{
            //    Console.WriteLine(worlds);
            //}

            #endregion

            #region List<> Kavramı

            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8
            //};

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region Ornek Sınav Sistemi Uygulaması

            Console.Write("**** C# Eğitim kampı Uygulaması ****");
            Console.WriteLine();
            Console.WriteLine();
            //Sınıftaki Öğrenci Sayısını Kullanıcıdan Alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Ogrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //Öğrenci İsimlerini ve Not Ortalmalarını Saklayacak Diziler
            string[] studentNames = new string[studentCount];
            double[] studentExemAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her Öğrenci İçin 3 Sınav Girişi 
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu girinizi: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;//notları toplıyoruz
                }
                Console.WriteLine();

                studentExemAvg[i] = totalExamResult / 3;
            }
            //sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("------------------------------");

                Console.Write($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExemAvg[i]}");
                //öğrencileri ortalması ve geçip kalma durumu
                if (studentExemAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("------------------------------");
            }

            #endregion
            Console.Read();
        }
    }
}
