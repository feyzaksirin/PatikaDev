using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            // class SınıfıAdı
            //{
            //      [Erişim Belirleyici] [Veri Tipi] OzellikAdı;
            //      [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi [Parametre Listesi]
            //      {
           //       Metot Konutları
           //       }
           //}

           //Erişim Belirleyiciler
           // * Public
           // * Private
           // * Internal
           // * Protected 

           Calisan calisan1 = new Calisan();
           calisan1.Ad= "Feyza";
           calisan1.Soyad= "Akşirin";
           calisan1.No= 456;
           calisan1.Departman="Bilgi İşlem";
           calisan1.CalisanBilgileri();
           Console.WriteLine("**************");
            
           Calisan calisan2 = new Calisan();
           calisan2.Ad= "Gazi";
           calisan2.Soyad= "Hataş";
           calisan2.No= 455;
           calisan2.Departman="İnsan Kaynakları";
           calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}",Ad);
            Console.WriteLine("Çalışan Soyadı: {0}",Soyad);
            Console.WriteLine("Çalışan Numarası: {0}",No);
            Console.WriteLine("Çalışan Departmanı: {0}",Departman);
        }

    }
}