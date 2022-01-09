Console.WriteLine("Merhabaa");

Console.WriteLine("While");
//While
Console.WriteLine("1 den başlıyarak consoledan girilen sayıya kadar(sayı dahil) ortalama hesaplama");
//1 den başlıyarak consoledan girilen sayıya kadar(sayı dahil) ortalama hesaplama

Console.WriteLine("Lütfen bir sayı giriniz");
int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;
while (sayac <= sayi)
{
     toplam += sayac;
     sayac ++;
}
Console.WriteLine(toplam/sayi);

Console.WriteLine("a dan z ye kadar tüm harfleri console yazdır ");
//a dan z ye kadar tüm harfleri console yazdır
char character = 'a';
while (character < 'z')
{
    Console.WriteLine(character);
    character ++;
}

Console.WriteLine("Foreach");
//foreach
string[] arabalar = {"BMW","Mercedes","Audi","Ford",};

foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}