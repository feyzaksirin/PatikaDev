using System;

namespace metotlar_overloading
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // out parametreler
            string sayi ="999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4,5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metot Aşırı Yüklenme-Overloading

            int ifade = 999;
            instance.EkranaYazdır(Convert.ToString(ifade));
            instance.EkranaYazdır(ifade);
           // instance.EkranaYazdır("Feyza","Akşirin");

            //Metot İmzası
            //MetotAdı + parametre sayisi + parametre
        }
    }
    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a+b;
        }

        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdır(int veri)
        {
            Console.WriteLine(veri);
        }
    }
}    
