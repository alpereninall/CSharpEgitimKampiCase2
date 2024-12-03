using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            // void CustonerList()
            //{
            //    Console.WriteLine("İbrahim Çelebi");
            //    Console.WriteLine("Selim Güvenç");
            //    Console.WriteLine("Erdem Akyıldız");
            //}
            //CustonerList();

            //Console.ReadKey();

            //void Sum()
            //{
            //    int x = 2;
            //    int y=2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum(); 
            //Console.ReadKey();
            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar
            //void customerCard(string name, string surName)
            //{
            //    Console.WriteLine("İsim: "+" "+name+" "+"Soyisim: "+" "+surName);
            //}

            //customerCard("Mehmet", "Yıldırım");

            //    Console.ReadKey();
            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2,int number3) 
            //{ 
            //int result=number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);
            //Console.ReadKey();
            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string customerName()
            //{
            //    return "Mustafa Kemal Erkanat";
            //}
            //customerName();

            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kılıç";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(studentCard());
            //Console.ReadKey();
            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar
            //string countryCard(string countryName,string Capital, string flagColor)
            //{
            //    string cardInfo = "Ülke Adı: " + " " + countryName + " " + "Başkent: " + " " + "Bayrak: " + " " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.WriteLine("Ülke Adını Giriniz: ");
            //x=Console.ReadLine();

            //Console.WriteLine("Başkent Adını Giriniz: ");
            //y=Console.ReadLine();

            //Console.WriteLine("Bayrak Rengini Giriniz: ");
            //z=Console.ReadLine();

            //Console.WriteLine(countryCard(x,y,z));
            //Console.ReadKey();
            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar
            //int Sum(int number1,int number2)
            //{
            //    int result=number1+number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(13,23));
            //Console.WriteLine(Sum(14,34));
            //Console.WriteLine(Sum(15,45));
            //Console.WriteLine(Sum(16,56));

            //Console.ReadKey();


            #endregion

            #region Sınav Uygulaması
            string ExamApp(string studentName, int exam1, int exam2, int exam3) 
            {
            int result=(exam1 + exam2+exam3)/3;
                if (result>=50)
                {
                    return studentName+" " +"Öğrenci Dersten Geçti"+" "+"Ortalama: "+result;
                }
                else
                {
                    return studentName+" "+"Öğrenci Dersten Kaldı."+"Ortalama: "+result;
                }
                Console.WriteLine(ExamApp("Alp",50,60,42));
                Console.WriteLine(ExamApp("Eren", 50, 40, 82));
            }
            #endregion

        }
    }
}
