//PARAŠYTI PROGRAMĄ, KURIOJE VARTOTOJO PRAŠOMA ĮVESTI 2 SKAIČIUS.PROGRAMA TURI IŠVESTI
//• SKAIČIŲ SUMĄ
//• SKAIČIŲ SKIRTUMĄ
//• SANDAUGĄ
//• DALYBĄ

//Console.WriteLine("Iveskite du skaicius");
//double skaicius1 = Convert.ToDouble(Console.ReadLine());
//double skaicius2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"Suma = {skaicius1 + skaicius2}");
//Console.WriteLine($"Skirtumas = {skaicius1 / skaicius2}");
//Console.WriteLine($"Sandauga = {skaicius1 * skaicius2}");
//Console.WriteLine($"Dalyba = {skaicius1 / skaicius2}");

//PARAŠYTI PROGRAMĄ, 3 SKAIČIUS. PROGRAMA TURI IŠVESTI ŠIŲ SKAIČIŲ VIDURKĮ

//Console.WriteLine("Iveskite trys skaicius o as paskaiciosiu vidurki");
//double skaicius3 = Convert.ToDouble(Console.ReadLine());
//double skaicius4 = Convert.ToDouble(Console.ReadLine());
//double skaicius5 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"Vidurkis = {(skaicius3+skaicius4+skaicius5)/3}");

/*
sukurkite naują kintamajį long ir prskirkite didžiausią reikšmę.
sukurkite naują kintamajį short ir prskirkite didžiausią reikšmę
- padalinkite didesnį skaičių iš mažesnio
- iš rezultato atimkite maksimalų long skaičių
- ir pridėkite maksimalų int skaičių
*/

long longSkaicius = long.MaxValue;
short shortSkaicius = short.MaxValue;
Console.WriteLine($"{(longSkaicius/shortSkaicius) - longSkaicius + int.MaxValue}");
