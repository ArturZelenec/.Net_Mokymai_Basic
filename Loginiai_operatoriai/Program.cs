//Console.WriteLine("Hello, Loginiai operatoriai!");
//Console.WriteLine("&& (AND0, || (OR), ! (NOT), ^ (XOR)");

//Console.WriteLine("Neigimas !");
//bool tiesa = true;
//bool melas = !tiesa;
//Console.WriteLine($"tiesa= {tiesa}");
//Console.WriteLine($"melas = {melas}");
//Console.WriteLine($"!melas = {!melas}");

//Console.WriteLine("AND &&");
//Console.WriteLine($"tiesa AND tiesa {tiesa && tiesa}");
//Console.WriteLine($"tiesa AND melas {tiesa && melas}");
//Console.WriteLine($"melas AND tiesa {melas && tiesa}");
//Console.WriteLine($"melas AND melas {melas && melas}");

//Console.WriteLine("OR ||");
//Console.WriteLine($"tiesa OR tiesa {tiesa || tiesa}");
//Console.WriteLine($"tiesa OR melas {tiesa || melas}");
//Console.WriteLine($"melas OR tiesa {melas || tiesa}");
//Console.WriteLine($"melas OR melas {melas || melas}");

//Console.WriteLine("XOR ^");
//Console.WriteLine($"tiesa XOR tiesa {tiesa ^ tiesa}");
//Console.WriteLine($"tiesa XOR melas {tiesa ^ melas}");
//Console.WriteLine($"melas XOR tiesa {melas ^ tiesa}");
//Console.WriteLine($"melas XOR melas {melas ^ melas}");

//Console.WriteLine("NAND ! &&");
//Console.WriteLine($"tiesa NAND tiesa {!(tiesa && tiesa)}");
//Console.WriteLine($"tiesa NAND melas {!(tiesa && melas)}");
//Console.WriteLine($"melas NAND tiesa {!(melas && tiesa)}");
//Console.WriteLine($"melas NAND tiesa {!(melas && melas)}");

//Console.WriteLine("NOR ! ||");
//Console.WriteLine($"tiesa OR tiesa {!(tiesa || tiesa)}");
//Console.WriteLine($"tiesa OR melas {!(tiesa || melas)}");
//Console.WriteLine($"melas OR tiesa {!(melas || tiesa)}");
//Console.WriteLine($"melas OR melas {!(melas || melas)}");

//Console.WriteLine("NXOR ! ^");
//Console.WriteLine($"tiesa XOR tiesa {!(tiesa ^ tiesa)}");
//Console.WriteLine($"tiesa XOR melas {!(tiesa ^ melas)}");
//Console.WriteLine($"melas XOR tiesa {!(melas ^ tiesa)}");
//Console.WriteLine($"melas XOR melas {!(melas ^ melas)}");


//PARAŠYTI PROGRAMĄ KURI
//PRAŠO ĮVESTI 2 SKAIČIUS.
//JEI ABU LYGŪS,
//PROGRAMA TURI IŠVESTI
//TRUE , JEI NE FALSE
//Console.WriteLine("iveskite du skaicius");
//var sk = Convert.ToInt32(Console.ReadLine());
//var sk2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Ar jie lygus {sk==sk2}");

//PARAŠYTI PROGRAMĄ KURI
//PRAŠO ĮVESTI 2 SKAIČIUS.
//JEI ABU LYGINIAI,
//PROGRAMA TURI IŠVESTI
//TRUE , JEI NE FALSE
//Console.WriteLine("iveskite du skaicius");
//var sk = Convert.ToInt32(Console.ReadLine());
//var sk2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Ar jie lyginiai {sk%2 == sk2%2}");


//[19:02] Robertas Ūselis
//Tikriausiai žinote, kad elektronikoje signalai koduojami dviejų bitų kodu. Ty 0(low) ir 1(high).
//išsivaizduokite du ryšio kanalus kurie atsiunčia štai tokią informaciją:
//kanalas A __---___---___---___---___
//kanalas B ____---___---___---___---_
//Apatinis brūkšnys (_) reiškia false, o paprastas(-) true.
//Parašykite progamą kuri atvazduoja šių kanalų logines operacijas:
//a) A AND B
//b) A OR B
//c) A XOR B
//d) A NAND B
//e) A NOR B
//f) NOT A
//g) NOT A OR B
//e) (A OR B) NAND Aatsakymas:
//a) ____ - _____ - _____ - _____ - ___
//b) __---- - _---- - _---- - _---- - _
//c) __--_--_--_--_--_--_--_--_

bool a = true;
bool b = false;
Console.Write($"{(b&&b).ToString().Replace("True","-").Replace("False","_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a && a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a && a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a && a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a && a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine();

Console.Write($"{(b || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine();

Console.Write($"{(b ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a ^ b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine();


Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a && a)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a && a)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a && a)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a && a)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine();

Console.Write($"{(!(b || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(a || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!(b || b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine();

Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a && !a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a && !a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a && !a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a && !a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine();

Console.Write($"{(b || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(!a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine();

Console.Write($"{(b || b).ToString().Replace("True", "-").Replace("False", "_")} {(!(b && b))}");
Console.Write($"{(b || b).ToString().Replace("True", "-").Replace("False", "_")}{(!(b && b)).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.Write($"{(b || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine();






