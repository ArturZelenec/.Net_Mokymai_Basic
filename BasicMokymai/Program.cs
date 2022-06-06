namespace BasicMokymai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Artur");

            Console.Write("išvedimas ");
            Console.Write("vienoje ");
            Console.Write("eiluteje ");
            Console.WriteLine();
            Console.Write("tekstas kitoje eiluteje");
            Console.WriteLine("tekstas ");

            Console.WriteLine("_______________________");
            Console.WriteLine("išvedima "+ "vienoje "+ "eilueteje ");
            Console.WriteLine("{0} {1} {2}", "išvedimas", "vienoje", "eiluteje");
            Console.WriteLine($"{"išvedimas"} {"vienoje"} {"eiluteje"}");
            Console.WriteLine("_______________________");

            Console.WriteLine("tekstas idedamas i \"kabutes\"");
            Console.WriteLine("tekstas \nidedamas \ni \nkabutes");
            Console.WriteLine("tekstas \tidedamas \ti \tkabutes");





        }
    }
}