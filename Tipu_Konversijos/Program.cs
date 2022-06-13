namespace Tipu_Konversijos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Tipu konversijos!");

            // Implicit casting
            int skaiciusInt = 100;
            long skaiciusLong = 100;

            long castintasLong = (long)skaiciusInt;
            long castintasLong1 = skaiciusInt; // tipo konversija daroma automatiskai

            var castintasLong2 = (long)skaiciusInt;

            byte skaiciusByte = 200;
            int skaiciusInt2 = skaiciusByte;
            long skaiciusLong2 = skaiciusByte;
            long skaiciusLong3 = skaiciusInt2;
            float skaiciusFloat = skaiciusByte;
            float skaiciusFloat2 = skaiciusInt2;
            float skaiciusFloat3 = skaiciusLong2;
            double skaiciusDouble = skaiciusByte;
            double skaiciusDouble2 = skaiciusInt2;
            double skaiciusDouble3 = skaiciusLong2;
            double skaiciusDecimal = skaiciusByte;

            //Explicit casting
            int castintasInt = (int)skaiciusLong;

            float fl = 5.6f;
            int castintasInt1 = (int)fl;
            Console.WriteLine("i={0}", castintasInt1);

            char skaiciusRaide = 'a'; // char turi skaitmeni pagal ASCII lentele todel galima konvertuoti i inta
            int castintasInt2 = (int)skaiciusRaide; 
            Console.WriteLine($" castintasInt2={castintasInt2}");

            long skaiciusLongDidesnis = 3000000000;
            int castintasInt4 = (int)skaiciusLongDidesnis;
            Console.WriteLine($" cstintasInt4= {castintasInt4}"); // nemoka skaicioti

            long skaiciusLongDarDidesnis = long.MaxValue;
            int castintasInt5 = (int)skaiciusLongDarDidesnis;
            Console.WriteLine($" castintasInt5={castintasInt5}");// didesni i mazesni castinti negalima, bet programa neluz ir skaicios nesamones




        }
    }
}