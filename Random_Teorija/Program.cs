using System.Text;

namespace Random_Teorija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //konstroja, nauja random
            Random random = new Random();

            int aRandomNumber = random.Next(); // bet koks skaicius nuo 0 iki Int32.Maxvalue

            int bRandomNumber = random.Next(4); // bus sugeneruota 0,1,2 arba 3

            int cRandomNumber = random.Next(1, 4); // bus sugeneruota 1,2 arba 3

            double dRandomNumber = random.NextDouble(); // >= 0.0 iki <1.0

            Console.WriteLine(RandomMetodasDebuginimas()); // neimanoma testuoti

            Console.WriteLine(RandomMetodas(random)); // testuojamas

            Random rnd = new Random();

            //atsitiktinis parinkimas is array ir list
            Console.WriteLine("______________________");
            Console.WriteLine("atsitiktinis parinkimas is array ir list");
            string[] maleNames = { "Artur", "Justas", "Oleg" };
            List<string> femaleNames = new List<string> { "Olga", "DIana","Bira"};
            
            int mIndex = rnd.Next(maleNames.Length);
            Console.WriteLine("Vyriskas vardas yra " + maleNames[mIndex]);

            int fIndex = rnd.Next(femaleNames.Count);
            Console.WriteLine("Moteriskas vardas yra " + femaleNames[fIndex]);

            // atsitiktine reiksme is dictionary
            Console.WriteLine("______________________");
            Console.WriteLine("atsitiktinis parinkimas is dictionary");
            Dictionary<string, int> miestai = new Dictionary<string, int>()
            {
                {"Vilnius", 11235 },
                {"Kaunas", 22548 },
                {"Klaipeda", 21368 },
                {"Siauliai", 254875 }
            };
            List<string> miestaiKeys = new List<string>(miestai.Keys);
            int miestasIndex = rnd.Next(miestaiKeys.Count);
            string miestasKey = miestaiKeys[miestasIndex];
            int gyventojuSkaicius = miestai[miestasKey];
            Console.WriteLine($"mieste {miestasKey} gyventoju {gyventojuSkaicius}");

            //atsitiktinio zodzio parinkimas tekste
            Console.WriteLine("______________________");
            Console.WriteLine("atsitiktinio zodzio parinkimas tekste");
            string lorem = "Lorem idmdhg kdlkdo fkfiidf ldldhsgh";
            string[] loremArray = lorem.Split(' ');
            string zodis = loremArray[rnd.Next(loremArray.Length)];
            Console.WriteLine(zodis);

            //atsitiktiniu raidziu generavimas
            Console.WriteLine("______________________");
            Console.WriteLine("atsitiktiniu raidziu generavimas");
            int raidziuKiekis = 10;
            int A = 65;
            int Z = 90;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < raidziuKiekis; i++)
            {
                sb.Append((char)rnd.Next(A, Z + 1));
            }
            Console.WriteLine(sb.ToString());

            //atsitiktinis bool generavimas
            Console.WriteLine("______________________");
            Console.WriteLine("atsitiktinis bool generavimas");
            bool arTrue = rnd.Next(2) == 1;
            Console.WriteLine(arTrue);

            //atsitiktinius kaiciu generavimas
            Console.WriteLine("______________________");
            Console.WriteLine("atsitiktinius skaiciu generavimas");
            int skaicius = 10;
            int min = 0;
            int max = 10;
            int[] skaiciai = new int[skaicius];
            for (int i = 0; i < skaicius; i++)
            {
               skaiciai[i] = rnd.Next(min, max + 1);
            }
            Console.WriteLine(string.Join(" ", skaiciai));

            //atsitiktiniu skaiciu surasymas i lista
            Console.WriteLine("______________________");
            Console.WriteLine("atsitiktiniu skaiciu surasymas i lista");
            List<int> listas = new List<int>();
            for (int i = 0; i < skaicius; i++)
            {
                listas.Add(rnd.Next(min, max + 1));
            }
            Console.WriteLine("listas " + string.Join(" ", listas));

            //atsitiktinis rikiavimas (Shuffle)
            Console.WriteLine("______________________");
            Console.WriteLine("atsitiktinis rikiavimas (Shuffle)");
            List<string> skaiciai1 = new List<string> { "1","2","3","4"};
            skaiciai1.Sort((a,b) => rnd.Next(10) - rnd.Next(10));
            Console.WriteLine(string.Join(" ", skaiciai1));

            // geresnis random generavimas (System.Security.Cryptography.RandomNumberGenerator)
            Console.WriteLine("______________________");
            Console.WriteLine("geresnis random generavimas");
            for (int i = 0; i < 20; i++)
            {
                var randNumber = System.Security.Cryptography.RandomNumberGenerator.GetInt32(0, 10);
                Console.WriteLine(" " + randNumber);
            }
            Console.WriteLine();

            // guid
            Console.WriteLine("______________________");
            Console.WriteLine("GUID");
            Guid uid = Guid.NewGuid();
            Console.WriteLine(uid);

            updateGuid(uid);
            Console.WriteLine(uid);

            void updateGuid(Guid tmpGuid)
            {
                tmpGuid = Guid.NewGuid();
            }

            bool isGuidParsed = Guid.TryParse("76bdd2a3-02f8-464f-a302-e73592e69131", out var guid2); //guid parsinimas
            Console.WriteLine(guid2);

            //geresnis atsitiktinis rikiavimas
            Console.WriteLine("______________________");
            Console.WriteLine("geresnis atsitiktinis rikiavimas (Shuffle)");
            List<string> skaiciai2 = new List<string> { "1", "2", "3", "4" };
            skaiciai2.Sort((a,b) => Guid.NewGuid().CompareTo(Guid.NewGuid()));
            Console.WriteLine(String.Join(", ", skaiciai2));

        }

        static string RandomMetodasDebuginimas()
        {
            Random random = new Random();
            return random.Next(1, 10) > 5 ? "dideja" : "mazeja";
        }

        static string RandomMetodas(Random random)
        {
            
            return random.Next(1, 10) > 5 ? "dideja" : "mazeja";
        }
    }
}