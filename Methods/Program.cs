namespace Methods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Methods!");
            Console.WriteLine("sukuriam pirma savo metoda");
            
            IsveskKazkaEkrane(); //metodo kvetimas, kai metodas nieko negrazina ir nepriima
            Console.WriteLine("_____________________");

            float kazkoksSkaicius = GautiAtsitiktiniSkaiciu();//metodo kvietimas ir grazinomos reiksmes priskirima
            Console.WriteLine($"{kazkoksSkaicius}");

            Console.WriteLine("______________________");
            int a = 2;
            IsveskSkaiciuEkrane(a); // metodas su vienu parametru
            Console.WriteLine($"skaicius a is Main {a}");

            Console.WriteLine("___________________________");
            int sk1 = 2;
            int sk2 = 2;
            int sudaugintiDuSkaiciai = DaugintiSkaicius(sk1, sk2); // metodas su dviem parametrais, grazinantis int
            Console.WriteLine($"sudaugintDuSkaiciai = {sudaugintiDuSkaiciai}");

            Console.WriteLine("________________________");
            int sudaugintiTrysSkaicius = DaugintiSkaicius(sk1, sk2, 2); //metodo overloadinimas, metodas priima trys argumentus ir grazina int
            Console.WriteLine($"sudaugintiTrysSkaicia = {sudaugintiTrysSkaicius}");

            Console.WriteLine("_________________________");
            double sk1d = 2.1;
            double sk2d = 2.1;
            double sudaugintiDuDoubleSkaiciai = DaugintiSkaicius(sk1d, sk2d);
            Console.WriteLine($"sudaugintiDuDoubleSkaiciai = {sudaugintiDuDoubleSkaiciai}");

            double sudaugintiDuDoubleSkaiciai2 = DaugintiSkaicius((double)sk1, sk2d);
            Console.WriteLine($"sudaugintiDuDoubleSkaiciai = {sudaugintiDuDoubleSkaiciai2}");

            Console.WriteLine("_____________________");
            IsveskTekstaEkrane();
            IsveskTekstaEkrane("kazkoks tekstas");
            IsveskSkaiciuIrTekstaEkrane(1);

            Console.WriteLine("_____________");
            int patikrintasSkaicius = SkaiciausPatikrinimas(20, 50, 100);
            Console.WriteLine(patikrintasSkaicius);

            int patikrintasSkaicius1 = SkaiciausPatikrinimas(max: 100, min: 50, skaicius: 51); //naiming is metodo
            Console.WriteLine(patikrintasSkaicius1);

            GautiSkaiciu(out int gautasSkaicius);
            Console.WriteLine($"gautasSkaicius = {gautasSkaicius}");

            Console.WriteLine("_____________________");
            int rsk = 2;
            Console.WriteLine($"rsk = {rsk}");
            ReferenceSkaicius(ref rsk); //reiksmes perdavimas per reference keicia reiksme kvieciame metode
            Console.WriteLine($"po ReferenceSkaicius rsk = {rsk}");

            Console.WriteLine("_________________");

            //lokalios funkcijos
            int Add(int a, int b)
            {
                return a + b;
            }
            Console.WriteLine(Add(2,2));

        }



        public static void ReferenceSkaicius(ref int skaicius)
        {
            skaicius = 900;
        }






        public static void GautiSkaiciu(out int skaicius) //grazinama reiksme per parametra out
        {
            skaicius = 2;
        }





        public static double Vidurkis(params int[] skaiciai) //bet kiek parametru padodam
        {
            double total =0;
            foreach (var skaicius in skaiciai)
            {
                total += skaicius;
            }
            return total/skaiciai.Length;
        }


        public static int SkaiciausPatikrinimas(int skaicius, int min, int max)
        {
            if (skaicius < min)
            {
                return min;
            }
            if (skaicius > max) 
            { 
                return max; 
            }
            return skaicius;
        }





        public static void IsveskTekstaEkrane(string tekstas = "tekstas neivestas") //metodas su neprivalomu parametru, perduodamas defaul parametr
        {
            Console.WriteLine(tekstas);
        }

        public static void IsveskSkaiciuIrTekstaEkrane(int skaicius, string tekstas = "tekstas neivestas")
        {
            Console.WriteLine($"{skaicius} {tekstas}");
        }





        public static double DaugintiSkaicius(double sk1d, double sk2d)
        {
            return sk1d * sk2d;
        }

        public static int DaugintiSkaicius(int sk1, int sk2, int sk3)
        {
            return sk1 * sk2 * sk3;
        }

        public static int DaugintiSkaicius(int sk1, int sk2)
        {
            return sk1 * sk2;
        }

        public static void IsveskSkaiciuEkrane(int a)
        {
            a = a + 8;
            Console.WriteLine($"skaicius yra {a}");
        }

        public static float GautiAtsitiktiniSkaiciu()
        {
            return 4.68594f;
        }

        public static void IsveskKazkaEkrane()
        {
            Console.WriteLine("Isvedu kazka");
        }


    }
}