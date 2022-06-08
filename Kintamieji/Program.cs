namespace Kintamieji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki kintamieji");
            //Skaiciu kintamieji
            //sveiku skaiciu kintamieji
            byte mazasSkaicius = 2; //nuo 0 iki 255 tai max skaicius
            short trumpasSkaicius = 2; //nuo -32768 iki 32767
            int skaicius = 2; //nuo -2.147.483.648 iki 2.147.483.647
            int maksimalusIntSkaitmuo = int.MaxValue;
            int minimalusIntSkaitmuo = int.MinValue;

            int? skaiciusKurisGaliButiNull;
            skaiciusKurisGaliButiNull = null;

            Nullable<int> skaiciusKurisGaliButi = null;

            uint tikTeigimasSkaicius = 2; //tik teigiamas skaicius reiskia [uint]
            int? sk = null; //[?] leidzia kintamaji padaryti nulabel
            Console.WriteLine(sk);

            float maziausiasTrupmeninis = 8.5f;
            double trupmeninis = 8.5;
            decimal didziausiasTrupmeninis = 8.5m;

            double a = 6.022e23; // taip uzrasoma 6.022x10^23
            double b = 522_1_000.000_001; //the digit separator

            //daugibine deklaracija
            int deklaracija, deklaracija1, deklaracija2;
            deklaracija = deklaracija1 = deklaracija2 = 100; //visem bus priskirta reiksme 100

            Console.WriteLine("Loginiai kintamieji");
            bool teisybe = true; // reprezentuoja reisybe. Gali buti irasyta true ir false
            bool neteisybe = false;
            bool? nullableLoginis = null;

            Console.WriteLine("Char kintamieji");
            char raide = 'a'; // yra sveiko skaitmens tipas, nors atrodo kad talpina raide


            

        }
    }
}