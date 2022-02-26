using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
string[] sayilar=new string[5];
          sayilar[0]="1";
          sayilar[1]="2";
          sayilar[2]="4";
          sayilar[3]="5";
          sayilar[4]="88";
         string[] sayilar2=new string[4];
         Array.Copy(sayilar, sayilar2, 4);
         for (int i = 0; i < sayilar2.Length; i++)
         {
             Console.Write(i);
         }
          Console.Read();
          Console.WriteLine(Array.IndexOf(sayilar, "2"));
    //"2" ifadesini sayilar dizisinde arar.Bulduğu ilk indexi gönderir.Ekranda 1 yazacaktır.
Console.Read();
	
Array.Clear(dizi değişkeni,başlangıç indexi,bitiş indexi)
Console.Read();
}