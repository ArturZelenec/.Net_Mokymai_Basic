namespace If_Switch_Uzdaviniai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PARAŠYTI PROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI
            //EGZAMINO PAŽYMĮ.IŠVESTI:
            //0 - 4: NEPATEKINAMAI
            //5: SILPNAI
            //6: PATENKINAMAI
            //7: VIDUTINIŠKAI
            //8: GERAI
            //9: LABAI GERAI
            //10: PUIKIAI
            //Console.WriteLine("Iveskite EGZAMINO PAŽYMĮ");
            //var pazymis = Convert.ToInt32(Console.ReadLine());
            //if (pazymis >= 0 && pazymis <= 4)
            //{
            //    Console.WriteLine("NEPATEKINAMAI");
            //}
            //else if (pazymis == 5)
            //{
            //    Console.WriteLine("SILPNAI");
            //}
            //else if (pazymis == 6)
            //{
            //    Console.WriteLine("PATENKINAMAI");
            //}
            //else if (pazymis == 7)
            //{
            //    Console.WriteLine("VIDUTINIŠKAI");
            //}
            //else if (pazymis == 8)
            //{
            //    Console.WriteLine("GERAI");
            //}
            //else if (pazymis == 9)
            //{
            //    Console.WriteLine("LABAI GERAI");
            //}
            //else if (pazymis == 10)
            //{
            //    Console.WriteLine("PUIKIAI");
            //}
            //else
            //{
            //    Console.WriteLine("wrong pazymis");
            //}
            //Console.WriteLine("_______________________");
            //switch (pazymis)
            //{
            //    case 0:
            //    case 1:
            //    case 2:
            //    case 3:
            //    case 4:
            //        Console.WriteLine("NEPATEKINAMAI");
            //        break;
            //    case 5:
            //        Console.WriteLine("SILPNAI");
            //        break;
            //    case 6:
            //        Console.WriteLine("PATENKINAMAI");
            //        break;
            //    case 7:
            //        Console.WriteLine("VIDUTINIŠKAI");
            //        break;
            //    case 8:
            //        Console.WriteLine("GERAI");
            //        break;
            //    case 9:
            //        Console.WriteLine("LABAI GERAI");
            //        break;
            //    case 10:
            //        Console.WriteLine("PUIKIAI");
            //        break;
            //    default:
            //        Console.WriteLine("wrong");
            //        break;
            //}
            //Console.WriteLine("__________________________");
            //var isvedamasRezultatas = pazymis switch
            //{
            //    0 or 2 or 3 or 4 => "NEPATEKINAMAI",
            //    5 => "SILPNAI",
            //    6 => "PATENKINAMAI",
            //    7 => "VIDUTINIŠKAI",
            //    8 => "GERAI",
            //    9 => "LABAI GERAI",
            //    10 => "PUIKIAI",

            //    _ => "wrong"
            //};
            //Console.WriteLine(isvedamasRezultatas);


            //**Nemokama kava**
            //Aprašykite int kintamajį kuriame nurodysite kiek puodelių kavos perkama. (tarkim 7)
            //Kas 3 puodelis nemokamas. Paskaičiuokite ir išveskite į ekraną ar pirkėjui priklauso nemokama kava
            //-Pavyzdžio atsakymas: "pirkėjui priklauso 2 nemokami puodeliai"
            //- Alternatyvus atsakymas: "Pirkėjui nepriklauso nemokama kava"

            //int kava = Convert.ToInt32(Console.ReadLine());
            //int sk = kava / 3 ;
            //if (kava>2)
            //{
            //    Console.WriteLine($" priklauso {sk} puodeliai");
            //}
            //else   
            //{
            //    Console.WriteLine("pirkejui nepriklauso");
            //}

            //**Piešingi skaičiai**
            //Naudotojas įveda betkokius 4 sveikus skaicius(tarkim 5; 15; -25; 0;)
            //-Parašykite programą kuri į ekraną išves neigiamą/ teigiamą skaičiaus reikšmę
            //-Pavyzdžio atsakymas 5-> - 5; 15-> - 15; -25-> 25; 0->N / A;
            //Console.WriteLine("iveskite 4 skaicius");
            //var sk1 = Convert.ToInt32(Console.ReadLine());
            //var sk2 = Convert.ToInt32(Console.ReadLine());
            //var sk3 = Convert.ToInt32(Console.ReadLine());
            //var sk4 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(sk1 != 0 ? $"{sk1} -> {sk1 * -1}": $"0=> N/A"); // jeigu [sk1] nelygus nuliui(true) ivykdom kaire puse [$"{sk1} -> {sk1 * -1}"] iki dvitaskio, jeigu lygus nuliu(false) vykdom desne puse [$"0=> N/A"]
            //Console.WriteLine(sk2 != 0 ? $"{sk2} -> {sk2 * -1}" : $"0=> N/A");
            //Console.WriteLine(sk3 != 0 ? $"{sk3} -> {sk3 * -1}" : $"0=> N/A");
            //Console.WriteLine(sk4 != 0 ? $"{sk4} -> {sk4 * -1}" : $"0=> N/A");

            //ŽAIDIMAS ATSPĖK SKAIČIŲ
            //- ĮHARDKODINAMAS BETKOKS SKAIČIUS NUO 1 IKI 20
            //- NAUDOTOJAS 6 KARTUS PRAŠOMAS ĮVESTI SKAIČIŲ NUO 1 IKI 20
            //- JEI NAUDOTOJAS ĮVEDĖ TEISINGAI - IŠVEDAMAS SVEIKINIMAS "TEISINGAI" IR PROGRAMA STABDOMA
            //- JEI NAUDOTOJAS ĮVEDĖ PER MAŽĄ SKAIČIŲ - IŠVEDAMAS PRANEŠIMAS "SKAIČIUS YRA DIDESNIS"
            //- JEI NAUDOTOJAS ĮVEDĖ PER DIDELĮ SKAIČIŲ - IŠVEDAMAS PRANEŠIMAS "SKAIČIUS YRA MAŽESNIS"
            //nutraukiant programos vykdymą Environment.Exit(0) ar pan. naudoti negalima. Naudoti if.

            //int skaicius = 12;
            //Console.WriteLine("iveskite skaiciu");
            //int input = Convert.ToInt32(Console.ReadLine());
            //if (skaicius != input)
            //{
            //    if (skaicius > input)
            //    {
            //        Console.WriteLine("skaicius didesnis");
            //    }
            //    else
            //    {
            //        Console.WriteLine("skaicius mazesnis");
            //    }

            //    input = Convert.ToInt32(Console.ReadLine());
            //    if (skaicius != input)
            //    {
            //        if (skaicius > input)
            //        {
            //            Console.WriteLine("skaicius didesnis");
            //        }
            //        else
            //        {
            //            Console.WriteLine("skaicius mazesnis");
            //        }
            //        input = Convert.ToInt32(Console.ReadLine());
            //        if (skaicius != input)
            //        {
            //            if (skaicius > input)
            //            {
            //                Console.WriteLine("skaicius didesnis");
            //            }
            //            else
            //            {
            //                Console.WriteLine("skaicius mazesnis");
            //            }
            //            input = Convert.ToInt32(Console.ReadLine());
            //            if (skaicius != input)
            //            {
            //                if (skaicius > input)
            //                {
            //                    Console.WriteLine("skaicius didesnis");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("skaicius mazesnis");
            //                }
            //                input = Convert.ToInt32(Console.ReadLine());
            //                if (skaicius != input)
            //                {
            //                    if (skaicius > input)
            //                    {
            //                        Console.WriteLine("skaicius didesnis");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("skaicius mazesnis");
            //                    }
            //                }
            //                input = Convert.ToInt32(Console.ReadLine());
            //                if (skaicius != input)
            //                {
            //                    if (skaicius > input)
            //                    {
            //                        Console.WriteLine("skaicius didesnis");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("skaicius mazesnis");
            //                    }

            //                }
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"atspejot {skaicius}");
            //}


            //*SKAIČIUOTUVAS *
            //Paprašykite naudotojo įvesti du skaičius ir matematinę operaciją(+, -, *arba / )
            //- Parašykite programą kuri į ekraną išves skaičių rezultatą
            //- naudokite if
            //-naudokite switch

            //Console.WriteLine("iveskite du skaicius");
            //Console.WriteLine("iveskite matematine operacija");
            //double sk1 = Convert.ToDouble(Console.ReadLine());
            //double sk2 = Convert.ToDouble(Console.ReadLine());
            //string operacija = Console.ReadLine();
            //if (operacija == "+")
            //{
            //    Console.WriteLine($"suma = {sk1 + sk2}");
            //}
            //if (operacija == "-")
            //{
            //    Console.WriteLine($"skirtumas = {sk1 - sk2}");
            //}
            //if (operacija == "/")
            //{
            //    Console.WriteLine($"dalyba = {sk1 / sk2}");
            //}
            //if (operacija == "*")
            //{
            //    Console.WriteLine($"sandauga = {sk1 * sk2}");
            //}
            //Console.WriteLine("--------------------------------------");
            //switch (operacija)
            //{
            //    case "+":
            //        Console.WriteLine($"suma = {sk1 + sk2}");
            //        break;
            //    case "-":
            //        Console.WriteLine($"skirtumas = {sk1 - sk2}");
            //        break;
            //    case "/":
            //        Console.WriteLine($"dalyba = {sk1 / sk2}");
            //        break;
            //    case "*":
            //        Console.WriteLine($"sandauga = {sk1 * sk2}");
            //        break;


            //}

            //*Trys draugai *
            //-Sukurti metodą, kuris paprašytų vartotojo įvesti tris jo draugų vardus bei kiekvieno amžių.
            //- Nuskaičius duomenis atskirose eilutėse atspausdinti draugo vardą ir amžių.
            //-Atspausdinti draugų amžiaus vidurkį
            //- Surasti ir atspausdinti jauniausią draugą(vardą ir amžių).
            //-Surasti ir atspausdinti vyriausią draugą(vardą ir amžių).
            //< Hint > ieškant jauniausio, seniausio naudoti if sąlygos sakinius ir naudoti tik elementus ir
            //konstrukcijas kurias iki šiol išėjome.
            //Console.WriteLine("iveskite varda");
            //var vardas1 = Console.ReadLine();
            //Console.WriteLine("iveskite amziu");
            //int amzius1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("iveskite varda");
            //var vardas2 = Console.ReadLine();
            //Console.WriteLine("iveskite amziu");
            //int amzius2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("iveskite varda");
            //var vardas3 = Console.ReadLine();
            //Console.WriteLine("iveskite amziu");
            //int amzius3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"vardas {vardas1}: Amzius {amzius1}");
            //Console.WriteLine($"vardas {vardas2}: Amzius {amzius2}");
            //Console.WriteLine($"vardas {vardas3}: Amzius {amzius3}");
            //Console.WriteLine($"amziu vidurkis = {(amzius1+amzius2+amzius3)/3}");
            //if (amzius1<amzius2&&amzius1<amzius3)
            //{
            //    Console.WriteLine($" jauniausis {amzius1} vardas {vardas1}");
            //}
            //else if (amzius2 < amzius1 && amzius2 < amzius3)
            //{
            //    Console.WriteLine($" jauniausis {amzius2} vardas {vardas2}");
            //}
            //else if (amzius3 < amzius1 && amzius3 < amzius2)
            //{
            //    Console.WriteLine($" jauniausis {amzius3} vardas {vardas3}");
            //}

            //if (amzius1 > amzius2 && amzius1 > amzius3)
            //{
            //    Console.WriteLine($" viresnis {amzius1} vardas {vardas1}");
            //}
            //else if (amzius2 > amzius1 && amzius2 > amzius3)
            //{
            //    Console.WriteLine($" viresnis {amzius2} vardas {vardas2}");
            //}
            //else if (amzius3 > amzius1 && amzius3 > amzius2)
            //{
            //    Console.WriteLine($" viresnis {amzius3} vardas {vardas3}");
            //}


            //**Kalėdų sausainiai * *
            //-Paprašykite vartotojo įvesti betkokias 4 datas(tarkim 2013 - 12 - 24, 2020 - 12 - 22, 3000 - 12 - 24, 2021 - 03 - 03)
            //- Parašykite programą kuri nustato ar tarp įvestų datų yra kalėdos(gruodžio 24).
            //- Ir jei yra kalėdų data, išveda -"Jums priklauso nemokami kalėdiniai sausainiai"
            //- Jei nėra išveda -"Palaukite kalėdų"
            //Pavyzdzio atsakymas: "Jums priklauso nemokami kalėdų sausainiai"
            //< Hint > metodai data.Month ir data.Day

            var metai1 = DateTime.Parse(Console.ReadLine());
            var metai2 = DateTime.Parse(Console.ReadLine());
            var metai3 = DateTime.Parse(Console.ReadLine());
            var metai4 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Ivesta {metai1.ToShortDateString()}, {metai2.ToShortDateString()}, {metai3}, {metai4}");
            if (metai1.Month ==12 && metai1.Day == 24)
            {
                Console.WriteLine("Jums priklauso nemokami sausainiai");
            }
            else if (metai2.Month == 12 && metai2.Day == 24)
            {
                Console.WriteLine("jums priklauso nemokami saldainiai");
            }
            else if (metai3.Month == 12 && metai3.Day == 24)
            {
                Console.WriteLine("jums priklauso nemokami saldainiai");
            }
            else if (metai4.Month == 12 && metai4.Day == 24)
            {
                Console.WriteLine("jums priklauso nemokami saldainiai");
            }
            else
            {
                Console.WriteLine("palaukite kaledu");
            }
        }
    }
}