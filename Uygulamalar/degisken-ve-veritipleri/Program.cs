Console.WriteLine("Merhaba");
// 1 byte
byte b = 5;   
sbyte c = 5;

//2 byte
short s = 5;
ushort us = 5;


Int16 i16 = 2;  //2 byte
int i = 2;      //4 byte
Int32 i32 = 2;  //4 byte
Int64 i64 = 2;  //8 byte


uint ui = 2;    //4 byte
long l= 4;      //8 byte
ulong ul = 4;   //8 byte

//Reel sayılar
float f = 5;    //4 byte
double d = 5;   //8 byte
decimal de = 5; //16byte

char ch = '2';
string str = "Feyza";

bool b1 = true;
bool b2 = false;

DateTime dt = DateTime.Now;


Console.WriteLine(dt);


object o1 = "x";
object o2 = "y";
object o3 = 4;
object o4 = 4.3;

//string ifadeler

string str1 = string.Empty;
str1 = "Feyza Akşirin";
string ad = "Feyza";
string soyad = "Akşirin";
string tamIsım = ad + " " + soyad;

//integer tanımlama şekilleri

int integer1 = 5;
int integer2 = 3;
int integer3 = integer1 * integer2;

//bool
bool booll = 10>2;

//Değişken Dönüşümleri
string str20 = "20";
int int20 = 20;
string yeniDeger = str20 + int20.ToString();
Console.WriteLine(yeniDeger); // Output: 2020

int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(int21); //Output: 40

int int22 = int20 + int.Parse(str20); //Output: 40

//datetime

string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime2);

string hour = DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);

