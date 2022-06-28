namespace Method_Uzdavinai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parašykite programą kurioje yra 2 metodai.
            //- Pirmas metodas į konsolę išveda "Sveiki visi"
            //- Antrtas metodas į konsolę išveda "Linkiu jums geros dienos"

            //Sveiki();
            //Linkiu();

            //Parašykite programą kurioje yra 2 metodai.
            //-
            //-Pirmas metodas naudotojo paprašo įvesti savo vardą konsolę išveda "Labas tai_kas_ivesta" ir grąžina tai kas ivesta.
            //- Antras metodas į konsolę išveda "Linkiu jums tai_kas_ivesta geros dienos"
            //Pvz:
            //> Iveskite savo Varda:
            //_ Petras
            //> Labas Petras
            //> Linkiu jums Petras geros dienos

            //string name = IveskiteVarda("Artur");
            //GerosDienos(name);

            //Parašykite programą kurioje yra vienas metodas priimantis du skaitmeninio tipo argumentus.
            //- Main metode naudotojo paprašome įvesti 2 skaičius ir perduokite juos metodui.
            //N.B.būtina validacija
            //-Į ekraną išveskite argumentų matematinę sumą.
            //Pvz:
            //> Iveskite pirmą skaičių:
            //_ 15
            //> Iveskite antrą skaičių:
            //_ 16
            //> Rezultatas: 31

            Console.WriteLine("iveskite pirma skaiciu");
            bool valid = Int32.TryParse(Console.ReadLine(), out var num1);
            Console.WriteLine("iveskite antra skaiciu");
            bool valid2 = Int32.TryParse(Console.ReadLine(), out var num2);
            if (valid && valid2)
            {
                Skaiciai(num1, num2);
            }
            else
            {
                Console.WriteLine("eror");
            }

        }

        public static void Skaiciai(int sk1, int sk2)
        {
           
            int sum = sk1 + sk2;
            Console.WriteLine($"Rezultatas {sum}");


        }





        public static void Sveiki()
        {
            Console.WriteLine("Sveiki visi");
        }
        public static void Linkiu()
        {
            Console.WriteLine("Linkiu geros dienos");
        }

        public static string IveskiteVarda(string vardas)
        {
            Console.WriteLine("Iveskite varda");
            vardas = Console.ReadLine();
          
            return vardas;
        }
        public static void GerosDienos(string name)
        {
            Console.WriteLine($"Linkiu {IveskiteVarda(name)} geros dienos");
        }
    }
}