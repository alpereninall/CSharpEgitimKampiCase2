using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Menü (YazdırmaKomutları)
            //Console.WriteLine("Yemek Kategorileri");

            //Console.WriteLine("");

            //Console.WriteLine("--------------");
            //Console.WriteLine("1-Çorbalar");
            //    Console.WriteLine("Mercimek");
            //    Console.WriteLine("Yoğurt");
            //    Console.WriteLine("Kelle Paça");
            //Console.WriteLine("--------------");

            //Console.WriteLine("");
            //Console.WriteLine("--------------");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("Porsiyon Döner");
            //Console.WriteLine("Tas Kebabı");
            //Console.WriteLine("Çoban Kavurma");
            //Console.WriteLine("Sebzeli Kebap");
            //Console.WriteLine("Kuru Fasulye");
            //Console.WriteLine("--------------");


            //Console.WriteLine("");
            //Console.WriteLine("--------------");
            //Console.WriteLine("3-Pideler");
            //Console.WriteLine("Kapalı Kıymalı");
            //Console.WriteLine("Açık Kıymalı");
            //Console.WriteLine("Açık Kuşbaşılı");
            //Console.WriteLine("Açık Yumuttalı");
            //Console.WriteLine("--------------");

            //Console.WriteLine("");
            //Console.WriteLine("--------------");
            //Console.WriteLine("4-Tatlılar");
            //Console.WriteLine("Kadayıf");
            //Console.WriteLine("Künefe");
            //Console.WriteLine("Sütlaç");
            //Console.WriteLine("--------------");

            //Console.WriteLine("");
            //Console.WriteLine("--------------");
            //Console.WriteLine("5-İçecekler");
            //Console.WriteLine("Ayran");
            //Console.WriteLine("Kola");
            //Console.WriteLine("Fanta");
            //Console.WriteLine("Sprite");
            //Console.WriteLine("Su");
            //Console.WriteLine("Şalgam");
            //Console.WriteLine("--------------");


            //Console.ReadKey();
            //#endregion

            //#region customerInformation
            //string customerName, customerSurname,customerPhone,customerEmail,customerCity, customerDistrict;
            //customerName = "Osman";
            //customerSurname = "Ersözlü";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@outlook.com.tr";
            //customerCity = "Samsun";
            //customerDistrict = "İlkadım";

            //Console.WriteLine("***Rezervasyon Kartı***");
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Müşteri:"+customerName+" "+customerSurname);
            //Console.WriteLine("İletişim:"+customerPhone+" "+customerEmail);
            //Console.WriteLine("Şehir:" + customerCity + "/" + customerDistrict);
            //Console.WriteLine("------------------------------");
            //Console.Read();
            //#endregion


            //#region Fiyatlar (intDegisken)
            //int mercimekPrice = 50;
            //int yogurtPrice = 50;
            //int pacaPrice = 70;

            //int donerPrice = 250;
            //int tasKebabPrice = 250;
            //int cobanKavurmaPrice = 300;
            //int sebzeliKebabPrice = 300;
            //int kuruFasulyePrice = 250;

            //int kapaliKiymaliPidePrice =300;
            //int acikKiymaliPidePrice = 350;
            //int acikKusbasiliPidePrice = 400;
            //int acikYumurtaliPidePrice = 300;

            //int kadayifPrice= 70;
            //int kunefePrice= 100;
            //int sutlacPrice=80;

            //int ayranPrice = 30;
            //int colaPrice = 50;
            //int fantaPrice = 50;
            //int spritePrice = 50;
            //int salgamPrice = 30;
            //int suPrice = 20;

            //Console.WriteLine("***Fiyat Etiketi***");
            //Console.WriteLine();
          
            //Console.WriteLine("-------------------");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("Mercimek"+" "+mercimekPrice+" "+"TL");
            //Console.WriteLine("Yoğurt Çorbası" + " " + yogurtPrice + " " + "TL");
            //Console.WriteLine("Paça" + " " + pacaPrice + " " + "TL");
            //Console.WriteLine("-------------------");

            //Console.WriteLine("-------------------");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("Porsiyon Döner: "+" "+donerPrice+  "TL");
            //Console.WriteLine("Tas Kebabı: " + " " + tasKebabPrice + "TL");
            //Console.WriteLine("Çoban Kavurma: " + " " + cobanKavurmaPrice + "TL");
            //Console.WriteLine("Sebzeli Kebap: " + " " + sebzeliKebabPrice + "TL");
            //Console.WriteLine("Kuru Fasulye: " + " " + kuruFasulyePrice + "TL");
            //Console.WriteLine("------------------");


            //Console.WriteLine("-------------------");
            //Console.WriteLine("3- Pideler");
            //Console.WriteLine("Kapalı Kıymalı Pide: " + " " + kapaliKiymaliPidePrice + "TL");
            //Console.WriteLine("Açık Kıymalı Pide " + " " + acikKiymaliPidePrice + "TL");
            //Console.WriteLine("Açık Kuşbaşılı Pide " + " " + acikKusbasiliPidePrice + "TL");
            //Console.WriteLine("Açık Yumurtalı Pide: " + " " + acikYumurtaliPidePrice + "TL");
            //Console.WriteLine("------------------");


            //Console.WriteLine("-------------------");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("Ayran: " + " " + ayranPrice + "TL");
            //Console.WriteLine("Kola " + " " +   colaPrice + "TL");
            //Console.WriteLine("Fanta " + " " +  fantaPrice + "TL");
            //Console.WriteLine("Sprite: " + " " + spritePrice + "TL");
            //Console.WriteLine("Su:" + " " +     suPrice + "TL");
            //Console.WriteLine("Şalgam: " + " " + salgamPrice + "TL");
            //Console.WriteLine("------------------");


            //int mercimekCount;
            //int pacaCount;
            //int suCount;
            //int donerCount;
            //int cobanKavurmaCount;
            //int tasKebabCount;
            //int colaCount;
            //int salgamCount;
            //int ayranCount;

            //int totalMercimekPrice;
            //int totalPacaPrice;
            //int totalDonerPrice;
            //int totalCobanKavurmaPrice;
            //int totaltasKebabıPrice;
            //int totalColaPrice;
            //int totalSalgamPrice;
            //int totalSuPrice;
            //int totalAyranPrice;


            //mercimekCount = 2;
            //pacaCount = 2;
            //donerCount = 2;
            //cobanKavurmaCount = 1;
            //tasKebabCount = 1;
            //colaCount = 2;
            //salgamCount = 1;
            //ayranCount = 1;
            //suCount = 4;


            //totalMercimekPrice = mercimekCount * mercimekPrice;
            //totalPacaPrice = pacaCount * pacaPrice;
            //totalDonerPrice = donerCount * donerPrice;
            //totalCobanKavurmaPrice = cobanKavurmaCount * cobanKavurmaPrice;
            //totaltasKebabıPrice = tasKebabCount * tasKebabPrice;
            //totalColaPrice = colaCount * colaPrice;
            //totalSalgamPrice = salgamCount * salgamPrice;
            //totalAyranPrice = ayranCount * ayranPrice;
            //totalSuPrice = suCount * suPrice;

            //int totalPrice = totalMercimekPrice + totalPacaPrice + totalDonerPrice + totalCobanKavurmaPrice + totaltasKebabıPrice +
            //totalColaPrice + totalSalgamPrice + totalAyranPrice + totalSuPrice;

            //Console.WriteLine("Toplam Ödenecek Tutar:" + " " + totalPrice + " " + "TL");

            //Console.ReadKey();
            //#endregion

        }
    }
}
