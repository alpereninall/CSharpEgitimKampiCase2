using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Mod İşlemleri
            //#region If Else
            //string password;
            //Console.WriteLine("Lütfen Parola Giriniz:");
            //password = Console.ReadLine();
            //if (password=="abcd")
            //{
            //    Console.WriteLine("Parola Doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Parola Hatalı.");
            //}
            //Console.ReadKey();

            //string capital, country;        
            //capital= Console.ReadLine();
            //country= Console.ReadLine();

            //if(capital=="Ankara"&&country=="Türkiye")
            //{
            //    Console.WriteLine("Bilgiler Doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Bilgiler Hatalı.");
            //}
            //Console.ReadKey();

            //int number;
            //Console.WriteLine("Sayı Giriniz:");
            //number = Convert.ToInt16(Console.ReadLine());
            //if (number == 5) 
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}

            //Console.ReadKey();

            //int vize, final; double ort;

            //Console.WriteLine("Vize Puanı Giriniz:");
            //vize = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("Final Puanı Giriniz:");
            //final = Convert.ToInt16(Console.ReadLine());

            //ort = vize * 0.3 + final * 0.7;
            //if (ort>=0&&ort<=49)
            //{
            //    Console.WriteLine("Kaldı.");
            //}
            //else if (ort>=50&&ort<=59)
            //{
            //    Console.WriteLine("Şartlı Geçti");
            //}
            //else if (ort>=60&&ort<=100)
            //{
            //    Console.WriteLine("Geçti"); 
            //}

            //Console.ReadKey();



            //#endregion



            //int number;
            //number = 55;
            //int result = number % 10;
            //Console.WriteLine(result);

            //int number1,number2;
            //Console.WriteLine("Lütfen Sayı Giriniz: ");
            //number1=Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Lütfen Sayı Giriniz: ");
            //number2=Convert.ToInt16(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("1. Sayının 2. Sayıya Bölümünden Kalan: "+result);

            //Console.ReadLine();

            //int number;
            //Console.WriteLine("Lütfen Sayı Giriniz:");
            //number=Convert.ToInt16(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir.");
            //}
            //else {
            //Console.WriteLine("Sayı Tektir.");
            //}

            #endregion

            #region Char Kararları

            //char team;
            //Console.WriteLine("Takım Giriniz: ");
            //team = Console.ReadLine();

            //if (team == "fb" | team == "FB")
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == "gs" | team == "GS")
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            #endregion

            #region Restorant Menü
            //Console.WriteLine("-----Restorant Menüsü-----");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Salatalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine();

            //Console.WriteLine("Lütfen Menü Seçimi Yapınız");
            //string menuItem;
            //menuItem= Console.ReadLine();


            //if (menuItem == "1") {
            //    Console.WriteLine("-----------");
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Paça");
            //    Console.WriteLine("3-Ezogelin");
            //    Console.WriteLine("4-İşkembe");
            //    Console.WriteLine("-----------");
            //}
            //if (menuItem=="2")
            //{
            //    Console.WriteLine("-----------");
            //    Console.WriteLine("1-Porsiyon Döner");
            //    Console.WriteLine("2-Tas Kebabı");
            //    Console.WriteLine("3-Çoban Kavurma");
            //    Console.WriteLine("4-Patlıcan Musakka");
            //    Console.WriteLine("-----------");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine("-----------");
            //    Console.WriteLine("1-Mevsim");
            //    Console.WriteLine("2-Çoban");
            //    Console.WriteLine("-----------");
            //}
            //if (menuItem=="4")
            //{
            //    Console.WriteLine("-----------");
            //    Console.WriteLine("1-Ayran");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3-Fanta");
            //    Console.WriteLine("4-Şalgam Suyu");
            //    Console.WriteLine("Su");
            //    Console.WriteLine("-----------");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine("-----------");
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Kadayıf");
            //    Console.WriteLine("3-Kazandibi");
            //    Console.WriteLine("-----------");
            //}

            //Console.ReadKey();
            #endregion

            #region SwitchCase
            //int monthNumber;
            //Console.WriteLine("Lütfen Ay Girişi Yapınız: ");
            //monthNumber = Convert.ToInt16(Console.ReadLine());          
            //switch (monthNumber) {
            //    case 1:Console.WriteLine("Ocak");break; 
            //    case 2:Console.WriteLine("Şubat");break;
            //    case 3:Console.WriteLine("Mart");break;
            //    case 4:Console.WriteLine("Nisan"); break;
            //    case 5:Console.WriteLine("Mayıs"); break;
            //    case 6:Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9:Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı Veri Girişi.");break;
            //}
            //Console.ReadKey();

            int n1, n2,result;
            char symbol;

            Console.WriteLine("Lütfen 1. Sayıyı Giriniz: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen İşlem Giriniz:");
            symbol=char.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. Sayıyı Giriniz: ");
            n2=int.Parse(Console.ReadLine());


            switch (symbol)
            {
                case '+':
                    result=n1+ n2;
                    Console.WriteLine("Toplam: "+result);
                    break;

                case '-':
                    result = n1 - n2;
                    Console.WriteLine("Fark: "+result);
                    break;

                case '*':
                    result = n1 * n2;
                    Console.WriteLine("Çarpım: " + result);
                    break;
                    
                case'/':
                    result = n1 / n2;
                    Console.WriteLine("Bölüm: " + result);
                    break;

            }

            Console.ReadKey();



            #endregion

        }
    }
}
