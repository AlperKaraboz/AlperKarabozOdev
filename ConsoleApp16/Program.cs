using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            sayi = SayiGir();
            YaziylaYaz(sayi);

            Console.ReadLine();

        }
        static int SayiGir()
        {
            string s;
            Console.Write("Bir sayı giriniz= ");
            s = Console.ReadLine();
            int b = int.Parse(s);
            return b;

        }

        static void YaziylaYaz(int sy)
        {
            //Console.WriteLine(sy);
            if (sy == 0)
            {
                SıfırYaz(sy);
            }
            if (sy < 10)
                BirlikYaz(sy);
            else if (sy < 1000)
            {
                YuzlukYaz((sy % 1000) / 100);
                OnlukYaz((sy % 100) / 10);
                BirlikYaz((sy % 10));



            }

        }
        static void SıfırYaz(int b)
        {
            if (b == 0) Console.WriteLine("Sıfır");

        }
        static void BirlikYaz(int b)
        {

            if (b == 1) Console.Write("Bir");
            if (b == 2) Console.Write("İki");
            if (b == 3) Console.Write("Üç");
            if (b == 4) Console.Write("Dört");
            if (b == 5) Console.Write("Beş");
            if (b == 6) Console.Write("Altı");
            if (b == 7) Console.Write("Yedi");
            if (b == 8) Console.Write("Sekiz");
            if (b == 9) Console.Write("Dokuz");

        }

        static void OnlukYaz(int b)
        {
            switch (b)
            {
                case 1: Console.Write("On "); break;
                case 2: Console.Write("Yirmi "); break;
                case 3: Console.Write("Otuz "); break;
                case 4: Console.Write("Kırk "); break;
                case 5: Console.Write("Elli "); break;
                case 6: Console.Write("Altmış "); break;
                case 7: Console.Write("Yetmiş "); break;
                case 8: Console.Write("Seksen "); break;
                case 9: Console.Write("Doksan "); break;
            }


        }
        static void YuzlukYaz(int b)
        {
            switch (b)
            {
                case 1: Console.Write("Yuz "); break;
                case 2: Console.Write("Ikiyuz "); break;
                case 3: Console.Write("Ucyuz "); break;
                case 4: Console.Write("DortYuz "); break;
                case 5: Console.Write("Besyuz "); break;
                case 6: Console.Write("Altiyuz "); break;
                case 7: Console.Write("Yediyuz "); break;
                case 8: Console.Write("Sekizyuz "); break;
                case 9: Console.Write("Dokuzyuz "); break;
            }
        }
    }
}
