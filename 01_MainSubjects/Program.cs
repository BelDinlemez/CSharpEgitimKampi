using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("Selam");
            //Console.Write("Merhaba Arkadaslar");

            //Console.WriteLine("*Yem KAT*");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemek");
            //Console.WriteLine("3-Soğuk Başlangıç");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine();
            //Console.WriteLine("*Yem KAT*");

            #endregion

            #region String Değişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Belinay";
            //Console.Write(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;
            customerName = "Cengiz";
            customerSurname = "Zaimoğlu";
            customerPhone = "+90..";
            customerEmail = "Ce..@...com";
            district = "Girne";
            city = "Kıbrıs";

            Console.WriteLine("*Rezervasyon KARTI*");
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: "+ customerPhone );
            Console.WriteLine("EMail Adresi: " + customerEmail);
            Console.WriteLine("Adres " + district + "/" + city);
            Console.WriteLine("--------------------------------");

            Console.WriteLine();

            customerName = "Belinay";
            customerSurname = "Dinlemez";
            customerPhone = "+90..";
            customerEmail = "Be..@...com";
            district = "Beyliküdüz";
            city = "İstanbul";

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("EMail Adresi: " + customerEmail);
            Console.WriteLine("Adres " + district + "/" + city);
            Console.WriteLine("--------------------------------");


            #endregion

            #region Int Değişkenler

            //int
            //int num = 24;
            //Console.WriteLine(num);

            int hamburgerPrice = 300;
            int coke = 45;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 350;
            int lemomadePrice = 35;

            Console.WriteLine("*Restorant Menü Fiyatları*");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice +"TL");
            Console.WriteLine("-----Kola: " + coke + "TL");
            Console.WriteLine("-----Su: " + waterPrice + "TL");
            Console.WriteLine("-----Kızartma: " + friesPrice + "TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("-----Limonata: " + lemomadePrice + "TL");
            Console.WriteLine("*Restorant Menü Fiyatları*");

            int hamburgerCount=3;
            int cokeCount=3;
            int waterCount=3;
            int friesCount=1;
            int pizzaCount=0;
            int lemomadeCount=0;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;




            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice= coke * cokeCount;
            totalWaterPrice= waterPrice * waterCount;
            totalFriesPrice= friesPrice * friesCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalLemonadePrice= lemomadePrice * lemomadeCount;

            Console.WriteLine();
            Console.WriteLine("*Fiş*");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Hamburger Tutarı: "+totalHamburgerPrice +"TL");
            Console.WriteLine("Kola Tutarı: "+totalCokePrice +"TL");
            Console.WriteLine("Su Tutarı: "+totalWaterPrice +"TL");
            Console.WriteLine("Kızartma Tutarı: "+totalFriesPrice +"TL");
            Console.WriteLine("Limonata Tutarı: "+totalLemonadePrice +"TL");
            Console.WriteLine("Pizza Tutarı: "+totalPizzaPrice +"TL");


            int totalPrice = totalPizzaPrice + totalWaterPrice + totalLemonadePrice + totalHamburgerPrice + totalCokePrice + totalFriesPrice;
            Console.WriteLine("Toplam Tutar: " +totalPrice +" TL");
            #endregion

            Console.Read();

        }
    }
}


//Yazdırma Komutları