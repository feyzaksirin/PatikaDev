using System;
using System.Collections;

namespace array_list
{
   class Program
   {
      static void Main(string[] args)
      {
         // System.Collections namespace

         ArrayList liste = new ArrayList();
         // liste.Add("Feyza");
         // liste.Add(2);
         // liste.Add(true);
         // liste.Add('G');

         //içerisindeki verilere erişim
         // Console.WriteLine(liste[1]);

         // foreach (var item in liste)
         //  Console.WriteLine(item);

         //AddRange
         Console.WriteLine("****Add Range****");
         // string[] renkler = {"kırmızı","sarı","mavi"};
         List<int> sayilar = new List<int>(){1,4,6,8,12,30,};
         //liste.AddRange(renkler);
         //liste.AddRange(sayılar);

         foreach (var item in liste)
            Console.WriteLine(item);

         //Sort
         Console.WriteLine("****Sort****");
         liste.Sort();

         foreach (var item in liste)
         Console.WriteLine(item);

         // Binary Search
         Console.WriteLine("****Binary Search****");
         Console.WriteLine(liste.BinarySearch(9));

         //Reverse
         Console.WriteLine("****Reverse****");
         liste.Reverse();

         foreach (var item in liste)
            Console.WriteLine(item);
         
         //Clear
         Console.WriteLine("****Clear****");
         liste.Clear();

         foreach (var item in liste)
          Console.WriteLine(item);
      } 
   }
}