Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();

kullanıcılar.Add(10,"Furkan Aras Yüksel");
kullanıcılar.Add(12,"Kerem Bulut Akşirin");
kullanıcılar.Add(18,"Gazi Hataş");
kullanıcılar.Add(20,"Feyza Akşirin");

//Dizinin elemanlarına erişim
Console.WriteLine("*****Elemanlara Erişim*****");
Console.WriteLine(kullanıcılar[12]);
foreach (var item in kullanıcılar)
    Console.WriteLine(item);

//Count
Console.WriteLine("*****Count*****");
Console.WriteLine(kullanıcılar.Count);

//Contains
Console.WriteLine("*****Contains*****");
Console.WriteLine(kullanıcılar.ContainsKey(12));
Console.WriteLine(kullanıcılar.ContainsValue("Feyza Akşirin"));

//Remove
Console.WriteLine("*****Remove*****");
kullanıcılar.Remove(12);
foreach (var item in kullanıcılar)
    Console.WriteLine(item.Value);

//Keys
Console.WriteLine("*****Keys*****");
foreach (var item in kullanıcılar.Keys)
    Console.WriteLine(item);

//Values
Console.WriteLine("*****Values*****");
foreach (var item in kullanıcılar.Values)
    Console.WriteLine(item);
