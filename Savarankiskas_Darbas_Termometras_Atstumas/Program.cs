
Console.WriteLine("Iveskite skaičių - temperatūrą pagal Celsijų");
double celsius = Convert.ToDouble(Console.ReadLine());
double fahrenheit = (celsius * 9) / 5 + 32;
double kelvin = celsius + 273;
double backToCelsiusFromFahrenheit = (fahrenheit - 32) * 5 / 9;
double backToCelsiusFromKelvin = kelvin - 273;
double fahrenheitToKelvin = 273 + (fahrenheit - 32) * 5 / 9;
Console.WriteLine($"Temperatūrą pagal farenheitą yra {fahrenheit}");
Console.WriteLine($"Temperatūrą pagal kelviną yra {kelvin}");
Console.WriteLine($"Patikra ar sutampa fahrenheit su įvestu celsius = {celsius == backToCelsiusFromFahrenheit}");
Console.WriteLine($"Patikra ar sutampa kelvin su įvestu celsius = {celsius == backToCelsiusFromKelvin}");
Console.WriteLine($"Patikra ar sutampa kelvin su fahrenheit = {kelvin == fahrenheitToKelvin}");

Console.WriteLine("_________________");
Console.WriteLine("  ^F          ^C  ");
Console.WriteLine($"| {fahrenheit + 72}  | |    {celsius + 40} |");
Console.WriteLine($"| {fahrenheit + 63}  | |    {celsius + 35} |");
Console.WriteLine($"| {fahrenheit + 54}  | |    {celsius + 30} |");
Console.WriteLine($"| {fahrenheit + 45}   | |    {celsius + 25} |");
Console.WriteLine($"| {fahrenheit + 36}   | |    {celsius + 20} |");
Console.WriteLine($"| {fahrenheit + 27}   | |    {celsius + 15} |");
Console.WriteLine($"| {fahrenheit + 18}   | |    {celsius + 10} |");
Console.WriteLine($"| {fahrenheit + 9}   | |    {celsius + 5} |");
Console.WriteLine($"| {fahrenheit}   |X|    {celsius} |");
Console.WriteLine($"| {fahrenheit - 9}   |X|     {celsius - 5} |");
Console.WriteLine($"| {fahrenheit - 18}   |X|     {celsius - 10} |");
Console.WriteLine($"| {fahrenheit - 27}   |X|    {celsius - 15} |");
Console.WriteLine($"| {fahrenheit - 36}   |X|   {celsius - 20} |");
Console.WriteLine($"| {fahrenheit - 45}    |X|   {celsius - 25} |");
Console.WriteLine($"| {fahrenheit - 54}   |X|   {celsius - 30} |");
Console.WriteLine($"| {fahrenheit - 63}  |X|   {celsius - 35} |");
Console.WriteLine($"| {fahrenheit - 72}  |X|   {celsius - 40} |");
Console.WriteLine("|________________|");

Console.WriteLine("PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI ATSTUMĄ (KILOMENTRAIS) TARP TAŠKŲ A IR B IR DVIEJŲ TRANSPORTO PRIEMONIŲ GREITĮ (KM/H)");
Console.WriteLine("ĮVESTI ATSTUMĄ");
double atstumas = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("PIRMOS MAŠINOS GREITIS");
double masina1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ANTROS MAŠINOS GREITIS");
double masina2 = Convert.ToDouble(Console.ReadLine());
double laikas = (atstumas/(masina1 + masina2))*3600;
Console.WriteLine($"LAIKAS KADA TRASPORTO PRIEMONĖS SUSITIKS SEKUNDĖMIS: {laikas:0}");
double susitikimoTaskas = ((laikas * masina1)/3600)*1000;
Console.WriteLine($"ATSTUMAS NUO A IKI VIETOS KURIOJE TRASPORTO PRIEMONĖS SUTITIKS METRAIS: {susitikimoTaskas:0}");
double galutinisTaskasMasina1 = atstumas / masina1;
double galutinisTaskasMasina2 = atstumas / masina2;
Console.WriteLine($"PIRMA TRASPORTUO PRIEMONĖ PASIEKS GALIUTINI TAŠKĄ {galutinisTaskasMasina1*60} MINUTĖMIS");
Console.WriteLine($"PIRMA TRASPORTUO PRIEMONĖ PASIEKS GALIUTINI TAŠKĄ {galutinisTaskasMasina2 * 60} MINUTĖMIS");
double co2 = (atstumas * 2) * 95;
Console.WriteLine($"{co2}  GRAMŲ CO2 IŠSKYRĖ ABI TRASPORTO PIEMONĖS");





