using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program

    {
        static void Main(string[] args)
        {
            //#region Double
            //Console.WriteLine("-----Fiyat Listesi-----");
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 18.49;
            //strawberryPrice = 44.99;
            //potatoPrice = 13.99;
            //tomatoPrice = 29.99;

            //Console.WriteLine("Elma Birim Fiyatı   : " + " " + applePrice + "TL");
            //Console.WriteLine("Porakal Birim Fiyatı: " + " " + orangePrice + "TL");
            //Console.WriteLine("Çilek Birim Fiyatı  : " + " " + strawberryPrice + "TL");
            //Console.WriteLine("Patates Birim Fiyatı: " + " " + potatoPrice + "TL");
            //Console.WriteLine("Domates Birim Fiyatı: " + " " + tomatoPrice + "TL");
            //Console.WriteLine("------------------------------------------------------");
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.830;
            //orangeGram = 1.230;
            //strawberryGram = 1.035;
            //potatoGram = 2.232;
            //tomatoGram = 1.048;




            //double totalApplePrice = appleGram * applePrice;
            //double totalOrangePrice= orangeGram * orangePrice;
            //double totalStrawberryPrice=strawberryGram * strawberryPrice;
            //double totalPotatoPrice= potatoGram * potatoPrice;
            //double totalTomatoPrice= tomatoGram * tomatoPrice;

            //double totalPrice=totalApplePrice+totalOrangePrice+totalStrawberryPrice+totalPotatoPrice+totalTomatoPrice;


            //Console.WriteLine("Elma Tutarı: " + totalApplePrice +" "+ "TL");
            //Console.WriteLine("Portakal Tutarı: " + totalOrangePrice + " " + "TL");
            //Console.WriteLine("Çilek Tutarı: " + totalStrawberryPrice + " " + "TL");
            //Console.WriteLine("Patates Tutarı: " + totalPotatoPrice + " " + "TL");
            //Console.WriteLine("Domates Tutarı: " + totalTomatoPrice + " " + "TL");
            //Console.WriteLine("---------------------");
            //Console.WriteLine("  ");
            //Console.WriteLine("Toplam Fiyat:" + " " + totalPrice + " " + "TL");
            //Console.ReadKey();
            //#endregion



            //#region String Deger
            //Console.WriteLine("THY Yolcu Bilgi Ekranı");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerCity,passengerDistrict,passengerTel,passengerIdentity;
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İl: ");
            //passengerCity = Console.ReadLine();


            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();


            //Console.Write("TCKN: ");
            //passengerTel = Console.ReadLine();


            //Console.Write("Telefon: ");
            //passengerIdentity = Console.ReadLine();

            //Console.WriteLine("----------------------");
            //Console.WriteLine("Yolcu Adı: " + passengerName + " " +"Yolcu Soyadı"+passengerSurname+"İl"+" "+passengerCity+"İlçe"+" "+passengerDistrict+
            //    "TCKN:"+" "+passengerIdentity+"");

            //Console.ReadKey();

            //#endregion

            //#region Klavyeden int girişleri
            //int shoesPrice, phonePrice, computerPrice, bookPrice;
            //shoesPrice = 1000;
            //phonePrice = 10000;
            //computerPrice = 27000;
            //bookPrice= 200;

            //int shoesCount,phoneCount,computerCount,bookCount;

            //Console.Write("Alınan Ayakkabı Sayısı");
            //shoesCount=Convert.ToInt32(Console.ReadLine());

            //Console.Write("Alınan Telefon Sayısı");
            //phoneCount = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Alınan Bilgisayar Sayısı");
            //computerCount = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Alınan Kitap Sayısı");
            //bookCount = Convert.ToInt32(Console.ReadLine());

            //int totalPrices = 0;
            //int totalShoesPrice, totalPhonePrice, totalComputerPrice, totalBookPrice;

            //totalShoesPrice = shoesPrice * shoesCount;
            //totalPhonePrice = phonePrice * phoneCount;
            //totalComputerPrice = computerPrice * computerCount;
            //totalBookPrice = bookPrice * bookCount;

            //totalPrices = totalShoesPrice + totalPhonePrice + totalComputerPrice + totalBookPrice;

            //Console.WriteLine("Toplam Alınan Ürün: "+"Ayakkabı:"+" "+shoesCount+" "+"Telefon: "+" "+phoneCount+" "+"Bilgisayar: "+" "+computerCount+" "+"Kitap: "+" "+bookCount);
            //Console.WriteLine("Toplam Tutar: " + totalPrices + " " + "TL");
            //Console.ReadKey();
            //#endregion

            #region Klavyeden Ondalıklı Sayı Girişleri

            double vize, final, butunleme, ort;

            Console.WriteLine("Lütfen Vize Puanı Girin");
            vize=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lütfen Final Puanı Girin");
            final = Convert.ToDouble(Console.ReadLine());

            ort=(vize*0.30+final*0.70);
            if(ort>50&&ort<=100)
            {
                Console.WriteLine("Geçti");
            }
            else if(ort>=0&&ort<50)
            {
                Console.WriteLine("Kaldı");
                Console.WriteLine("Bütünleme Puanı Giriniz");
                butunleme = Convert.ToDouble(Console.ReadLine());
                ort = vize * 0.30 + butunleme * 0.70;
                    if (ort>=0&&ort<=50)
                {
                    Console.WriteLine("Kaldı, Ders Tekrarı.");
                }
                else if(ort>50&&ort<=100)
                {
                    Console.WriteLine("Geçti.");
                }              
            }
            Console.ReadKey();
            #endregion


        }
    }
}
