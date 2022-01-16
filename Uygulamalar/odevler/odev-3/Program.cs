Console.Write("Lütfen dizinin eleman sayisini giriniz:  ");
    var n = Convert.ToInt32(Console.ReadLine());
        List<string> kelimeler = new List<string>();
            for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Lütfen {0}. kelimeyi giriniz: ", i+1);
                    string kelime = System.Convert.ToString(Console.ReadLine());
                    kelimeler.Add(kelime);
                }
                
            Console.WriteLine("Girilen kelimeler sondan başa: ");
             
            int son = kelimeler.Count - 1;

            for (int i = son; i >= 0; --i)
                {
                    Console.Write(kelimeler[i] + " ");
                }
                
                 

            
            
        
