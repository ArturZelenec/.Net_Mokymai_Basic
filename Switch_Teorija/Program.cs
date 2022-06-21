namespace Switch_Teorija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, switch!");
            Console.WriteLine("Iveskite meniu punkta");
            int menuChoise = Convert.ToInt32(Console.ReadLine());
            switch (menuChoise)
            {
                case 1:
                    Console.WriteLine("vartuotojas pasirinko 1");
                    break;
                case 2:
                    Console.WriteLine("vartuotojas pasirinko 2");
                    break;
                case 3:
                    Console.WriteLine("vartuotojas pasirinok 3");
                    break;
                case 4:
                    Console.WriteLine("vartuotojas pasrinko 4");
                    break;
                default:
                    Console.WriteLine("wrong");
                    break;
            }

            Console.WriteLine("_______________________________");
            //switch expression
            var isvedamasRezultatas = menuChoise switch
            {
                1 => "vartuotojas pasirinko 1",
                2 => "vartuotojas pasirinko 2",
                3 => "vartuotojas pasirinko 3",
                _ => "vartuotojas nieko nepasirinko"

            };
            Console.WriteLine(isvedamasRezultatas);

            Console.WriteLine("_____________________________");
            switch (menuChoise)
            {
                case 1:
                case 2:
                    Console.WriteLine("Vartuotojas pasirinko 1 arba 2");
                    break;
            }
        }
    }
}