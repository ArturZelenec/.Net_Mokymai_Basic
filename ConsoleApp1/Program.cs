namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vartotojo registracijos forma.\n");

            Console.Write("Įveskite savo pilną vardą ir pavardę:     ");
            string regVardas = Console.ReadLine();

            Console.Write("Įveskite savo asmens kodą (11 skaitmenų): ");
            string regAsmens = Console.ReadLine();

            Console.Write("Įveskite savo amžių (neprivaloma):        ");
            string regAmzius = Console.ReadLine();

            Console.Write("Įveskite savo gimimo datą (neprivaloma):  ");
            string regData = Console.ReadLine();


            // Lyties apskaičiavimas
            string firstNo = regAsmens.Substring(0, 1);
            string regLytis = firstNo;

            if (firstNo == "1" || firstNo == "3" || firstNo == "5")
            {
                regLytis = "Vyras";
            }
            else if (firstNo == "2" || firstNo == "4" || firstNo == "6")
            {
                regLytis = "Moteris";
            }


            // Amžiaus ir datos apskaičiavimas
            string metai = regAsmens.Remove(0, 1).Remove(2);
            string menuo = regAsmens.Remove(0, 3).Remove(2);
            string diena = regAsmens.Remove(0, 5).Remove(2);

            if (firstNo == "1" || firstNo == "2")
            {
                metai = "18" + metai;
            }
            else if (firstNo == "3" || firstNo == "4")
            {
                metai = "19" + metai;
            }
            else if (firstNo == "5" || firstNo == "6")
            {
                metai = "20" + metai;
            }

            string gimDiena = metai + "-" + menuo + "-" + diena;
            DateTime gimDienaDT = Convert.ToDateTime(gimDiena);

            DateTime dabarDT = DateTime.Today;
            string siandiena = dabarDT.ToString("yyyy-MM-dd");

            int kodoAmzius = dabarDT.Year - gimDienaDT.Year;
            //if ((gimDienaDT.Month > dabarDT.Month) || (gimDienaDT.Month == dabarDT.Month) && (gimDienaDT.Day >= dabarDT.Day))
            //{
            //    kodoAmzius--;
            //}


            // Patikimumo apskaičiavimas
            string patikimumas = "";
            DateTime regDataDT = DateTime.Today; // jeigu pirma neįvedu kažkokios reikšmės, kodas neveikia :/

            if (regData != "")
            {
                regDataDT = Convert.ToDateTime(regData);
            }

            if (regData == "" && regAmzius == "")
            {
                patikimumas = "Patikimumui trūksta duomenų";
            }
            else
            {
                if ((regData != "" || regAmzius != "") && !(regData != "" && regAmzius != ""))
                {
                    if (regData != "")
                    {
                        if (regDataDT != gimDienaDT)
                        {
                            patikimumas = "Amžius pameluotas";
                        }
                        else
                        {
                            patikimumas = "Amžius patikimas";
                        }
                    }

                    if (regAmzius != "")
                    {
                        if (Convert.ToInt32(regAmzius) != kodoAmzius)
                        {
                            patikimumas = "Amžius pameluotas";
                        }
                        else
                        {
                            patikimumas = "Amžius patikimas";
                        }
                    }
                }
                else
                {
                    if (regDataDT != gimDienaDT && Convert.ToInt32(regAmzius) != kodoAmzius)
                    {
                        patikimumas = "Amžius pameluotas";
                    }
                    else if (regDataDT != gimDienaDT || Convert.ToInt32(regAmzius) != kodoAmzius)
                    {
                        patikimumas = "Amžius nepatikimas";
                    }
                    else
                    {
                        patikimumas = "Amžius tikras";
                    }
                }
            }



            // Ataskaitos išvedimas

            Console.WriteLine($"\n\n");
            Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓  ATASKAITA APIE ASMENĮ  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓       {siandiena}        ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.WriteLine($"▓▓▓▓                     ▓▓                                    ▓▓▓▓");
            Console.WriteLine($"▓▓▓▓     Vardas, pavardė ▓▓ {regVardas,34} ▓▓▓▓");
            Console.WriteLine($"▓▓▓▓               Lytis ▓▓ {regLytis,34} ▓▓▓▓");
            Console.WriteLine($"▓▓▓▓        Asmens kodas ▓▓ {regAsmens,34} ▓▓▓▓");
            Console.WriteLine($"▓▓▓▓              Amžius ▓▓ {kodoAmzius,34} ▓▓▓▓");
            Console.WriteLine($"▓▓▓▓         Gimimo data ▓▓ {gimDiena,34} ▓▓▓▓");
            Console.WriteLine($"▓▓▓▓ Amžiaus patikimumas ▓▓ {patikimumas,34} ▓▓▓▓");
            Console.WriteLine($"▓▓▓▓                     ▓▓                                    ▓▓▓▓");
            Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.WriteLine($"\n\n");
        }
    }
}