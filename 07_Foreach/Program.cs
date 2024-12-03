using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] cities = { "İstanbul", "Ankara", "Samsun", "Kars" };

            //foreach (string x in cities) 
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 91, 63, 95, 55, 79, 36, 06 };
            //foreach (int number in numbers) 
            //{
            //    if (number%2==0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //    else if (number%2==1)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            //int[] numbers= { 45, 91, 63, 95, 55, 79, 36, 06 };
            //int total = 0;
            //foreach (int i in numbers) { 

            //    total=total+i;
            //}

            //List<int> numbers = new List<int>()
            //{1,4,7,19,13,65};

            //int total = 0;
            //for (int i = 0; total <= numbers.Count; i++)
            //{
            //    total = total + i;
            //}
            //Console.WriteLine(total);
            //Console.ReadLine();

            #region Sınav Uygulaması
            Console.WriteLine("***Sınav Uygulaması");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Öğrenci Sayısını Girin.");
            int studentCount=int.Parse(Console.ReadLine());
            
            string[]students=new string[studentCount];
            double[] studentExamAvg = new double[studentCount]; 

            for(int i=0; i<studentCount; i++)
            {
                Console.WriteLine($"{i + 1}.Öğrencinin ismini giriniz.");
                students[i] = Console.ReadLine();


                double totalExamResult = 0;
                for (int j = 0; j <=2; j++)
                {
                    Console.WriteLine($"{students[i]}Adlı Öğrencinin {j + 1}. Sınavını Girin");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResult += value;//Notlar Toplanır.
                }
                studentExamAvg[i] = totalExamResult / 3 ;
            }
            //Öğrencilerin Geçip Kalma Durumu
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{students[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
            }
            #endregion

        }
    }
}
