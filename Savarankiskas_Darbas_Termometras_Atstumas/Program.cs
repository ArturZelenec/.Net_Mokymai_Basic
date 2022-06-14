
Console.WriteLine("Iveskite 1 skaičių - temperatūrą pagal Celsijų");
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



