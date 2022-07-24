namespace SuperSkaiciatuvas_Refacting
{
    public class Program
    {
        static double? result = null;
        static string input = "";
        static string input2 = "";
        static bool repeat = true;

        static Queue<string> moves = new();
        private static bool manual = false;

        static void Main(string[] args)
        {
            SuperSkaiciuotuvas(null);
        }

        public static void SuperSkaiciuotuvas(string? move)
        {
            if (move != null)
            {
                moves.Enqueue(move);
                manual = true;
                return;
            }

            Calculaitor();
        }

        private static void Calculaitor()
        {
            do
            {
                Console.WriteLine("[1] - Nauja operacija. [2] - Testi su rezultatu. [3] - Išeiti iš programos.");

                int veiksmas = Convert.ToInt32(GetInput());

                switch (veiksmas)
                {
                    case 1:
                        veiksmas = ChoiceMeniu();
                        if (veiksmas == 6)
                        {
                            
                            Console.WriteLine("Įveskite 1 skaičiu:");
                            input = GetInput();
                            result = Calculaitor(DoubleCheking(input), 0, veiksmas);
                        }
                        else
                        {
                            Console.WriteLine("Įveskite du skaičius:");
                            input = GetInput();
                            input2 = GetInput();
                            result = Calculaitor(DoubleCheking(input),
                                DoubleCheking(input2), veiksmas);
                        }

                        break;
                    case 2:
                        veiksmas = ChoiceMeniu();

                        if (veiksmas != 6)
                        {
                            
                            Console.WriteLine("Įveskite skaičiu:");
                            input2 = GetInput();
                        }

                        result = Calculaitor((double)result, DoubleCheking(input2), veiksmas);
                        break;
                    case 3:
                        repeat = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }

                ;
                if (result != null)
                {
                    Console.WriteLine($"Rezultatas: {result}");
                }
            } while (repeat && (!manual || moves.Any()));
        }

        public static int ChoiceMeniu()
        {
            Console.WriteLine(@" 1. Sudetis
 2. Atimtis
 3. Daugyba
 4. Dalyba
 5. Laipsnio pakelimas
 6. Kvadratines šaknies traukimas");

            return Convert.ToInt32(GetInput());
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
            return sk1 * sk2;
        }
        public static double Dalyba(double sk1, double sk2)
        {
            return sk1 / sk2;
        }

        public static double? Calculaitor(double sk1, double sk2, int veiksmas)
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

        private static double DoubleCheking(string? tekstas) => double.TryParse(tekstas, out double skaicius) ? skaicius : 0;

        public static double Rezultatas()
        {
            if (moves.Any())
            {
                Calculaitor();
                moves.Clear();
            }

            return result ?? 0;
        }

        private static string GetInput()
        {
            return moves.Any() ? moves.Dequeue() : Console.ReadLine();
        }

        public static void Reset()
        {
            result = null;
        }
    }
}
