using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        { int a1 = 5;
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