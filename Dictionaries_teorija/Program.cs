namespace Dictionaries_teorija
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DictionaryPavyzdziai();
            //AtspausdintiZodyna();
                 

        }

        public static void DictionaryPavyzdziai()
        {
            Dictionary<string, float> kainuZodinas = new Dictionary<string, float>();
            var kainu = new Dictionary<string, float>();
            Dictionary<string, int> miestai = new Dictionary<string, int>
            {
                {"Vilnius", 7},
                {"Kaunas", 6},
                {"Siauliai", 8},
                {"Jonava", 6}

            };

            Dictionary<string, string> zodzioReiksmes = new Dictionary<string, string>()
            {
                {"Macnus", "asdsd dfdfad fffdsdf" },
                {"Unaravas", "asdsd dfdfad fffdsdf" },
                {"Cecckavot", "asdsd dfdfad fffdsdf" },
                {"Kartas", "asdsd dfdfad fffdsdf" }

            };

            Dictionary<int, string> varduZodynas = new Dictionary<int, string>()
            {
                {1, "asdsd dfdfad fffdsdf" },
                {5, "asdsd dfdfad fffdsdf" },
                {3, "asdsd dfdfad fffdsdf" },
                {4, "asdsd dfdfad fffdsdf" }

            };

            Console.WriteLine($"{miestai["Vilnius"]} {miestai["Kaunas"]}");

            //zodyno pildymas
            miestai.Add("Palanga", 7);
            miestai["Klaipeda"] = 6;

            //foreach (var miestas in miestai)
            //{
            //    Console.WriteLine(miestas);
            //}

            //foreach (var miestas in miestai)
            //{
            //    Console.WriteLine(miestas.Key);
            //}

            //foreach (var miestas in miestai)
            //{
            //    Console.WriteLine(miestas.Value);
            //}


            ////zodyno iraso validavimas
            //if (miestai.TryGetValue("Kaipeda", out int miestoSkaicius))
            //{
            //    Console.WriteLine($"Klaipeda: {miestoSkaicius}");
            //}
            //else
            //{
            //    Console.WriteLine("neradome iraso");
            //}

            //if (!miestai.ContainsKey("Klaipeda"))
            //{
            //    Console.WriteLine("neradome iraso");

            //}
            //else
            //{
            //    Console.WriteLine($"Klaipeda: {miestoSkaicius}");
            //}

            ////zodyno ValueColection
            //Dictionary<string, int>.ValueCollection miestuReiksmes = miestai.Values;
            //foreach (var item in miestuReiksmes)
            //{
            //    Console.WriteLine($"Reiksme: {item}");

            //}

            //Dictionary<string, int>.KeyCollection miestuRaktai = miestai.Keys;
            //foreach (var item in miestuReiksmes)
            //{
            //    Console.WriteLine($"Reiksme: {item}");

            //}

            ////zodyno irasu isemimas
            //varduZodynas.Remove(2);



            //Dictionary<string, List<int>> zaidejuTaskuZodynas = new Dictionary<string, List<int>>()
            //{
            //    { "Ieva", new List<int>() { 9, 8, 10 } },
            //    { "Audrius", new List<int>() { 8, 10, 8, 10, 10 } },
            //    { "Veronika", new List<int>() { 10, 10, 10 } },
            //};

            //foreach (var zaidejas in zaidejuTaskuZodynas)
            //{
            //    Console.Write(zaidejas.Key + " ");
            //    foreach (var taskai in zaidejas.Value)
            //    {
            //        Console.Write(taskai + " ");
            //    }
            //    Console.WriteLine();
            //}



        }
        //KLASES DARBAS 1. ## Parasykite metoda, kuris priima sveikaji skaiciu kaip parametra ir sukuria nauja zodyna - raktas:x, reiksme:x*x formoje. Pvz: Ivestis-5 1:1 2:4 3:9 4:16 5:25

        public static void AtspausdintiZodyna()
        {
            var zodynas = Zodynas(5);
            foreach (var item in zodynas)
            {
                Console.WriteLine(item);
            }
        }
        public static Dictionary<int,int>  Zodynas(int skaicius)
        {
            Dictionary<int,int> zodynas = new Dictionary<int,int>();
            for (int i = 1; i < skaicius; i++)
            {
                zodynas.Add(i, i * i);
            }

            return zodynas;
        }
    }
}