using System.Text;

namespace Hangman_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
                string input = Console.ReadLine();
                switch (input)
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
                        Kita();
                        break;
                    default:
                        Console.WriteLine("Nera tokios kategorijos");
                        break;
                }
            }
        }

        private static void Kita()
        {
            string[] kita = { "Abrakadabra", "Filamas", "Programuotojas", "Alus", "Lapas", "Kompiuteris" };
            RandomPasleptasZodis(kita);
            List<char> atspetosRaides = new List<char>();
            List<char> neatspetosRaides = new List<char>();
        }

        private static void Valstybes()
        {
            string[] valstybes = { "Vilnius", "Kaunas", "Taurage", "Klaipeda", "Telsiai", "Utena" };
            RandomPasleptasZodis(valstybes);
        }

        private static void LietuvosMiestai()
        {
            string[] lietuvosMiestai = { "Vilnius", "Kaunas", "Taurage", "Klaipeda", "Telsiai", "Utena" };
            RandomPasleptasZodis(lietuvosMiestai);
        }

        private static void Vardai()
        {
            string[] vardai = { "Artur", "Romuald", "Juozas", "Dalia", "Diana", "Tadas" };
            RandomPasleptasZodis(vardai);
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

        public static string RandomPasleptasZodis(string[] sarasas)
        {
            Random rand = new Random();
            string randomZodis = sarasas[rand.Next(sarasas.Length)];
            StringBuilder pasleptasZodis = new StringBuilder(randomZodis.Length);
            for (int i = 0; i < randomZodis.Length; i++)
            {
                pasleptasZodis.Append('-');
            }
            return pasleptasZodis.ToString();
        }
    }
}