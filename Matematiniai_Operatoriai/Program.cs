

using System.Text;

Console.WriteLine("Hello, Priskyrimo operatoriai = += -= *= /=");
int skaicius;
int kitasSkaicius = 20;
int nelyginisSkaicius = 5;
skaicius = 10;
kitasSkaicius = skaicius;
Console.WriteLine($"skiacius = {skaicius}, kitasSkaicius = {kitasSkaicius}");

kitasSkaicius += nelyginisSkaicius; // kitasSkaicius = kitasSkaicius + nelyginisSkaicius // tai analogija
Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

kitasSkaicius -= nelyginisSkaicius;
Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

kitasSkaicius *= nelyginisSkaicius;
Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

kitasSkaicius /= nelyginisSkaicius;
Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

int a = 21;
int b = 5;
Console.WriteLine(a/b); // intas be kableliu
Console.WriteLine((double)a/b); // castinimas i double


Console.WriteLine("Hello matematiniai operatoriai");
int skaicius2 = 20;
int kitasSkaicius2 = 3;
//sudetis
int suma = skaicius2 + kitasSkaicius2;
Console.WriteLine(suma);
//atimtis
int atimtis = skaicius2 - kitasSkaicius2;
Console.WriteLine(atimtis);
//daugyba
int daugyba = skaicius2 * kitasSkaicius2;
Console.WriteLine(daugyba);
//dalyba
double dalyba = (double)skaicius2 / kitasSkaicius2; // dalybai turi castinti nors viena skaiciu is into i double
Console.WriteLine(dalyba);
//dalyba su liekana
var dalybaSuLiekana = skaicius2 % kitasSkaicius2;
Console.WriteLine(dalybaSuLiekana);
//++
skaicius2++; //didina vienitu
Console.WriteLine(skaicius2);
//-- 
skaicius2--;
Console.WriteLine(skaicius2);//mazina vienitu

// trapecijos ploto skaiciavimas
double side1 = 5.5;
double side2 = 3.25;
double height = 4.6;
double area = (side1 + side2) / 2 * height; //skaicioja matematikos tvarka

Console.OutputEncoding = Encoding.UTF8;
int nulis = 0;
int int10 = 10;
long long10 = 10;
double double10 = 10;
//Console.WriteLine(int10/nulis);//luzta
//Console.WriteLine(long10/nulis);//luzta
Console.WriteLine(double10/nulis); // begalybes implementacija

//Overflow and Underflow
short s1 = 30_000;
short s2 = 30_000;
short s3 = (short)(s1 + s2);
Console.WriteLine($"s3={s3}");




