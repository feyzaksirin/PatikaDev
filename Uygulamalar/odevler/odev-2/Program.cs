Console.Write("Lütfen dizinin eleman sayisini giriniz:  ");
    int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen bir pozitif sayı giriniz: ");
    int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("{0} adet sayi giriniz: ", n);  
List<int> bolunensayılar = new List<int>();  
for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i + 1);
        int sayi = Convert.ToInt32(Console.ReadLine());
            if ((sayi == m) || (sayi % m == 0))
                {
                   
                     bolunensayılar.Add(sayi);
                }
    }
foreach  (var sayi in bolunensayılar)
                {
                    Console.WriteLine("Tam bölünen sayılar: ");
                    Console.Write(sayi + " ");
                }                
   

           
            
            
        
