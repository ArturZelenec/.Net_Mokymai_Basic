namespace String_Kintamieji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String (tekstini) tipo kintamieji");
            string kintamasis = "Hello World";
            Console.WriteLine(kintamasis);
            var stringKintamasis = "belekoks tekstas";
            string tuscias = ""; // tuscias stringas
            string nulas = null; // nieko nera
            string laisvaerdve = "       "; // tuscia erdve (white space)

            string konkatinacija = stringKintamasis + kintamasis;
            Console.WriteLine(konkatinacija);
            string kompasicija = string.Format("{0}", stringKintamasis);
            string interpoliacija = $"{stringKintamasis}";
            Console.WriteLine(interpoliacija);

            kintamasis = "tekstas belekoks";
            Console.WriteLine(kintamasis);
        }
    }
}