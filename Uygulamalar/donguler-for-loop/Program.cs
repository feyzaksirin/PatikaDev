using System;

namespace donguler_for_loop
{ 
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Merhabaa");

// Ekranda girilen sayıya kadar olan tek sayıları yazdırır
Console.WriteLine("Ekranda girilen sayıya kadar olan tek sayıları");

Console.WriteLine("Lütfen bir sayı giriniz: ");
int sayac =int.Parse(Console.ReadLine());
for (int i = 1; i <= sayac; i++)
{
    if(i%2 == 1)
        Console.WriteLine(i);    
}

// 1 ile 100 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdırır
Console.WriteLine("1 ile 100 arasındaki tek ve çift sayıların kendi içlerinde toplamları");

int tekToplam = 0;
int ciftToplam = 0;
for (int i = 1; i <= 1000; i++)
{
    if (i%2 == 1)
        tekToplam += i; // tekToplam = tekToplam + i;

    else
        ciftToplam += i;// tekToplam = tekToplam + i;

}
Console.WriteLine("Tek Toplam: " + tekToplam);
Console.WriteLine("Çift Toplam: " + ciftToplam);

// break, continue
Console.WriteLine("break ve continue");

for (int i = 1; i < 10; i++)
{
    if (i==4)   
        break;
     Console.WriteLine(i);   
}

for (int i = 1; i < 10; i++)
{
    if(i==4)
        continue;
     Console.WriteLine(i);   
}

        }
       
    



    }      
}