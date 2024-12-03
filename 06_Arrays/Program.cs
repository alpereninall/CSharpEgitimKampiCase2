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
            //colors[0] = "Krımızı";
            //colors[1] = "Beyaz";
            //colors[2] = "Siyah";
            //colors[3] = "Mavi";
            //Console.WriteLine(colors[2]);


            //int[] numbers= new int[10];
            //numbers[0] = 300;
            //numbers[1] = 450;
            //numbers[2] = 500;
            //numbers[7] = 600;
            //Console.WriteLine(numbers[6]);



            #endregion

            #region Tüm Elemanları Listeleme
            //string[] colors = { "Kırmızı", "Beyaz", "Sarı", "Yeşil", "Mavi", "Turuncu" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers={3, 7,12,21,35,69,88,467,585,693};
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i]%3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', '*', '-' };
            //for (int i = 0; i < symbols.Length; i++) 
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 467, 80, 100 };
            //int maxNumber=myArray[0];

            //for (int i = 0; i < maxNumber; i++) {

            //    if (maxNumber < myArray[i])
            //    {
            //        maxNumber = myArray[i];
            //    }
            //    Console.WriteLine(maxNumber);
            //  }

            //string[] persons = { "d", "c", "b", "a" };
            //Console.WriteLine(persons.Length);          
            //Console.Read();
            #endregion

            #region Bolme
            int[] sayilar = { 28, 59, 79, 08, 55, 36 };
            Console.WriteLine("Çift Sayılar");
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]%2==0)
                {
                    Console.WriteLine(sayilar[i]);
                }
            }

            Console.WriteLine("Tek Sayılar");
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] %2==1)
                {
                    Console.WriteLine(sayilar[i]);
                }
            }
            Console.ReadKey();
            #endregion
        }
    }
}
