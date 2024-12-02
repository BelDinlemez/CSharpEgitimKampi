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
            #region Double Değişkenler
            //Console.OutputEncoding = System.Text.Encoding.Unicode;

            ////double number;
            ////number = 4.85;
            ////Console.WriteLine(number);

            //Console.WriteLine("*Fiyat List*");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potato, tomato;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potato = 9.74;
            //tomato = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice + "₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orangePrice);
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice);
            //Console.WriteLine("---- Patates Birim Fiyatı:" + potato);
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tomato);
            //Console.WriteLine();

            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = 0.750;
            //potatoGram = 4.500;
            //tomatoGram = 3.756;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawTotalPrice = strawberryPrice * strawGram;
            //double potatoTotalPrice = potato * potatoGram;
            //double tomatoTotalPrice = tomato * tomatoGram;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawGram + " - Toplam Tutar: " + strawTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potato + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomato + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice);


            #endregion

            #region Char Değişkenler
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenleri

            //Console.WriteLine("*** CSharp Hava Yolları Yolcu Bilgisi ***");
            //Console.WriteLine();

            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerID;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passangerDistrict = Console.ReadLine();

            //Console.Write("İl Bilgisi: ");
            //passangerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passangerAge = Console.ReadLine();

            //Console.Write("TC No: ");
            //passangerID = Console.ReadLine();



            //Console.WriteLine();

            //Console.WriteLine("Yolcu: " + passangerName + " "+passangerSurname);
            //Console.WriteLine("İl: " + passangerCity + " / İlçe: " + passangerDistrict);
            //Console.WriteLine("Yolcu Yaşı: " + passangerAge + "TC No: "+ passangerID);




            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız tv sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());



            //int shoesTotalPrice = shoesCount * shoesPrice;
            //int computerTotalPrice = computerPrice * computerCount;
            //int chairTotalPrice = chairCount * chairPrice;
            //int tvTotalPrice= tvPrice * tvCount;

            //Console.WriteLine("***** Sepet *****");

            //Console.WriteLine("Ayakkabı Adedi: " + shoesCount + " Adet Fiyatı:  "+shoesPrice+" Toplam Ayakkabı Tutarı: "+ shoesTotalPrice );
            //Console.WriteLine("Bilgisayar Adedi: " + shoesCount + " Adet Fiyatı:  "+shoesPrice+" Toplam Bilgisayar Tutarı: "+ computerTotalPrice );
            //Console.WriteLine("Sandalye Adedi: " + shoesCount + " Adet Fiyatı:  "+shoesPrice+" Toplam Sandalye Tutarı: "+ chairTotalPrice );
            //Console.WriteLine("TV Adedi: " + shoesCount + " Adet Fiyatı:  "+shoesPrice+" Toplam TV Tutarı: "+ tvTotalPrice );

            //Console.WriteLine("***** Fiş *****");


            //int totalPrice = shoesTotalPrice + computerTotalPrice + chairTotalPrice + tvTotalPrice;
            //Console.WriteLine("Toplam Alışveriş Tutarı: " + totalPrice );



            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1. Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Yıl Sonu Ortalaması: "+result);
            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Cinsiyetinizi girin: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Cinsiyetiniz: " + gender);

            #endregion

            Console.Read();


        }
    }
}