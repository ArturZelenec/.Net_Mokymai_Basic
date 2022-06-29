namespace Method_Uzdavinai
{
    public class Program
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


            //Console.WriteLine("iveskite pirma skaiciu");
            //bool valid = Int32.TryParse(Console.ReadLine(), out var num1);
            //Console.WriteLine("iveskite antra skaiciu");
            //bool valid2 = Int32.TryParse(Console.ReadLine(), out var num2);
            //if (valid && valid2)
            //{
            //    Skaiciai(num1, num2);
            //}
            //else
            //{
            //    Console.WriteLine("eror");
            //}

            //------------------------------------------------

            //Parašykite programą kurioje vienas metodas.
            //- Naudotojo paprašome įvesti betkokį tekstą Main metode.
            //-Metodas į ekraną išveda teksto ilgį be tarpų įvesto teksto pradžioje ir gale
            //Pvz:
            //> Iveskite teksta:
            //_ ' as mokausi '
            //> Teksto ilgis yra: 10

            //Console.WriteLine("iveskite  teksta su tarpais");
            //BeTarpu(Console.ReadLine());

            //_________________________________________________

            //Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą.
            //- Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais
            //-Įvestas tekstas metodui perduodamas per parametrus ir grąžina žodžių kiekį
            //- Main metode į ekraną išveskite žodžių kiekį
            // Pvz:
            // > Iveskite teksta:
            //_ as mokausi programuoti
            //> Zodziu kiekis yra: 3

            //Console.WriteLine("iveskite  teksta su tarpais");
            //BetKoksTekstas(Console.ReadLine());

            //________________________________________________

            //parašykite programą kurioje vienas metodas.
            //  - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
            // -Metodas grąžina tarpų kiekį teksto gale
            // - Main į ekraną išveda rezultatą
            //  Pvz:
            // > Iveskite teksta:
            //_ ' as mokausi      '
            //> Gale yra tarpų: 6

            //Console.WriteLine("iveskite  teksta su tarpais");
            //Tarpugale(Console.ReadLine());

            //_________________________________________________

            //Parašykite programą kurioje vienas metodas.
            //- Naudotojo paprašome įvesti betkokį tekstą Main metode. 
            // -Metodas grąžina tarpų kiekį teksto pradžioje
            // - Main į ekraną išveda rezultatą
            // Pvz:
            //> Iveskite teksta:
            //_ ' as mokausi      '
            //> Pradžioje yra tarpų: 1

            //Console.WriteLine("iveskite  teksta su tarpais");
            //TarpuPriekije(Console.ReadLine());

            //_____________________________________________________

            //Parašykite programą kurioje vienas metodas.
            //- Naudotojo paprašome įvesti betkokį tekstą Main metode. 
            //-Metodas grąžina dvi reikšmes pirmoji -tarpų kiekį teksto pradžioje, antroji - tarpų kiekį teksto gale
            // <hint> naudoti out 
            // -Main į ekraną išveda rezultatą
            // Pvz:
            //> Iveskite teksta: as

            //_ ' as mokausi      '
            //> Pradžioje yra tarpų: 1
            //> Gale yra tarpų: 6

            //Console.WriteLine("iveskite  teksta su tarpais");

            //var priekije = TarpuPriekijeIrGale(Console.ReadLine(), out int tarpai);
            //var gale = tarpai;
            //Console.WriteLine($"tarpai priekije {priekije}  tarpai gale {gale}");

            //-----------------------------------------------------------

            //Parašykite programą kurioje yra vienas metodas. 
            //-Main metode Naudotojo paprašome įvesti betkokį tekstą su tarpais
            // -Įvestas teikstas kaip argumentas perduodamas metodui.Metodas grąžina 'a' raidžių kiekį tekste.
            // - Main metode į ekraną išveskite metodo darbo rezultatą
            //Pvz: 
            // > Iveskite teksta:
            //_ as mokausi programuoti
            //> 'a' raidžių kiekis yra: 3
        }


        public static int RaidziuKiekis(string text)
        {
            

        }



        public static int TarpuPriekijeIrGale( string text, out int t)
        {
            t = text.Length - text.TrimEnd().Length;
            return text.Length - text.TrimStart().Length;
            
        }


        public static int TarpuPriekije(string text)
        {
            var text1 = text.Length;
            text = text.TrimStart();
            return text1 - text.Length;
        }



        public static int Tarpugale(string text)
        {
            var text1 = text.Length;
            text = text.TrimEnd();
            return text1 - text.Length;
        }



        public static int BetKoksTekstas(string text)
        {
            string[] textMass;
            textMass = text.Split(' ');
            
           return textMass.Length;
          
        }


        public static int BeTarpu(string text)
        {
            text = text.Trim();
            return text.Length;
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