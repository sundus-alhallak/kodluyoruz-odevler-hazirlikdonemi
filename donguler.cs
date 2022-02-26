using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("puanınız girin");


            int puan = Convert.ToInt32(Console.ReadLine());

            if(puan>=55)
            {
                Console.Write("geçtin");
            }
            else
            {
                Console.WriteLine("kaldın");
            }
             
            switch(puan)

            {
                case 45:
                    Console.WriteLine("cb");
                    break;
                case 70:
                    Console.WriteLine("bb");
                    break;

            }
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine(i);
            }
            int sayac = 1;
            while (sayac <= 5)
            {
                Console.WriteLine(sayac);
                sayac++;
            }
            int[] sayiDizisi = new int[20];
            int toplam = 0;
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                Console.Write("Lütfen {0}. sayıyı girin:", i + 1);
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
                toplam += sayiDizisi[i];
            }
            double ortalama = toplam / 20;
            Console.WriteLine("Sayıların ortalaması: " + ortalama);
            Console.ReadLine();

            int[] sayiDizis = { 1, 3, 4, 9, 8, 7 };
            Array.Resize<int>(ref sayiDizis, 12);
            sayiDizis[6] = 10;
        }
    }
}