using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int x = 5, y = 15, z = 3, sayi1 = 5;

            string isim = "MUhAMMED";

            bool k,m,n,l;

             m = x > y;

            n = x < y && x > z; 

            l = (x == y || x == z || x == sayi1);

            k = (x + 10 >= y || x > sayi1) && (23 > sayi1 && 5 == 5); 
            Console.WriteLine(k+" "+m+" "+l+" "+n);

            double ilkSayi = 14.40, ikinciSayi = 4.60, result;
            int say1 = 26, say2 = 4, kal;

            
            result = ilkSayi + ikinciSayi;
            Console.WriteLine("{0} + {1} = {2}", ilkSayi, ikinciSayi, result);

           
            result = ilkSayi - ikinciSayi;
            Console.WriteLine("{0} - {1} = {2}", ilkSayi, ikinciSayi, result);

       
            result = ilkSayi * ikinciSayi;
            Console.WriteLine("{0} * {1} = {2}", ilkSayi, ikinciSayi, result);

            result = ilkSayi / ikinciSayi;
            Console.WriteLine("{0} / {1} = {2}", ilkSayi, ikinciSayi, result);

            kal = say1 % say1;
            Console.WriteLine("{0} % {1} = {2}", say1,say2 ,kal);
            
           

            byte a = 6;
            short b = 10;
            sbyte c = 50;
            int d = a + b + c;
            string e = "deneme";
            char f = 'k';
            object g = e + f + d;
            long h = d;
            float i = h;
            double j = i;
            double k2 = 12.5f;
            Console.WriteLine("dönüşüm="+" "+j + k2);

            

            int a1 = 5;
            byte b1 = (byte)a;
            Console.WriteLine(b1);

            try
            {
                Console.WriteLine("bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());

            }

            catch(FormatException)
            {
                Console.WriteLine("sayı yok");
            }

            
        }
    }
}