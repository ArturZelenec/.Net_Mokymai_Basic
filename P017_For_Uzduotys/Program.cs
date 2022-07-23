using System.Text;

namespace P017_For_Uzduotys
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UŽDUOTIS 1.
            //Sukurti metodą ReadIntNumber, 
            // kuris paprašo vartotojo įvesti sveikąjį skaičių ir tą skaičių grąžina.
            //Jeigu vartotojas įveda blogą skaičių, tai programa turi informuoti, kad
            //įvestas blogas skaičius ir prašyti įvesti vėl.Kol vartotojas
            // neįveda tinkamo skaičiaus metodas turi vis prašyti įvesti.
            //(Hint)->Panaudoti int.TryParse metodą ir while ciklą.


            //UŽDUOTIS 2.
            //Sukurti metodą IntegerToBinary, 
            //kuris gautą teigiamą sveikąjį skaičių paverstų į dvejetainį formatą.Reikšmę grąžintų kaip simbolių eilutę.
            // 2-- > 10
            // 7-- > 111
            // 45-- > 101101

            //UŽDUOTIS 3.
            //Sukurti metodą SkaiciuPiramide, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
            //jeigu įveda netinkamą skaičių
            //prašo įvesti vėl, kol įves tinkamą Programa turi atspausdinti atitinkamą lygiašonį trikampį.
            //7
            //77
            //777
            //7777
            //77777
            //777777
            //7777777
            //777777
            //77777
            //7777
            //777
            //77
            //7


            //3.Sukurti skaiciuotuva.Ijungus programa mes turetume gauti pranesima “1.Nauja operacija 2.Testi su rezultatu 3.Iseiti”. Pasirinkus 1 turetu ismesti ”
            //1.Sudetis
            //2.Atimtis
            //3.Daugyba
            //4.Dalyba”
            //Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius, o gale isvesti rezultata ant ekrano ir uzklausti ar naudotojas nori atlikti nauja operacija ar testis u rezultatu.Sudeties pvz:
            //“1
            //15
            //45
            //Rezultatas: 60
            //1.Nauja operacija 2.Testi su rezultatu 3.Iseiti”
            //Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS. Pasirinkus 3 programa turetu issijungti.Visa kita turetu veikti tokiu pat budu.
            //BONUS1: Iskelkite operacijas i metodus
            //BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius.Pvz: dalyba is nulio, neteisingu ivesciu prevencija pvz kada tikimasi gauti skaiciu, bet gaunamas char arba string.
            //BONUS3: Parasyti unit testus uztikrinant operaciju veikima
            //BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacijas




            //PirmaUzduotis();
            //SkaiciuTrikampis();
            //SkaiciuPiramide();
            Programa();


        }

        public static void Programa()
        {
            MainMeniu();
            string inputMain = Console.ReadLine();
            switch (inputMain)
            {
                case "1":
                    SubMeniu();
                    string inputSubMain = Console.ReadLine();
                    Console.WriteLine("Iveskite du skaicius");
                    int sk = Convert.ToInt32(Console.ReadLine());
                    int sk2 = Convert.ToInt32(Console.ReadLine());
                    switch (inputSubMain)
                    {
                        case "1":
                            Console.WriteLine($"Suma = {Sudetis(sk,sk2)}");
                            MainMeniu();
                            string inputArTesti = Console.ReadLine();
                            switch (inputArTesti)
                            {
                                case "1":

                                    break;
                                case "2":

                                    break;

                                case "3":

                                    break;
                                default:
                                    break;
                            }

                            break;
                        case "2":
                            Console.WriteLine($"Skirtumas = {Atimtis(sk, sk2)}");
                            break;
                        case "3":
                            Console.WriteLine(Daugyba(sk, sk2));
                            break;
                        case "4":
                            Console.WriteLine(Dalyba(sk, sk2));
                            break;
                        default:

                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        public static int Dalyba(int a, int b)
        {
            return a / b;
        }

        public static int Daugyba(int a, int b)
        {
            return a * b;
        }
        public static int Atimtis(int a, int b)
        {
            return a - b;
        }

        public static int Sudetis(int a, int b)
        {
            return a + b;
        }

       

        public static void SubMeniu()
        {
            Console.WriteLine("[1] - Sudetis; [2] - Atimtis; [3] - Daugyba; [4] - Dalyba");
        }

        public static void MainMeniu()
        {
            Console.WriteLine("[1] - Nauja operacija; [2] - Testi su rezultatu; [3] - Iseiti;");
        }

        









        public static void PirmaUzduotis()
        {
            Console.WriteLine("Iveskite skaiciu");
            bool arSkaiciusTeisingas = false;
            string input1 = "";
            while (!arSkaiciusTeisingas)
            {
                input1 = Console.ReadLine();
                arSkaiciusTeisingas = int.TryParse(input1, out _);
                Console.WriteLine("neteisingas skaicius");
            }
            Console.WriteLine($"ivestas skaicius {input1}");
        }

        //public static int IntegerToBinary(int sk)
        //{
        //    string binSk = "";
        //    while (sk>0)
        //    {
        //        binSk = sk % 2 + binSk;
        //        sk = sk / 2;
        //    }

        //    return binSk;
        //}




        private static void SkaiciuTrikampis()
        {
            
            while (true)
            {
                Console.WriteLine("Iveskite skaiciu");
                StringBuilder sb = new StringBuilder();
               
                var input1 = Console.ReadLine();
                var skaiciusBool = int.TryParse(input1, out int skaicius);
                if (skaicius <= 9 && skaicius >=1)
                {

                    for (int i = 0; i < skaicius; i++)
                    {
                        sb.Append(skaicius);
                        Console.WriteLine(sb.ToString());
                    }
                    break;
                }
                Console.WriteLine("neteisingas skaicius");

            }
        }



        private static void SkaiciuPiramide()
        {

            while (true)
            {
                Console.WriteLine("Iveskite skaiciu");
                StringBuilder sb = new StringBuilder();

                var input1 = Console.ReadLine();
                var skaiciusBool = int.TryParse(input1, out int skaicius);
                if (skaicius <= 9 && skaicius >= 1)
                {

                    for (int i = 0; i < skaicius; i++)
                    {
                        sb.Append(skaicius);
                        Console.WriteLine(sb.ToString());
                    }
                    for (int i = skaicius; i >= 1; i--)
                    {
                        sb.Remove(0,1);
                        Console.WriteLine(sb.ToString());
                    }

                    break;
                }
                Console.WriteLine("neteisingas skaicius");

            }
        }





    }
}