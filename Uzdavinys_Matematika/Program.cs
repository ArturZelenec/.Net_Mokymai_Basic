using System.Diagnostics;

namespace Uzdavinys_Matematika
{
    public class Program
    {
        static void Main(string[] args)
        {
            //    UŽDUOTIS 1 ****************************
            //1.Sukurti metodus Suma, Atimtis, Daugyba, Dalyba.
            // -Main metode paprašykite įvesti 2 skaičius
            // - Kiekvienas matematinis veiksmas turi turėti savo metodą
            //   metodas turi priimti 2 int tipo parametrus ir grąžinti atlikto veiksmo rezultatą.
            // -Kiekvieno metodo darbo rezultatus atspausdinti Main metode.
            // -Visų gautų rezultatų sumą atspausdinti Main metode.


            //2.Skaičiuotuvas.Naudoti pirmos dalies matematinius metodus.
            // -Main metode paprašykite įvesti 2 skaičius ir matematinį veiksmą
            // -Metodas 'Skaiciuotuvas' turi priimti tris parametrus du skaičius ir veiksmą. 
            // -Metodas 'Skaiciuotuvas' turi parinkti reikiamą matematinį metodą ir grąžinti rezultatą(naudoti switch)
            // -parašyti testus
            // - gautą rezultatą atspausdinti į ekraną Main metode.


            //----------------------- 1---------------------------------
            //Console.WriteLine("Iveskite du skaicius gausite suma");
            //var suma = Suma(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            //Console.WriteLine("Iveskite du skaicius gausite skirtuma");
            //var skirtumas = Atimtis(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            //Console.WriteLine("Iveskite du skaicius gausite sandauga");
            //var sandauga = Daugyba(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            //Console.WriteLine("Iveskite du skaicius gausite dalmuo");
            //var dalmuo = Daugyba(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            //Console.WriteLine($"Suma yra: {suma}\nAtimtis yra: {skirtumas}\nDaugyba yra: {sandauga}\nDalyba yra: {dalmuo}");

            //----------------------- 2-----------------------------
            //Console.WriteLine("Iveskite du skaicius ir matematini operatori");
            //var sk1 = Convert.ToInt32(Console.ReadLine());
            //var sk2 = Convert.ToInt32(Console.ReadLine());
            //var operatorius = Console.ReadLine();
            //var kalk = Skaiciatuvas(sk1, sk2, operatorius);
            //Console.WriteLine($" rezultatas = {kalk}");



            //    UŽDUOTIS 2 *******************************************
            //Paprašyti naudotojo įvesti taisyklingojo daugiakampio kraštių kiekį(n) ir kraštinės ilgį(b)., 
            //metodo parinkimui naudoti switch expression
            //1.Kai įvestas trikampis,
            //-paprašyti įvesti aukšį h
            //- A = 1 / 2bh
            //2.Kai įvestas keturkampis,
            //-A = b * b
            //3.Kai įvestas penkiakampis, šešiakampis ir t.t.,
            //-paprašyti įvesti statmenį r
            //- A = n / 2 * b * r
            //4.išvesti betkokio poligono vidinių kampų sumą
            //- 180 * (n - 2)
            //N.B! atkreipkite dėmesį į metodų testuojamumą.
            //visi atvejai 1,2,3 ir 4 turi būti atskiruose metoduose ir metodai turi būti testuojami



            //1.Naudodami method overloading sukurkite metodus Suma, Atimtis, Daugyba, Dalyba kurie priima du double tipo parametrus.

            // (prieštai sukurtų metodų ištrinti negalima)
            //2.Naudotojui įvedus skaičius nustatykite ar buvo įvestas skaičius su kableliu ar be ir duomenis nukreipkite reikiamiems metodams. 
            // (Informaciją apie tai, koks metodas buvo panaudotas išveskite į debug konsolę)
            //3.Matematinius metodus palildykite kėlimu kvadratu(^2) ir kėlimu kūbu(^3).
            //4.Padarykite meniu, kur naudotojui leis pasirinkti koks matematinis veiksmas bus atliekamas
            //  (gali parinkti arba veiksmą, arba veiksmo numerį meniu.Abiem atvejais bus atliekama matematinė operacija)
            //  (Pasirinkimams panaudoti switch sakinį)
            // 1) +
            // 2) -
            // 3) *
            // 4) /
            // 5) a ^ 2
            // 6) a ^ 3

            //var sk1 = Console.ReadLine();
           
            //if (sk1.Contains("."))
            //{
            //Convert.ToDouble(sk1);
             
            //}
            //else
            //{
            //    Convert.ToInt32(sk1);
            //}
            //var sk2 = Console.ReadLine();
            //if (sk2.Contains("."))
            //{
            //    Convert.ToDouble(sk2);
            //}
            //else
            //{
            //    Convert.ToInt32(sk2);
            //}
            //Console.WriteLine("Iveskite du skaicius gausite suma");
            //var suma1 = Suma(sk1, sk2);
            //Console.WriteLine("Iveskite du skaicius gausite skirtuma");
            //var skirtumas1 = Atimtis(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            //Console.WriteLine("Iveskite du skaicius gausite sandauga");
            //var sandauga1 = Daugyba(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            //Console.WriteLine("Iveskite du skaicius gausite dalmuo");
            //var dalmuo1 = Dalyba(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            //var kvadratu= Kvadratu(Convert.ToDouble(Console.ReadLine()));
            //var kubu = Kubu(Convert.ToDouble(Console.ReadLine()));
            //Console.WriteLine($"Suma yra: {suma1}\nAtimtis yra: {skirtumas1}\nDaugyba yra: {sandauga1}\nDalyba yra: {dalmuo1}");
            //Debug.WriteLine($"Suma yra: {suma1}\nAtimtis yra: {skirtumas1}\nDaugyba yra: {sandauga1}\nDalyba yra: {dalmuo1}");

            var a = Console.ReadLine();
            ToInt(a);
            Console.WriteLine(a+10);

        }
        
        

        public static void ToInt(string g)
        {
            if (g.Contains("."))
            {
                Convert.ToDouble(g);
            }
            else
            {
               Convert.ToInt32(g);
            }
          
        }

        public static double Suma(double a, double b)
        {
            
                return a + b;
        }
        public static double Atimtis(double a, double b)
        {
            return a - b;
        }
        public static double Daugyba(double a, double b)
        {
            return a * b;
        }
        public static double Dalyba(double a, double b)
        {
            return a / b;
        }
        public static double Kvadratu(double a)
        {
            return a*a;
        }
        public static double Kubu(double a)
        {
            return a * a*a;
        }

        public static double Skaiciatuvas(int a, int b)
        {
            Console.WriteLine("Meniu: [1] - suma; [2]  - skirtumas; [3] - sandauga; [4] - dalmuo; [5] - kelia kvadratu; [6] - kelia kubu");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    return Suma(a, b);
                case "2":
                    return Atimtis(a, b);
                case "3":
                    return Daugyba(a, b);
                case "4":
                    return Dalyba(a, b);
                case "5":
                    return Kvadratu(a);
                case "6":
                    return Kubu(a);

            }
            return 0;
        }































            public static int Suma(int a, int b)
        {
            return a + b;
        }
        public static int Atimtis(int a, int b)
        {
            return a - b;
        }
        public static int Daugyba(int a, int b)
        {
            return a * b;
        }
        public static double Dalyba(int a, int b)
        {
            return (double)a / b;
        }

        public static double Skaiciatuvas(int a, int b, string c)
        {
            switch (c) //state machine
            {
                case "+":
                    return Suma(a, b);
                    
                case "-":
                    return Atimtis(a, b);
                    
                case "*":
                    return Daugyba(a, b);
                   
                case "/":
                    return Dalyba(a, b);
                    
                
            }
            return 0;
        }
    }
}