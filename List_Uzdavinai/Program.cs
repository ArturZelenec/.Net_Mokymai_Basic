namespace List_Uzdavinai
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //DIDŽIAUSIAS SĄRAŠE
            // Duotas vienmatis sveikų skaičių sąrašas.
            // Parašykite programą, kuri suranda didžiausią skaičių saraše
            // { 5, 1, 6, 8, 7 }
            //    rezultatas: 8

            // DIDESNIS UŽ DIDŽIAUSIĄ
            //Duotas vienmatis sveikų skaičių sąrašas. 
            //Parašykite programą, kuri į sąrašo galą prideda vienetu didesnį skaičių už patį didžiausią
            //pvz:
            //     { 5, 1, 6, 8, 7 }
            // rezultatas: 5, 1, 6, 8, 7, 9

            //DidziausisSarase(new List<int> { 5, 1, 6, 8, 7 });
            

        }

        public static List<int> DidesnisUzDidziausia(List<int> sarasas)
        {
            List<int> list = new List<int>();
            list.AddRange(sarasas);
            var max = DidziausisSarase_Sort(list);
            sarasas.Add(max + 1);
            return sarasas;
        }

        public static int DidziausisSarase(List<int> sarasas)
        {
            for (int i = 0; i < sarasas.Count; i++)
            {
                Console.WriteLine(sarasas.Max());
                break;
            }
            return sarasas.Max();
        }

        public static int DidziausisSarase_Sort(List<int> sarasas)
        {
            sarasas.Sort();
            return sarasas[sarasas.Count - 1];
        }


    }
}