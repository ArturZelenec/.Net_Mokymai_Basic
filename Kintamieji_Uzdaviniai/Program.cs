namespace Kintamieji_Uzdaviniai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mokyklosPavadinimas = "CodeAcademy";
            string kursoPavadinimas = ".Net";
            int studentuSkaicius = 19;
            DateTime siosDienosData = DateTime.Now;
            Console.WriteLine($"\nMOKYKLOS PAVADINIMAS: {mokyklosPavadinimas} \nKURSO PAVADINIMAS: {kursoPavadinimas} \nSTUDENTU SKAICIUS: {studentuSkaicius} \nDATA: {siosDienosData}");


            DateTime kursoPradzia = new DateTime(2022, 05, 30);
            DateTime kursoPabaiga = new DateTime(2022, 12, 01);
            var visoDienu = (siosDienosData - kursoPradzia) / 7;
            var darboDienu = visoDienu * 5;
            Console.WriteLine($"darboDienu {darboDienu.Days}");


            string text = "text";
            int number = 1;
            bool logika = true;
            Console.WriteLine($"{text} {number} {logika}");


            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            Console.WriteLine("{0} {1} {2}", num1, num2, num3);
            Console.WriteLine($"{num1} {num2} {num3}");
            Console.WriteLine(num1 + " " + num2 + " " + num3);
        }
    }
}