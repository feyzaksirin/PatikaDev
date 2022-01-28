class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

        Calisan calisan = new Calisan("Feyza","Akşirin","İK");
        Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);
    }
}

class Calisan
{
    private static int calisanSayisi;
    private static int CalisanSayisi { get => calisanSayisi; }
    private string Isim;
    private string Soyisim;
    private string Departman;
    static Calisan() {
        calisanSayisi = 0;
    }

    public Calisan(string isim, string soyisim, string departman)
    {
        this.Isim = isim;
        this.Soyisim = soyisim;
        this.Departman = departman;
        calisanSayisi ++;
    }
}