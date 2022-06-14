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

//long longSkaicius = long.MaxValue;
//short shortSkaicius = short.MaxValue;
//var dalyba = longSkaicius / shortSkaicius;
//Console.WriteLine($"dalyba = longSkaicius/shortSkaicius = {longSkaicius/shortSkaicius}");
//var skirtumas = dalyba - longSkaicius;
//Console.WriteLine($"skirtumas = dalyba - longSkaicius = {skirtumas}");
//var suma = skirtumas + int.MaxValue;
//Console.WriteLine($"suma = skirtumas + intMaxValue = {suma}");

//Console.WriteLine($"rezultatas = {(longSkaicius/shortSkaicius) - longSkaicius + int.MaxValue}");

//PARAŠYTI PROGRAMĄ KURI NAUDOTOJO PAPRAŠO ĮVESTI PENKIAŽENKLĮ SVEIKĄ SKAIČIŲ
//VISUS ĮVESTUS išskyrus 1 PAKEISKITE Į 0 IR GAUTĄ SKAIČIŲ PADALINKITE IŠ 2
//PVZ BUVO ĮVESTA 12345
//REZULTATAS 10000/2=5000
//<HINT> naudokite replace
//Console.WriteLine("iveskite skaiciu");
//double sk = Convert.ToDouble(Console.ReadLine().Replace("2", "0").Replace("3","0").Replace("4","0").Replace("5","0"));
//Console.WriteLine($"rezultatas = {sk/2}");


//PARAŠYTI PROGRAMĄ KURI NAUDOTOJO PAPRAŠO ĮVESTI SVEIKĄ SKAIČIŲ
//VIENOJE EILUTĖJE IŠVESKITE ŠĮ SKAIČIŲ 5 KARTUS VIS PADIDINAMI VIENETU.
//PVZ BUVO ĮVESTA 5
//REZULTATAS 6 7 8 9 10
//var sk1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"rezultatas {++sk1} {++sk1} {++sk1} {++sk1} {++sk1}"); //s++ isveda i console pradzias [s] o po to pliusoja vieneta; ++s isveda [s] jau supliusota

//ivesti atstumas metrais ir laikas sekundemis
//isveda greiti km/h
//isveda greiti km/s
Console.WriteLine("iveskite atstuma metrais, laika sekundemis");
var atstumas = Convert.ToDouble(Console.ReadLine());
var laikas = Convert.ToDouble(Console.ReadLine());
var greitisKmHour = (atstumas / 1000) / (laikas / 3600);
Console.WriteLine($"km/h {greitisKmHour}");
var greitisKmSecunde = (atstumas / 1000) / laikas;
Console.WriteLine($"km/s {greitisKmSecunde}");
