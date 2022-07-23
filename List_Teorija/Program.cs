namespace List_Teorija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, List!");

            List<string> stringSarasas = new List<string> { "zodis1", "zodis2" };

            List<int> intSarasas = new List<int> { 1, 2, 3, 4, 22, 55, 5 };

            List<string> automobilia = new List<string> { "Audi", "VW", "Opel", "Volvo" };
            automobilia.Add("BMW");// prideti i saraso gala
            Console.WriteLine(string.Join(", ", automobilia)); 
            automobilia[1] = "Subaru"; //pakeitem pagal indeksa
            Console.WriteLine(string.Join(", ", automobilia).TrimEnd());
            Console.WriteLine("automobiliu kiekis " + automobilia.Count);

            //Metodai

            //prideti i saraso gala
            automobilia.Add("Citroen"); 
            Console.WriteLine(string.Join(", ", automobilia));

            //prideti daug elementu i gala
            List<string> daugiauAutomobiliu = new List<string> { "BMW", "Mercedes", "Toyota" };
            automobilia.AddRange(daugiauAutomobiliu);
            Console.WriteLine(string.Join(", ", automobilia));

            //isvalyti lista
            automobilia.Clear();
            Console.WriteLine("isvalyta " + string.Join(", ", automobilia));

            //istrinti elementa
            automobilia.RemoveAt(4);
            Console.WriteLine(string.Join(", ", automobilia));

            //iterpimas
            automobilia.Insert(2, "BMW");
            Console.WriteLine(string.Join(", ", automobilia));

            //paieska
            bool arYraVW = automobilia.Contains("VW");
            Console.WriteLine("Ar yra VW" + arYraVW);
            bool arYraBMW = automobilia.Contains("BMW");
            Console.WriteLine("Ar yra NMW" + arYraBMW);

            //saraso rikiavimas
            automobilia.Sort();
            Console.WriteLine(string.Join(", ", automobilia));

            //saraso rikiavimas atgal
            automobilia.Sort((x, y) => y.CompareTo(x));
            Console.WriteLine(string.Join(", ", automobilia));

            intSarasas.Sort(); // into rikiavimas
            Console.WriteLine(string.Join(", ", automobilia));

            intSarasas.Sort((x, y) => y-x); // into rikiavimas atbuline tvarka
            Console.WriteLine(string.Join(", ", automobilia));

            string[] automobiliuMasivas = automobilia.ToArray(); // listas to array

            int[] intMasyvas = new int[] { 1, 2, 3, 4, 5, 6 };
            List<int> skaicia = intMasyvas.ToList(); // array to list

            //paieska
            automobilia.Add("VW");
            string pirmasKurYraV = automobilia.Find(x => x.Contains("V")); // suranda pirma su V raide
            Console.WriteLine("Pirmas automobilis kur yra V "+ pirmasKurYraV);

            List<string> visiKurYraV = automobilia.FindAll(x => x.Contains("V")); // suranda visus Su V
            Console.WriteLine(string.Join(", ", visiKurYraV));

            List<int> visiVirs6 = intSarasas.FindAll(x => x > 6);
            Console.WriteLine(string.Join(", ", visiVirs6));


        }
    }
}