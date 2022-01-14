Console.Write("Lütfen dizinin eleman sayisini giriniz:  ");
    var n = Convert.ToInt32(Console.ReadLine());
        List<int> ciftSayilar = new List<int>();
             for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Lütfen {0}. sayısı giriniz: ", i+1);
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi % 2 == 0)
                    {
                        Console.WriteLine("Girilen sayılar arasındaki çift sayılar: ");
                        ciftSayilar.Add(sayi);
                    }
                }

            foreach (var sayi in ciftSayilar)
                {
                    Console.Write(sayi + " ");
                }

            
            
        
