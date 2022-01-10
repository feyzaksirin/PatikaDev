Console.WriteLine("Merhabaa");

// Dizi Tanımlama
string[] renkler = new string[5];
string[] hayvanlar = {"Kedi","Köpek","Kuş","Kelebek"};

int[] dizi;
dizi = new int[5];

//Dizilere Değer Atama ve Erişim
renkler[0] = "Mavi";
dizi[3] = 10;

Console.WriteLine(hayvanlar[1]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[1]);

//Döngülerle Dizi Kullanımı
//Klavyeden girilen n tane sayının ortalamasını hesaplayan program
Console.WriteLine("Lütfen dizinin eleman sayisini giriniz: ");

int diziUzunluğu = int.Parse(Console.ReadLine());
int[] sayıDizisi = new int[diziUzunluğu];

for (int i = 0; i < diziUzunluğu; i++)
{
    Console.WriteLine("Lütfen {0}. sayısı giriniz: ", i+1);
    sayıDizisi[i] = int.Parse(Console.ReadLine());
}
int toplam = 0;

foreach (var sayi in sayıDizisi)
    toplam += sayi;
Console.WriteLine("Ortalama :" + toplam/diziUzunluğu);