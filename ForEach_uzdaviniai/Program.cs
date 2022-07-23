using System.Text;

namespace ForEach_uzdaviniai
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");



            //KLASES DARBAS 1. ## Parasykite programa, kuri apskaiciuotu duoto integer saraso vidurki.
            List<int> list = new List<int>() { 1, 5, 8, 9, 7, 15, 9 };
            var rezultatas = Vidurkis(list);

            //KLASES DARBAS 2. ## Parasykite metoda, kuris grazina ar skaicius neigiamas ar teigiamas masyve.
            List<int> skaiciai = new List<int>() { 1, 5, -8, 9, 0, 8, -5 }; 
            List<string> rez = TikrintiSkaiciausTeigiamuma(skaiciai); 
            foreach (string skaiciausTeigiamumas in rez) 
            { 
                Console.WriteLine($"Ar skaicius teigiamas: {skaiciausTeigiamumas}"); 
            }

            //KLASES DARBAS 3. ## Parasykite metoda, kuris apskaiciuos kiek jums reikes sumoketi GPM nuo duoto imoku saraso. Sio uzdavinio GPM: 15%
            int gpm = 15;
            List<double> imokos = new List<double>() { 100,150,188.88,153.87,68.68 };
            var suma = ApskaiciotiGPM(imokos,gpm);
            Console.WriteLine($"Rezultatas {suma}");

            /// <summary>        
            /// ///  Parašyti metodą IstrauktiSkaicius, kuris priima teksta, bet grazina tik skaicius egzistuojancius paciame tekste.        
            /// ///  Isgavus teksta programa turetu naudoti naujai sukurta SurikiuotiSkaiciusIsTeksto metoda, kuris priima "string skaiciaiTekste" ir surikiuoja skaicius        
            /// ///  didejimo tvarka. SurikiuotiSkaiciusIsTeksto privalo panaudoti foreach, kad suformuotumet nauja List<int>:        
            /// ///  PVZ: Ivedame: 1sd512sd5. Programa be rusiavimo grazina mums: 15125. Programa su rusiavimu grazina mums: 11255        
            /// /// </summary>
            /// 


            ///  Parašyti metodą IsmetytiZodzius, kuris priima sakini, bet grazina nauja zodziu List sudaryta tik is zodziu, kurie ilgesni arba lygus 5 raides ir yra surikiuoti abeceles tvarka.
            ///  Tada parasykite metoda, kuris priima 2 zodziu sarasus, juos sujungia i viena kolekcija naudojant ciklus ir atspausdina ekrane.
            ///  PRIMINIMAS: Kad isskirti string i atskirus zodzius naudokite pavyzdinisString.Split(' ')
            ///  PVZ: Ivedame: "Labas as esu Kodelskis ir labai megstu programuoti". 
            ///  Programa be rusiavimo grazina mums: as esu ir Labas Kodelskis labai megstu programuoti
            ///  Programa su rusiavimu grazina mums: as esu ir Kodelskis labai Labas megstu programuoti

            string sakinys = "Labas as esu Kodelskis ir labai megstu programuoti";
            var sarasas = IsmetytiZodzius(sakinys);
            foreach (var item in sarasas)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            

            List<string> s1 = new List<string>() { "Labas", "as", "esu", "Kodelskis", "ir", "labai", "megstu", "programuoti" };
            List<string> s2 = new List<string>() { "as", "esu" };
            var s3 = Sujungimas(s1, s2);
            foreach (var sujungimas in s3)
            {
                Console.Write($"{sujungimas} ");
            }

            //Parašyti metodą SukonstruotiKalade(rusis, kortos).Sis metodas turi sukonstruoti kalade is duotu 2 string sarasu.        
                ///  Po to parasyti metoda, kuris surikiuoja jusu kalade pagal abeceles tvarka.        
                ///  
                ///  Ir galiausiai parasyti, kad jusu visas kortas atspausdintu ekrane.        
                ///  PRIMINIMAS:         
                ///  Kortu rusys        /*
            /*         * "Sirdziu",
             *         "Bugnu",
             *         "Vynu",
             *         "Kryziu",
             *         *
             *         * Kortos
             *         *          
             *         * "Tuzas",
             *         "Dviake",
             *         "Triake",
             *         "Keturake",
             *         "Penkake",
             *         "Sesake",
             *         "Septynake",
             *         "Astuonake",
             *         "Devynakės",
             *         "Desimtake",
             *         "Valetas",
             *         "Dama",
             *         "Karalius",
             *         */
        }
        

        public static List<string> SukonstruotiKalade(List<string> rusys, List<string> kortos)
        {
            List<string> kalade = new List<string>();

            foreach (var rusis in rusys) //forech foreche kekvenai rusiai priskiria korta
            {
                foreach (var korta in kortos)
                {
                    kalade.Add($"{rusis} {korta}");
                }
            }
            
            return kalade;
        }

        public static List<string> Surusioti(List<string> kalade)
        {
            kalade.Sort();
            return kalade;
        }

        public static void Atspasdinti(List<string> kalade)
        {
            foreach (var vardas in kalade)  
            {
               
                    Console.WriteLine($"Vardas {vardas}");
               
            }
        }


        public static List<string> IsmetytiZodzius(string sakinys)
        {
            List<string> sarasas = new List<string>();
            string[] isskirtiString = sakinys.Split(' ');

            foreach (string item in isskirtiString)
            {
                if (item.Length >= 5)
                {
                    sarasas.Add(item);
                }
            }
            sarasas.Sort();
            return sarasas;
        }

        

        public static List<string> Sujungimas(List<string> list1, List<string> list2)
        {
            List<string> bendrasListas = new List<string>();

            
                bendrasListas.AddRange(list1);
           
                bendrasListas.AddRange(list2);
            
           

            return bendrasListas;
        }



        private static int SkaiciausTikrinimas(string? tekstas) => int.TryParse(tekstas, out int skaicius) ? skaicius : 0;

        public static string IstrauktiSkaicius(string tekstas)
        {
            var skaiciaiTekste = new StringBuilder();
            foreach (var simbolis in tekstas)
            {
                if (char.IsDigit(simbolis))
                {
                    skaiciaiTekste.Append(simbolis);
                }
            }
            return skaiciaiTekste.ToString();
        }

        public static List<int> SurikiotiSkaicius(string skaiciaiTekste)
        {
            var skaiciai = new List<int>();
            foreach (var simbolis in skaiciaiTekste)
            {
                skaiciai.Add(SkaiciausTikrinimas(simbolis.ToString()));
            }
            skaiciai.Sort();

            return skaiciai;
        }
        



        public static double ApskaiciotiGPM(List<double> imokos, int gpm)
        {
            var galutinisMokestis = 0d;

            foreach (var imoka in imokos)
            {
                galutinisMokestis = galutinisMokestis + imoka;
            }
            return galutinisMokestis + (gpm / 100d);
        }

        public static List<string> TikrintiSkaiciausTeigiamuma(List<int> skaiciai)
        {
            var skaiciuTeigiamumas = new List<string>();

            foreach (var skaicius in skaiciai)
            {
                if (skaicius>=0)
                {
                    skaiciuTeigiamumas.Add("Teigiamas");
                }
                else
                {
                    skaiciuTeigiamumas.Add("Neigiamas");
                }
            }
            return skaiciuTeigiamumas;
        }
        
        public static double Vidurkis(List<int> skaiciai)
        {
            double vidurkis = 0;
            foreach (var skaicius in skaiciai)
            {
                vidurkis = vidurkis + skaicius;
                Console.WriteLine($"Skaicius {skaicius} Vidurkis {vidurkis}");
            }
            return vidurkis/skaiciai.Count;
        }
    }
}