 int[] sayiDizisi = new int[20];
        for (int i = 0; i < 20; i++)
        {
            System.Console.WriteLine("Lütfen {0}. Sayıyı Giriniz.",i+1);
            sayiDizisi[i] = int.Parse(Console.ReadLine());
        }
        int[] minValues = new int[3];
        int[] maxValues = new int[3];
        Array.Sort(sayiDizisi);
        double minValueAvr = 0;
        for (int i = 0; i < 3; i++)
        {
            minValues[i] = sayiDizisi[i];
        }
        System.Console.WriteLine("Dizideki En küçük 3 Eleman");
        foreach (var item in minValues)
        {
            System.Console.WriteLine(item);
            minValueAvr +=item;
        }
        double maxValueAvr = 0;
        Array.Reverse(sayiDizisi);
        for (int i = 0; i < 3; i++)
        {
            maxValues[i] = sayiDizisi[i];
        }
        System.Console.WriteLine("Dizideki En Büyük 3 Eleman");
        foreach (var item in maxValues)
        {
            System.Console.WriteLine(item);
            maxValueAvr +=item;
        }
        System.Console.WriteLine("Küçükler Dizisinin Ortalaması: "+minValueAvr/3);
        System.Console.WriteLine("Büyükler Dizisinin Ortalaması: "+maxValueAvr/3);
        System.Console.WriteLine("Küçükler Dizisinin Ortalama Toplamları: "+minValueAvr);
        System.Console.WriteLine("Büyükler Dizisinin Ortalama Toplamları: "+maxValueAvr);