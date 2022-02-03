List<char> sesliList = new List<char>();
        string sesliChar = "aeıioöuü";
        System.Console.WriteLine("Lütfen Bir Kelime Giriniz.");
        string metin = Console.ReadLine().ToLower();
        for (int i = 0; i < metin.Length; i++)
        {
            if (sesliChar.Contains(metin[i]))
            {
                  
                sesliList.Add(metin[i]);
            }

        }
        if (sesliList.Count > 0)
        {
            foreach (var item in sesliList)
            {
                System.Console.WriteLine(item);
            }
        }
        else
        {
            System.Console.WriteLine("Girilen Cümlede Sesli Harf Bulunmamaktadır.");
        }