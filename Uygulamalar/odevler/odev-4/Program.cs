Console.WriteLine("Lütfen bir cümle giriniz: ");
            string cumle = Console.ReadLine();
            string liste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ" + "abcçdefgğhiıjklmnoöprsştuüvyz";
            string[] kelime = cumle.Split(' ');
            Console.WriteLine("Kelime Sayısı :" + kelime.Length);

            int sayac = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                if (liste.Contains(cumle[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("Harf sayısı: {0}", sayac);
            
