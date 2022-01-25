using System;

namespace kurucu_metotlar
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
           Console.WriteLine("*******Çalışan 1*******");
           Calisan calisan1 = new Calisan("Feyza","Akşirin",456,"Bilgi İşlem");
           calisan1.CalisanBilgileri();

           Console.WriteLine("*******Çalışan 2*******");
           Calisan calisan2 = new Calisan();
           calisan2.Ad= "Gazi";
           calisan2.Soyad= "Hataş";
           calisan2.No= 455;
           calisan2.Departman="İnsan Kaynakları";
           calisan2.CalisanBilgileri();


           Console.WriteLine("*******Çalışan 3*******");
           Calisan calisan3 = new Calisan("Hayal","Hataş");
           calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public Calisan(){}
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}",Ad);
            Console.WriteLine("Çalışan Soyadı: {0}",Soyad);
            Console.WriteLine("Çalışan Numarası: {0}",No);
            Console.WriteLine("Çalışan Departmanı: {0}",Departman);
        }

    }
}