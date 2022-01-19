using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Mavi");
            renkListesi.Add("Siyah");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");
            renkListesi.Add("Mor");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach ve List.ForEach ile elemanlara erişim
            foreach(var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach(var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Liste içerisine arama
            if (sayiListesi.Contains(10))
                Console.WriteLine("10 Liste içerisinde yer alıyor.");
            
            //Eleman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));
            
            //Diziyi List'e çevirme 
            string[] hayvanlar ={"Kedi","Köpek","Kuş","Tavşan"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Liste temizleme
            hayvanListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim ="Feyza";
            kullanıcı1.Soyisim = "Akşirin";
            kullanıcı1.Yas="22";

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim ="Gazi";
            kullanıcı2.Soyisim = "Hataş";
            kullanıcı2.Yas="23";

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe= new List<Kullanıcılar>{};

            yeniListe.Add(new Kullanıcılar(){
                Isim="Furkan",
                Soyisim="Yüksel",
                Yas="6"
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı:" + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı:" + kullanıcı.Yas);
            }
            hayvanListesi.Clear();
        }
    } 
        public class Kullanıcılar
        {
        private string isim;

        private string soyisim;

        private string yas;

        public string Isim { get => isim; set=> isim = value; }

        public string Soyisim {get => soyisim; set => soyisim = value; }
     
        public string Yas {get => yas; set => yas = value; }
    }

}

