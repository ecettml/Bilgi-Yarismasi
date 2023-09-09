using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BİLGİ_YARIŞMASI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************");
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Title = "BİLGİ YARIŞMASI";
            Console.WriteLine("YARIŞMAYA HOŞ GELDİNİZ");
            string ad, soyad;
            Console.Write("Lütfen adınızı giriniz= ");
            ad = Console.ReadLine();
            Console.Write("Lütfen soyadınızı giriniz= ");
            soyad = Console.ReadLine();
            Console.WriteLine("Her yanıttan sonra enter tuşuna basmayı unutmayınız!");
            Console.WriteLine("CEVAPLARINIZI BÜYÜK HARFLE GİRİNİZ!");
            int doğru, yanlış, para;
            doğru = 0;
            yanlış = 0;
            para = 0;
            Console.WriteLine("Cumhuriyet hangi yıl ilan edilmiştir?");
            string c1;
            Console.Write("A-1920\n B-1923\n C-1924\n D-1926\n Cevabınız= ");
            c1 = Console.ReadLine();
            if (c1 == "B")
            {
                doğru = doğru + 1;
                para = para + 1000;
                Console.WriteLine("TEBRİKLER");
            }
            else
            {
                yanlış = yanlış + 1;
                Console.WriteLine("Maalesef cevap yanlış");
            }
            
            Console.WriteLine("Türkiyenin başkenti hangi ildir? ");
            string c2;
            Console.Write("A-Bursa\n B-İstanbul\n C-Ankara\n D-Antalya\n Cevabınız=");
            c2 = Console.ReadLine();
            if (c2 == "C")
            {
                doğru = doğru + 1;
                para = para + 1000;
                Console.WriteLine("TEBRİKLER");
            }
            else
            {
                yanlış = yanlış + 1;
                Console.WriteLine("Maalesef cevap yanlış");
            }
            Console.WriteLine("Aşağıdakilerden hangisi Bursa'nın ilçesi değildir? ");
            string c3;
            Console.Write("A-Nilüfer\n B-Osmangazi\n C-Yıldırım\n D-Şişli\n Cevabınız=");
            c3 = Console.ReadLine();
            if (c3 == "D")
            {
                doğru = doğru + 1;
                para = para + 1000;
                Console.WriteLine("TEBRİKLER");
            }
            else
            {
                yanlış = yanlış + 1;
                Console.WriteLine("Maalesef cevap yanlış");
            }
            Console.WriteLine("Atatürk'ün doğum yılı aşağıdakilerden hangisidir?");
            string c4;
            Console.Write("A-1938\n B-1911\n C-1880\n D-1881\n Cevabınız=");
            c4 = Console.ReadLine();
            if (c4 == "D")
            {
                doğru = doğru + 1;
                para = para + 1000;
                Console.WriteLine("TEBRİKLER");
            }
            else
            {
                yanlış = yanlış + 1;
                Console.WriteLine("Maalesef cevap yanlış");
            }
            Console.WriteLine("2.Dünya Savaşı hangi yıl başlamıştır? ");
            string c5;
            Console.Write("A-1923\n B-1928\n C-1939\n D-1950\n Cevabınız=");
            c5 = Console.ReadLine();
            if (c5 == "C")
            {
                doğru = doğru + 1;
                para = para + 1000;
                Console.WriteLine("TEBRİKLER");
            }
            else
            {
                yanlış = yanlış + 1;
                Console.WriteLine("Maalesef cevap yanlış");
            }
            Console.WriteLine("ADINIZ=" + ad);
            Console.WriteLine("SOYADINIZ=" + soyad);
            Console.WriteLine("Doğru sayısı=" + doğru);
            Console.WriteLine("Yanlış sayısı=" + yanlış);
            Console.WriteLine("Kazandığınız para miktarı=" + para);
            Console.Read();
            



        }
    }
}
