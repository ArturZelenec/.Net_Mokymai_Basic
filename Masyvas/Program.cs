namespace Masyvas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Masyvai!");

            string[] dienos = new string[7] { "Pirmadienis", "Antradienis", "Treciadenis", "Ketvirtadienis", "Penktadienis", "Sestadienis", "Sekamadienis" };//deklarotas masivas

            string[] dienos2 = { "Pirmadienis", "Antradienis", "Treciadenis" }; // pats skaicioja kiek elementu bus masive

            int[] skaiciai; // tuscio masivo deklaravimas
            
            int[] skaiciai3 = new int[3];

            //reiksmiu irasymas
            skaiciai3[0] = 1;
            skaiciai3[1] = 2;
            skaiciai3[2] = 3;


            int[] intMasyvas = new int[] { 100, 95, 98, 99, 65, 11, 15, 114, 55 };
            


            for (int i = 0; i < dienos.Length; i++)
            {
                Console.WriteLine(dienos[i]);
            }

            //var s = RastiMaziausia(new int[] { 5, 3, 7, 6, 8, 7, 10 });
            //Console.WriteLine(s);
            //var b = RastiDidziausia(new int[] { 5, 3, 7, 6, 8, 7, 10 });
            //Console.WriteLine(b);
            //RikiuotiSkaiciusDidejimoTvarka(new int[] { 5, 3, 7, 6, 8, 7, 10 });
            //var v = RikiuotiSkaiciusDidejimoTvarka2(new int[] { 5, 1, 7, 6, 8, 7, 10 });



            //1. ## Rasti mažiausią ##
            //Duotas vienatis sveikų skaičių masyvas.
            //Parašykite programą, kuri į ekraną išves mažiausią skaičių masyve
            //{ 5, 3, 7, 6, 8, 7, 10 }
            //rezultatas: 3


            //2. ## Rasti didžiausią ##
            //Duotas vienatis sveikų skaičių masyvas.
            //Parašykite programą, kuri į ekraną išves mažiausią skaičių masyve
            //{ 5, 3, 7, 6, 8, 7, 10 }
            //rezultatas: 10

            // 3. ## RIKIUOTI SKAICIUS DIDĖJIMO TVARKA ##
            //Duotas vienmatis sveikų skaičių masyvas. 
            //Parašykite programą, kuri į ekraną išves surikiuotusskaičius nuo
            // mažiausio iki didžiausio
            //{ 5, 1, 7, 6, 8, 7, 10 }
            // rezultatas: 1, 5, 6, 7, 7, 8, 

            //4. ## RIKIUOTI TRIS RAIDES ##
            //  Parašykite programą kurioje vienas metodas.

            //   - Naudotojo paprašome įvesti 3 raides(atskirai).
            //    Būtina validacija kad įvesta tik vienas simbolis.
            //  - Metodas priima masyvą iš char ir grąžina masyvą iš char -surikiuotas raides pagal abecelę.
            //  Pvz: 
            //  > Iveskite pirma raide:
            //  _ C
            //  > Iveskite antra raide:
            //  _ D
            //  > Iveskite trecia raide:
            //  _ B
            //  > B, C, D

            //5. ## RIKIUOTI KETURIAS RAIDES ## 
            //Parašykite programą kurioje vienas metodas.
            //- Naudotojo paprašome įvesti 4 raides(atskirai).
            //  Būtina validacija kad įvesta tik vienas simbolis.
            //- Metodas priima masyvą iš string(su prielaidai kad kiekvienas string yra tik 1 raide)
            //  ir grąžina string(NB! ne masyvą) - surikiuotas raides pagal abecelę atskirtas -.
            //Pvz: 
            //> Iveskite pirma raide:
            //_ C
            //> Iveskite antra raide:
            //_ A
            //> Iveskite trecia raide:
            //_ B
            //> Iveskite ketvirtą raide:
            //_ E
            //> A - B - C - E

        }

        public static string RikiuotiKeturiasRaides(string[] raides)
        {
            char[] charMas = new char[raides.Length];
            for (int i = 0; i < raides.Length; i++)
            {
                charMas[i] = raides[i][0];
            }
            for (int i = 0; i < charMas.Length; i++)
            {
                for (int j = i + 1; j < charMas.Length; j++)
                {
                    if (charMas[i] > charMas[j])
                    {
                        char temp = charMas[i];
                        charMas[i] = charMas[j];
                        charMas[j] = temp;
                    }
                }

            }
            return string.Join("-", charMas);
        }

        public static char[] RikiuotiTrisRaides(char[] mas)
        {

            for(int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        char temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }

            }

            return mas;
        }

        public static void RikiuotiSkaiciusDidejimoTvarka(int[] skaiciai)
        {
            Array.Sort(skaiciai);
            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.WriteLine(skaiciai[i]);
            }
            
        }

        public static int[] RikiuotiSkaiciusDidejimoTvarka2(int[] skaiciai)
        {
            for (int i = 0; i < skaiciai.Length; i++)
            {
                for (int j = i+1; j < skaiciai.Length; j++)
                {
                    if (skaiciai[i] > skaiciai[j])
                    {
                        int temp = skaiciai[i];
                        skaiciai[i] = skaiciai[j];
                        skaiciai[j] = temp;
                    }
                }

            }
            Console.WriteLine(string.Join(", ", skaiciai));
            //for (int i = 0; i < skaiciai.Length; i++)  // tas pats kaip ir Console.WriteLine(string.Join(", ", skaiciai));
            //{
            //    Console.Write(skaiciai[i] + ", ");
            //}
            return skaiciai;

        }

        public static int RastiMaziausia(int[] skaiciai)
        {
            int maziausias = skaiciai[0];
            for (int i = 1; i < skaiciai.Length; i++)
            {
                if (maziausias > skaiciai[i])
                {
                    maziausias = skaiciai[i];
                }
            }
            return maziausias;
        }

        public static int RastiDidziausia(int[] skaiciai)
        {
            int didziausis = skaiciai[0];
            for (int i = 0; i < skaiciai.Length; i++)
            {
                if (didziausis < skaiciai[i])
                {
                    didziausis = skaiciai[i];
                }
            }
            return didziausis;
        }
    }
}