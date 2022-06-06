namespace BasicMokymai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Artur");

            //Console.Write("išvedimas ");
            //Console.Write("vienoje ");
            //Console.Write("eiluteje ");
            //Console.WriteLine();
            //Console.Write("tekstas kitoje eiluteje");
            //Console.WriteLine("tekstas ");

            //Console.WriteLine("_______________________");
            //Console.WriteLine("išvedima "+ "vienoje "+ "eilueteje ");
            //Console.WriteLine("{0} {1} {2}", "išvedimas", "vienoje", "eiluteje");
            //Console.WriteLine($"{"išvedimas"} {"vienoje"} {"eiluteje"}");
            //Console.WriteLine("_______________________");

            //Console.WriteLine("tekstas idedamas i \"kabutes\"");
            //Console.WriteLine("tekstas \nidedamas \ni \nkabutes");
            //Console.WriteLine("tekstas \tidedamas \ti \tkabutes");

            //Console.WriteLine("--------Press any key to continue-----------");
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine("Iveskite savo varda, o as ji pakartosiu");
            //Console.WriteLine($"Jusu vardas {Console.ReadLine()}");

            //Console.WriteLine("Iveskite raide");
            //var key = Console.ReadKey();
            //Console.WriteLine($"ivestas simbolis {key.KeyChar}");
            //Console.WriteLine($"ivestas simbolis {key.Key}");
            //Console.WriteLine($"ivestas simbolis {(int)key.KeyChar}");

            //Console.WriteLine("Iveskite savo varda, o as atspesiu pirma raide");
            //Console.WriteLine($"o stai mano pirma raide {Console.ReadLine()[0]}");

            //Console.WriteLine($"{"eilute1"}" +
            //    $"\n{"eilute2"}" +
            //    $"\n{"eilute3"}");

            //Console.WriteLine("{ 0:d }");


            Console.WriteLine("Hi Artur");
            Console.WriteLine("Iveskite savo varda, as pakartosiu");
            Console.WriteLine($"Jusu vardas {Console.ReadLine()}");
            Console.WriteLine("Iveskite savo varda, parodisu pirmos raides ASCII");
            Console.WriteLine($"stai mano pirmos raides ASCII {(int)Console.ReadLine()[0]}");
            Console.WriteLine("Iveskite varda paspauskit enter o poto iveskite skaiciu ir paspaskit enter kad suskaiciotu suma");
            Console.WriteLine($"Suma {(int)Console.ReadLine()[0] + Convert.ToInt32(Console.ReadLine())}");
            Console.ReadLine();
            Console.WriteLine("\t\t\tMeniu");
            Console.WriteLine("(1) Pirkti\n(2) Parduoti\n(3) Likuciai");
            Console.WriteLine("Iveskite skaiciu kad iskvesti meniu punkta");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Pirkti");
                    break;
                case "2":
                    Console.WriteLine("Parduoti");
                    break;
                case "3":
                    Console.WriteLine("Likuciai");
                    break;


            }





        }
    }
}