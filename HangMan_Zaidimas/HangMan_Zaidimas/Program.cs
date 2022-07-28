using System.Text;

namespace HangMan_Zaidimas
{


    internal class Program
    {
        public static List<char> atspetosRaides = new List<char>();
        public static List<char> neraRaidziuZodije = new List<char>();
        public static bool win = false;
        public static int atskleistosRaides = 0;
        public static char spejimas;
        public static string input;
        public static int spejimai = 7;

        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
                string meniuPasirinkimas = Console.ReadLine();
                switch (meniuPasirinkimas)
                {
                    case "1":
                        Vardai();
                        break;
                    case "2":
                        LietuvosMiestai();
                        break;
                    case "3":
                        Valstybes();
                        break;
                    case "4":
                        Kita(spejimai);
                        break;
                    default:
                        Console.WriteLine("Nera tokios kategorijos");
                        break;
                }
            }
        }
        private static void Kita(int spejimai)
        {
            string[] kita = { "Abrakadabra", "Filamas", "Programuotojas", "Alus", "Lapas", "Kompiuteris" };


            string randomZodis = RandomZodis(kita);
            //string pasleptasZodis = PasleptasZodis(randomZodis);
            //var suliginimas = pasleptasZodis.ToUpper();

            string suliginimas = randomZodis.ToUpper();
            StringBuilder pasleptasZodis = new StringBuilder(randomZodis.Length);
            for (int i = 0; i < randomZodis.Length; i++)
            {
                pasleptasZodis.Append('-');
            }

            while (!win && spejimai > 0) // sukam while kol nelaimesim arba kol nebaigsis ejimai
            {
                Console.Write("Iveskite raide:");
                input = Console.ReadLine().ToUpper(); 
                spejimas = input[0];

                if (atspetosRaides.Contains(spejimas))
                {
                    Console.WriteLine($"Atspejot \"{spejimas}\" anksciau");
                    continue;
                }
                else if (neraRaidziuZodije.Contains(spejimas))
                {
                    Console.WriteLine($"Jau bandita raide \"{spejimas}\"");
                    continue;
                }
                if (suliginimas.Contains(spejimas))  // darant atskirus metodus, neieina i sita if
                {
                    atspetosRaides.Add(spejimas);

                    for (int i = 0; i < randomZodis.Length; i++)
                    {
                        if (suliginimas[i] == spejimas)
                        {
                            //var zodis = pasleptasZodis;
                            //var rezultatas = zodis.Substring(0, i - 1) + randomZodis[i] + zodis.Substring(i, zodis.Length);
                            pasleptasZodis[i] = randomZodis[i];  // darant metodus meta klaida "not null"
                            atskleistosRaides++;
                        }
                        //if (suliginimas[i] == spejimas)
                        //{
                        //    pasleptasZodis = pasleptasZodis.Substring(0, i - 1) + randomZodis[i] + pasleptasZodis.Substring(i + 1, randomZodis.Length);
                        //    atskleistosRaides++;
                        //}
                    }
                    if (atskleistosRaides == randomZodis.Length)
                        win = true;
                }
                else
                {
                    neraRaidziuZodije.Add(spejimas);
                    Console.WriteLine($"\"{spejimas}\" nera sitame zodije");
                    spejimai--;
                    Console.WriteLine($"{spejimai} bandimu liko");
                }
                Console.WriteLine(pasleptasZodis.ToString());
            }
            Rezultatas(win, randomZodis);
            Console.ReadKey();
            Reset();
            Console.Clear();
        }
        private static void Valstybes()
        {
            string[] valstybes = { "Vilnius", "Kaunas", "Taurage", "Klaipeda", "Telsiai", "Utena" };
            string randomZodis = RandomZodis(valstybes);
            string suliginimas = randomZodis.ToUpper();
            StringBuilder pasleptasZodis = new StringBuilder(randomZodis.Length);
            for (int i = 0; i < randomZodis.Length; i++)
            {
                pasleptasZodis.Append('-');
            }
            while (!win && spejimai > 0)
            {
                Console.Write("Iveskite raide:");
                input = Console.ReadLine().ToUpper();
                spejimas = input[0];

                if (atspetosRaides.Contains(spejimas))
                {
                    Console.WriteLine($"Atspejot \"{spejimas}\" anksciau");
                    continue;
                }
                else if (neraRaidziuZodije.Contains(spejimas))
                {
                    Console.WriteLine($"Jau bandita raide \"{spejimas}\"");
                    continue;
                }
                if (suliginimas.Contains(spejimas))  
                {
                    atspetosRaides.Add(spejimas);

                    for (int i = 0; i < randomZodis.Length; i++)
                    {
                        if (suliginimas[i] == spejimas)
                        {
                            pasleptasZodis[i] = randomZodis[i];  
                            atskleistosRaides++;
                        }
                    }
                    if (atskleistosRaides == randomZodis.Length)
                        win = true;
                }
                else
                {
                    neraRaidziuZodije.Add(spejimas);
                    Console.WriteLine($"\"{spejimas}\" nera sitame zodije");
                    spejimai--;
                    Console.WriteLine($"{spejimai} bandimu liko");
                }
                Console.WriteLine(pasleptasZodis.ToString());
            }
            Rezultatas(win, randomZodis);
            Console.ReadKey();
            Reset();
            Console.Clear();

        }

        private static void LietuvosMiestai()
        {
            string[] lietuvosMiestai = { "Vilnius", "Kaunas", "Taurage", "Klaipeda", "Telsiai", "Utena" };
            string randomZodis = RandomZodis(lietuvosMiestai);
            string suliginimas = randomZodis.ToUpper();
            StringBuilder pasleptasZodis = new StringBuilder(randomZodis.Length);
            for (int i = 0; i < randomZodis.Length; i++)
            {
                pasleptasZodis.Append('-');
            }
            while (!win && spejimai > 0)
            {
                Console.Write("Iveskite raide:");
                input = Console.ReadLine().ToUpper();
                spejimas = input[0];
                if (atspetosRaides.Contains(spejimas))
                {
                    Console.WriteLine($"Atspejot \"{spejimas}\" anksciau");
                    continue;
                }
                else if (neraRaidziuZodije.Contains(spejimas))
                {
                    Console.WriteLine($"Jau bandita raide \"{spejimas}\"");
                    continue;
                }
                if (suliginimas.Contains(spejimas))
                {
                    atspetosRaides.Add(spejimas);

                    for (int i = 0; i < randomZodis.Length; i++)
                    {
                        if (suliginimas[i] == spejimas)
                        {
                            pasleptasZodis[i] = randomZodis[i];
                            atskleistosRaides++;
                        }
                    }
                    if (atskleistosRaides == randomZodis.Length)
                        win = true;
                }
                else
                {
                    neraRaidziuZodije.Add(spejimas);
                    Console.WriteLine($"\"{spejimas}\" nera sitame zodije");
                    spejimai--;
                    Console.WriteLine($"{spejimai} bandimu liko");
                }
                Console.WriteLine(pasleptasZodis.ToString());
            }
            Rezultatas(win, randomZodis);
            Console.ReadKey();
            Reset();
            Console.Clear();
        }

        private static void Vardai()
        {
            string[] vardai = { "Artur", "Romuald", "Juozas", "Dalia", "Diana", "Tadas" };
            string randomZodis = RandomZodis(vardai);
            string suliginimas = randomZodis.ToUpper();
            StringBuilder pasleptasZodis = new StringBuilder(randomZodis.Length);
            for (int i = 0; i < randomZodis.Length; i++)
            {
                pasleptasZodis.Append('-');
            }
            while (!win && spejimai > 0)
            {
                Console.Write("Iveskite raide:");
                input = Console.ReadLine().ToUpper();
                spejimas = input[0];

                if (atspetosRaides.Contains(spejimas))
                {
                    Console.WriteLine($"Atspejot \"{spejimas}\" anksciau");
                    continue;
                }
                else if (neraRaidziuZodije.Contains(spejimas))
                {
                    Console.WriteLine($"Jau bandita raide \"{spejimas}\"");
                    continue;
                }
                if (suliginimas.Contains(spejimas))
                {
                    atspetosRaides.Add(spejimas);

                    for (int i = 0; i < randomZodis.Length; i++)
                    {
                        if (suliginimas[i] == spejimas)
                        {
                            pasleptasZodis[i] = randomZodis[i] ;
                            atskleistosRaides++;
                        }
                    }
                    if (atskleistosRaides == randomZodis.Length)
                        win = true;
                }
                else
                {
                    neraRaidziuZodije.Add(spejimas);
                    Console.WriteLine($"\"{spejimas}\" nera sitame zodije");
                    spejimai--;
                    Console.WriteLine($"{spejimai} bandimu liko");
                }
                Console.WriteLine(pasleptasZodis.ToString());
            }
            Rezultatas(win, randomZodis);
            Console.ReadKey();
            Reset();
            Console.Clear();
        }

        static void Menu()
        {
            Console.WriteLine("Pasirinkite tema:"
                            + "\n-----------------------------------"
                            + "\n1. VARDAI"
                            + "\n2. LIETUVOS MIESTAI"
                            + "\n3. VALSTYBES"
                            + "\n4. KITA");
        }
        public static string RandomZodis(string[] sarasas)
        {
            Random rand = new Random();
            string randomZodis = sarasas[rand.Next(0, sarasas.Length)];
            return randomZodis;
        }
        public static void Rezultatas(bool veiksmas, string zodis)
        {

            if (veiksmas)
            {
                Console.WriteLine($"Jus atspejot!");

            }
            else
            {
                Console.WriteLine($"Jus pralaimejot! \n Zodis yra {zodis}");
            }

        }
        public static string PasleptasZodis(string zodis)
        {
            StringBuilder pasleptasZodis = new StringBuilder(zodis.Length);
            for (int i = 0; i < zodis.Length; i++)
            {
                pasleptasZodis.Append('-');
            }
            return zodis.ToString();
        }

        public static void Reset()
        {
            atskleistosRaides = 0;
            spejimas = '\0';
            win = false;
            atspetosRaides = new List<char>();
            neraRaidziuZodije = new List<char>();
            input = string.Empty;
            spejimai = 7;
        }
    }
}

