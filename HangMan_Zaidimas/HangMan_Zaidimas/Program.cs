using System.Text;

namespace HangMan_Zaidimas
{
    
    
        internal class Program
        {


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
                            Kita(7);
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


                //string randomZodis = RandomZodis(kita);
                //string pasleptasZodis = PasleptasZodis(randomZodis);
                //var suliginimas = pasleptasZodis.ToUpper();


                Random rand = new Random();
                string randomZodis = kita[rand.Next(0, kita.Length)];
                string suliginimas = randomZodis.ToUpper();
                StringBuilder pasleptasZodis = new StringBuilder(randomZodis.Length);
                for (int i = 0; i < randomZodis.Length; i++)
                {
                    pasleptasZodis.Append('-');
                }

                List<char> atspetosRaides = new List<char>();
                List<char> neraRaidziuZodije = new List<char>();
                bool win = false;
                int atskleistosRaides = 0;
                char spejimas;
                string input;
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
                    if (suliginimas.Contains(spejimas))  // darant atskirus metodus, neieina i sita if
                    {
                        atspetosRaides.Add(spejimas);

                        for (int i = 0; i < randomZodis.Length; i++)
                        {
                            if (suliginimas[i] == spejimas)
                            {

                                pasleptasZodis[i] = randomZodis[i];  // darant metodus meta klaida "not null"
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

                if (win)
                {
                    Console.WriteLine($"Jus atspejot!");

                }
                else
                {
                    Console.WriteLine($"Jus pralaimejot! \n Zodis yra {randomZodis}");
                }
                Console.ReadKey();
            }




            private static void Valstybes()
            {
                string[] valstybes = { "Vilnius", "Kaunas", "Taurage", "Klaipeda", "Telsiai", "Utena" };

            }

            private static void LietuvosMiestai()
            {
                string[] lietuvosMiestai = { "Vilnius", "Kaunas", "Taurage", "Klaipeda", "Telsiai", "Utena" };
                ;
            }

            private static void Vardai()
            {
                string[] vardai = { "Artur", "Romuald", "Juozas", "Dalia", "Diana", "Tadas" };

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

            //public static string RandomPasleptasZodis(string[] sarasas) // podelit na dve casti random v otdelnyi metod i skrytost v otdelnyi metod
            //{
            //    Random rand = new Random();
            //    string randomZodis = sarasas[rand.Next(sarasas.Length)];
            //    StringBuilder pasleptasZodis = new StringBuilder(randomZodis.Length);
            //    for (int i = 0; i < randomZodis.Length; i++)
            //    {
            //        pasleptasZodis.Append('-');
            //    }
            //    return pasleptasZodis.ToString();
            //}

            public static string RandomZodis(string[] sarasas)
            {
                Random rand = new Random();
                string randomZodis = sarasas[rand.Next(0, sarasas.Length)];
                return randomZodis;
            }

            public static string PasleptasZodis(string zodis)
            {
                StringBuilder pasleptasZodis = new StringBuilder(zodis.Length);
                for (int i = 0; i < zodis.Length; i++)
                {
                    pasleptasZodis.Append('-');
                }
                return pasleptasZodis.ToString();
            }
        }
    }

