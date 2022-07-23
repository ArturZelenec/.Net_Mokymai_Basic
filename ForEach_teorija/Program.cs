namespace ForEach_teorija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] taskuMasyvas = new int[10];
            taskuMasyvas[0] = 1;
            foreach (var taskai in taskuMasyvas)
            {
                Console.WriteLine($"{taskai} Naujas elementas");
            }

            string[] masinos = new string[] {"BMW", "AUDI", "VW"};
            foreach (var masina in masinos)
            {
                Console.WriteLine(masina);
            }

            List<int> amziai = new List<int> { 19, 20, 22 };
            foreach (var amzius in amziai)
            {
                Console.WriteLine($"Amzius {amzius}");
            }

            List<string> vardai = new List<string> { "Ieva", "Vardenis", "Edgaras" };
            foreach (var vardas in vardai)
            {
                Console.WriteLine($"Vardas {vardas}");

            }
            
            foreach (var vardas in vardai)  //foras fore
            {
                foreach (var amzius in amziai)
                {
                    Console.WriteLine($"Vardas {vardas} Amzius {amzius}");
                }
            }

            var spalvos = new List<string>();
            spalvos.Add("Melyna");
            spalvos.Add("Raudona");
            spalvos.Add("Geltona");

            foreach (var spalva in spalvos)
            {
                Console.WriteLine($"Spalva {spalva}");

            }

        }
    }
}