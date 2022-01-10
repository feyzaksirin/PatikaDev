Console.WriteLine("Merhabaa");

//Sort
int[]  sayiDizisi = {23,12,4,86,72,12,14,2};

Console.WriteLine("**Sınırsız Dizi**");
foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);
Console.WriteLine("**Sınırlı Dizi**");
Array.Sort(sayiDizisi);
foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

//Clear
Console.WriteLine("**Array Clear**");
//sayiDizisi elemanlarını kullanarak 2.index ten itibaren 2 tane elemanı 0'lar
Array.Clear(sayiDizisi,2,2);

foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

//Reverse
Console.WriteLine("**Array Reverse**");
Array.Reverse(sayiDizisi);

foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

//IndexOf
Console.WriteLine("**Array IndexOf");
Console.WriteLine( Array.IndexOf(sayiDizisi,23));

//Resize
Console.WriteLine("**Array Resize**");
Array.Resize<int>(ref sayiDizisi,9);
sayiDizisi[8] = 99;

foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);