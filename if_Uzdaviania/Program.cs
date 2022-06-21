namespace if_Uzdaviania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PARAŠYTI PROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI SKAIČIŲ.
            //-JEIGU SKAIČIUS YRA LYGINIS IŠVESTI Į EKRANĄ "SKAIČIUS YRA LYGINIS"
            //- JEIGU SKAIČIUS YRA NEIGIAMAS "SKAIČIUS YRA NEIGIAMAS"
            //- KITU ATVEJU IŠVESTI PATĮ SKAIČIŲ
            //Console.WriteLine("Hello, World!");
            //double skaicius = Convert.ToDouble(Console.ReadLine());
            //if (skaicius % 2==0)
            //{
            //    Console.WriteLine("skaicius lyginis");
            //}
            //if (skaicius<0)
            //{
            //    Console.WriteLine("skaicius neigiams");
            //}
            //if (skaicius % 2 !=0 && skaicius >0)
            //{
            //    Console.WriteLine($"Ivestas skaicius {skaicius}");
            //}

            //PARAŠYTI PROGRAMĄ, KURI PAPRAŠO
            //VARTOTOJO ĮVESTI GRUPĖS NARIŲ KIEKĮ.
            //JEI NARIŲ KIEKIS LYGUS 1 PROGRAMA IŠVEDA
            //„TAI SOLO ATLIKĖJAS“, JEI NARIŲ KIEKIS 2--„TAI
            //DUETAS“, JEI NARIŲ KIEKIS DAUGIAU NEI 2 BET
            //MAŽIAU NEI 10 ––„TAI ANSAMBLIS“, JEI
            //DAUGIAU NEI 10 ––„TAI KAMERINIS
            //ANSAMBLIS“.
            double nariuSkaicius = Convert.ToDouble(Console.ReadLine());
            if (nariuSkaicius ==1)
            {
                Console.WriteLine("TAI SOLO ATLIKĖJAS");
            }
            else if (nariuSkaicius == 2)
            {
                Console.WriteLine("TAI Duetas");
            }
            else if (nariuSkaicius > 2 && nariuSkaicius<10)
            {
                Console.WriteLine("TAI ANSAMBLIS");
            }
            else if (nariuSkaicius >  10)
            {
                Console.WriteLine("TAI KAMERINIS");
            }
            else
            {
                Console.WriteLine("wrong");
            }
            //PARAŠYTI PROGRAMĄ, KURI
            //PAPRAŠO VARTOTOJO ĮVESTI
            //IŠDIRBTAS VALANDAS.
            //JEI VALANDŲ YRA MAŽIAU NEI 160,
            //PROGRAMA TURI PARODYTI, KIEK
            //DAR REIKIA IŠDIRBTI, JEI LYGIAI 160,
            //PARODO, KAD IŠDIRBTAS PILNAS
            //ETATAS, JEI DAUGIAU PARODO
            //KIEK YRA VIRŠVALANDŽIŲ.
            //EI VARTOTOJAS PADARO ĮVEDIMO
            //KLAIDĄ PRANEŠTI IR UŽBAIGTI
            //DARBĄ

            Console.WriteLine("iveskite isdirbtas valandas");
            //var input = Convert.ToInt32(Console.ReadLine());
            bool arGerasSkaicius = uint.TryParse(Console.ReadLine(), out uint input);
            if (arGerasSkaicius)
            {
                if (input < 160)
                {
                    Console.WriteLine($"  DAR REIKIA IŠDIRBTI  {160 - input}");
                }
                else if (input == 160)
                {
                    Console.WriteLine("  IŠDIRBTAS PILNAS ETATAS");
                }
                else
                {
                    Console.WriteLine($"  VIRSVALANDZIU YRA  {input - 160}");
                }
            }
            else
            {
                Console.WriteLine("  KLAIDA");
            }


        }
    }
}