﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for Döngüsü
            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1 ; i <=20 ; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen Ekrana yazılmasını İstediğiniz Adedi Giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}


            #endregion
            #region For Dögüsü ile karar yapıları
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalvalue += i;
            //}
            //    Console.WriteLine(totalvalue);

            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine();
            //Console.Write("-> ");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);


            #endregion
            #region Örnek
            //int bacteriım = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacteriım *= 2;
            //    Console.WriteLine(i + ". Saat Sonunda: " + bacteriım);
            //}

            #endregion
            #region While Döngüsü

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüşer");
            //    i++;
            //}

            //int i = 1;
            //while (i<=10)
            //{
            //    if (i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum= 0;

            //while (i<=10)
            //{
            //    sum+=1;
            //    i++;
            //}
            //Console.WriteLine(sum);




            #endregion
            #region Örnek Sınav Sorusu

            //Klavyedem Girilen 3 basamaklı Sayının
            //Basamakları Toplamını Hesaplayan Kodu yazınız

            //Console.Write("3 Basamaklı Sayı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;

            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);

            //sum = ones + tens + hundreds;
            //Console.WriteLine(sum);

            #endregion

            Console.Read();
        }
    }
}
