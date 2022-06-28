namespace Anketa_Savarankiskas_Darbas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite Varda ir Pavarde");
            var vardasPavarde = Console.ReadLine();
            Console.WriteLine("Iveskite asmens koda");
            string asmensKodas = Console.ReadLine().Remove(11);
            Console.WriteLine("Iveskite amziu (neprivaloma)");
            var amzius = Console.ReadLine();
            Console.WriteLine("Iveskite gimimo data (neprivaloma)");
            var gimimoData = Console.ReadLine();
            
            
            
            //amzius
            string metai = asmensKodas.Remove(0, 1).Remove(2);
            string menuo = asmensKodas.Remove(0, 3).Remove(2);
            string diena = asmensKodas.Remove(0, 5).Remove(2);
            if (asmensKodas.StartsWith("1") || asmensKodas.StartsWith("2"))
            {
                metai = "18" + metai;
            }
            if (asmensKodas.StartsWith("3") || asmensKodas.StartsWith("4"))
            {
                metai = "19" + metai;
            }
            if (asmensKodas.StartsWith("5") || asmensKodas.StartsWith("6"))
            {
                metai = "20" + metai;
            }
            string datosFormatas = $"{metai}-{menuo}-{diena}";
            DateTime gimimoDatosFormatas = Convert.ToDateTime(datosFormatas);

            DateTime dabarData = DateTime.Now;
            
            int kodoAmzius = dabarData.Year - gimimoDatosFormatas.Year;

            //patikimumas
            string patikimumas = "";

            if (gimimoData != "")
            {
                dabarData = Convert.ToDateTime(gimimoData);
            }

            if (gimimoData == "" && amzius == "")
            {
                
                patikimumas = "Patikimumui trūksta duomenų";
                
            }
            else
            {
                if ((gimimoData != "" || amzius != "") && !(gimimoData != "" && amzius != ""))
                {
                    if (gimimoData != "")
                    {
                        if (dabarData != gimimoDatosFormatas)
                        {
                            patikimumas = "Amžius pameluotas";
                        }
                        else
                        {
                            patikimumas = "Amžius patikimas";
                        }
                    }

                    if (amzius != "")
                    {
                        if (Convert.ToInt32(amzius) != kodoAmzius)
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
                    if (dabarData != gimimoDatosFormatas && Convert.ToInt32(amzius) != kodoAmzius)
                    {
                        patikimumas = "Amžius pameluotas";
                    }
                    else if (dabarData != gimimoDatosFormatas || Convert.ToInt32(amzius) != kodoAmzius)
                    {
                        patikimumas = "Amžius nepatikimas";
                    }
                    else
                    {
                        patikimumas = "Amžius tikras";
                    }
                }
                Console.WriteLine("ATASKAITA APIE ASMENI");
                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));
                Console.WriteLine($"Vardas Pavarde {vardasPavarde}");
                //lytis
                if (asmensKodas.StartsWith("1"))
                {
                    Console.WriteLine($"Lytis {"vyras"}");
                }
                if (asmensKodas.StartsWith("2"))
                {
                    Console.WriteLine($"Lytis {"moteris"}");
                }
                if (asmensKodas.StartsWith("3"))
                {
                    Console.WriteLine($"Lytis {"vyras"}");
                }
                if (asmensKodas.StartsWith("4"))
                {
                    Console.WriteLine($"Lytis {"moteris"}");
                }
                if (asmensKodas.StartsWith("5"))
                {
                    Console.WriteLine($"Lytis {"vyras"}");
                }
                
            }
            Console.WriteLine($"Asmens kodas {asmensKodas}");
            Console.WriteLine($"Amzius {kodoAmzius}");
            Console.WriteLine($"Gimimo data {datosFormatas}");
            Console.WriteLine($"Amziaus patikimumas {patikimumas}");
        }
    }
}