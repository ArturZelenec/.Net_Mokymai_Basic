int nelynisSkaicius = 5;
int lyginisSkaicius = 2;
bool tiesa = true;
if (nelynisSkaicius > lyginisSkaicius)
{
    Console.WriteLine($"{nelynisSkaicius} yra dedesnis uz {lyginisSkaicius}");
}
if (nelynisSkaicius < lyginisSkaicius)
{
    Console.WriteLine($"{nelynisSkaicius} yra mazesnis uz {lyginisSkaicius}");
}

Console.WriteLine("if else salyga");
if (nelynisSkaicius < lyginisSkaicius)
{
    Console.WriteLine($"{nelynisSkaicius} yra dedesnis uz {lyginisSkaicius}");
}
else
{
    Console.WriteLine($"{nelynisSkaicius} yra dedesnis uz {lyginisSkaicius}");
}

Console.WriteLine("If else, if else");
if (nelynisSkaicius < lyginisSkaicius && tiesa)
{
    Console.WriteLine($"{nelynisSkaicius} yra mazesnis uz {lyginisSkaicius} ir tiesa yra true");

}
else if (nelynisSkaicius < lyginisSkaicius && !tiesa)
{
    Console.WriteLine($"{nelynisSkaicius} yra mazesnis uz {lyginisSkaicius} ir tiesa yra false");

}
else if (nelynisSkaicius > lyginisSkaicius && tiesa)
{
    Console.WriteLine($"{nelynisSkaicius} yra didesnis uz {lyginisSkaicius} ir tiesa yra true");

}
else
{
    Console.WriteLine($"{nelynisSkaicius} yra didesnis uz {lyginisSkaicius} ir tiesa yra false");

}
Console.WriteLine("__________________");
var score = 45;
int pointNeededToPass = 100;
if (score >= pointNeededToPass)
{
    bool laverCompleate = true;
}
else
{
    bool leverComplete = true;
}


Console.WriteLine("press any key to continiu");