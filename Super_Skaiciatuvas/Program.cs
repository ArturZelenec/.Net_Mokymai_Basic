namespace Super_Skaiciatuvas
{
    public class Program
    {
        static double? rezultatas = null;
        static string ivedimas = "";
        static string ivedimas2 = "";
        static bool kartoti = true;

        static void Main(string[] args)
        {
            SuperSkaiciuotuvas();
        }

        public static void SuperSkaiciuotuvas()
        {
            
            while (kartoti)
            {
                Console.WriteLine("[1] - Nauja operacija. [2] - Testi su rezultatu. [3] - Išeiti iš programos.");

                int veiksmas = Convert.ToInt32(Console.ReadLine());

                switch (veiksmas)
                {
                    case 1:
                        veiksmas = Operacija();
                        if (veiksmas == 6)
                        {
                            //jeigu kvadratines saknies traukimas tai tik vienas skaicius reikalingas
                            Console.WriteLine("Įveskite 1 skaičiu:");
                            ivedimas = Ivedimas();
                            rezultatas = Skaiciuotuvas(DoubleSkaiciausTikrinimas(ivedimas), 0, veiksmas);
                        }
                        else
                        {
                            Console.WriteLine("Įveskite du skaičius:");
                            ivedimas = Ivedimas();
                            ivedimas2 = Ivedimas();
                            rezultatas = Skaiciuotuvas(DoubleSkaiciausTikrinimas(ivedimas), DoubleSkaiciausTikrinimas(ivedimas2), veiksmas);
                        }
                        break;
                    case 2:
                        veiksmas = Operacija();

                        if (veiksmas != 6)
                        {
                            //jeigu kvadratines saknies traukimas tai panaudojame esama rezultata.
                            Console.WriteLine("Įveskite skaičiu:");
                            ivedimas2 = Ivedimas();
                        }
                        rezultatas = Skaiciuotuvas((double)rezultatas, DoubleSkaiciausTikrinimas(ivedimas2), veiksmas);
                        break;
                    case 3:
                        kartoti = false;
                        rezultatas = null;
                        break;
                    default:
                        Console.Clear();
                        break;
                };
                if (rezultatas != null)
                {
                    Console.WriteLine($"Rezultatas: {rezultatas}");
                }
            }
        }

        public static int Operacija()
        {
            Console.WriteLine(@" 1. Sudetis
    2. Atimtis
 3. Daugyba
 4. Dalyba
 5. Laipsnio pakelimas
 6. Kvadratines šaknies traukimas");

            return Convert.ToInt32(Console.ReadLine());
        }

        public static double Sudetis(double sk1, double sk2)
        {
             return sk1 + sk2;
        }
        public static double Atimtis(double sk1, double sk2)
        {
            return sk1 - sk2;
        } 
        public static double Daugyba(double sk1, double sk2)
        {
             return sk1* sk2;
        }
        public static double Dalyba(double sk1, double sk2)
        {
            return sk1 / sk2;
        } 

        public static double? Skaiciuotuvas(double sk1, double sk2, int veiksmas)
        {
            double? rezultatas = null;

            switch (veiksmas)
            {
                case 1:
                    rezultatas = Sudetis(sk1, sk2);
                    break;
                case 2:
                    rezultatas = Atimtis(sk1, sk2);
                    break;
                case 3:
                    rezultatas = Daugyba(sk1, sk2);
                    break;
                case 4:
                    rezultatas = Dalyba(sk1, sk2);
                    break;
                case 5:
                    rezultatas = Math.Pow(sk1, sk2);
                    break;
                case 6:
                    rezultatas = Math.Sqrt(sk1);
                    break;
            }
            return rezultatas;
        }
        public static string Ivedimas()
        {
            string ivedimas = Console.ReadLine();
            return ivedimas;
        }

        private static double DoubleSkaiciausTikrinimas(string? tekstas) => double.TryParse(tekstas, out double skaicius) ? skaicius : 0;

        public static double Rezultatas()
        {
            return rezultatas ?? 0;
        }

        public static void Reset()
        {
            rezultatas = null;
        }
    }
}