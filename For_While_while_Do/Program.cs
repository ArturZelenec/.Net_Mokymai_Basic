namespace For_While_while_Do
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------------------");
            int k = 0;
            while (k < 10)
            {
                k++;
                Console.WriteLine(k);

            }
            Console.WriteLine("---------------------------");
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }
            // WhileCikoPavyzdys();
            // WhileCikloZaidejuPavyzdys();
            //DoWhilePavyzdys();
            //SkaiciaiIki();
            //LyginiaiSkaiciai();
            SkaiciuSuma();
        }
        public static void WhileCikoPavyzdys()
        {
            int skaicius = 1;
            while (skaicius <= 10)
            {
                Console.WriteLine(skaicius);
                skaicius++;
            }
        }
        public static void WhileCikloZaidejuPavyzdys() 
        {
            int zaidejuSkaicius = 0;
            while (zaidejuSkaicius < 1 || zaidejuSkaicius > 10) //pastovia suks while, kol neatitiks salygai
            {
                Console.WriteLine("Kiek zaideju zais zaidima?");
                zaidejuSkaicius = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void DoWhilePavyzdys()
        {
            int zaidejuSkaicius = 0;
            do
            {
                Console.WriteLine("Kiek zaideju zais zaidima?");
                zaidejuSkaicius = Convert.ToInt32(Console.ReadLine());

            } while (zaidejuSkaicius < 1 || zaidejuSkaicius > 10);
        }

        /* 1.Paprašyti vartotojo įvesti bet kokį skaičių.         
         * Išvesti skaičių sumą nuo 1 iki įvesto skaičiaus.   */
        public static void SkaiciaiIki()
        {
            int suma = 0;
            Console.WriteLine(" įvesti bet kokį skaičių");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            while (skaicius > 0 )
            {
                Console.WriteLine($"Skaiciuojama suma: {suma}");
                suma += skaicius;
                Console.WriteLine($"i: {suma}\n");
                skaicius--;
            }   
            Console.WriteLine(suma);
        }

        /*         * Paprašyti vartotojo įvesti bet kokį skaičių.          
         *         * Išvesti visus lyginius skaičius nuo 0 iki pasirinkto skaičiaus,         
         *         * vienoje eilutėje per kablelį. Pvz.: 0, 2, 4, 6.....         */

        public static void LyginiaiSkaiciai()
        {
            int i = 0;
            int j = 0;
            Console.WriteLine(" įvesti bet kokį skaičių");
            i = Convert.ToInt32(Console.ReadLine());

            while (j <= i)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }
        }
        /*         * Parasyti programa kuri apskaiciuoja visu ivestu skaiciu suma,          
         *         * kurie buvo ivesti iki ivesto neigiamo skaiciaus         
         *         * PVZ         
         *         * 1,23,4,5,7,8,-1         */

        public static void SkaiciuSuma()
        {
            int suma = 0;
            int skaicius = 0;
            while (skaicius >=0)
            {
                Console.WriteLine(" įvesti bet kokį skaičių");
                suma = skaicius + suma;
                skaicius = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine(suma);
            
        }

    }
}