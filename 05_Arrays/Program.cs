using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Ankara";
            //cities[4] = "Trabzon";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[3] = 3;
            //numbers[4] = 4;
            //numbers[7] = 7;

            //Console.WriteLine(numbers[7]);

            //string[] cities = { "Prag", "Atina", "Ankara", "Trabzon" };
            //Console.WriteLine(cities[3]);
            #endregion

            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "Bordo", "Mavi", "Kırmızı",
            //    "Sarı", "Beyaz", "Mor",
            //    "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 6, 8, 12, 16, 24, 48 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', '+', '-', '*', '/' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}
            #endregion

            #region Dizide ki EnBüyük Elamanı Bulan Sayı

            //int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.Şehir Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine(" ");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            #endregion

            #region Örnek

            int[] numbers = { 41, 32, 543, 54, 45, 856, 757, 848, 349, 480 };

            Console.WriteLine("Çift Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Tek Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            #endregion

            Console.Read();
        }
    }
}