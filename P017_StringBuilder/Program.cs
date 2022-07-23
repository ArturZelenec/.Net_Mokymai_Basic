using System.Text;

namespace P017_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, StrinBuilder!");

            //string builder sukurimas
            StringBuilder sb = new StringBuilder(); // be teksto
            StringBuilder sb1 = new StringBuilder("labas pasauli"); // sukurimo metu irasamas tekstas
            StringBuilder sb2 = new StringBuilder(123456); // sukurimo metu taip pat irasomas tekstas

            //Teksto isgavimas is stringBuilder
            Console.WriteLine(sb.ToString());

            //Teksto pridejimas per StringBuilder
            sb.Append("Labas");
            sb.Append("pasauli");
            sb.AppendLine();
            sb.AppendLine("labas c#");
            Console.WriteLine(sb.ToString());

            Console.WriteLine("_______________________");
           
            //Teksto iterpimas
            sb.Insert(5, " AAAAA "); //iterpia nuo kurio indekso ir  ka
            Console.WriteLine(sb.ToString());

            Console.WriteLine("_______________________");

            //Teksto pasalinimas
            sb.Remove(6, 2);     //pasalina nuo kurio indekso ir kiek indeksu
            Console.WriteLine(sb.ToString());

            Console.WriteLine("_______________________");

            //Teksto pakeitimas
            sb.Replace("labas", "hello");     //pakeicia tesksta
            Console.WriteLine(sb.ToString());
        }
    }
}