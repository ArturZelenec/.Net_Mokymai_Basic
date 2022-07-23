namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, For loop!");
            ForLoop();
            Console.WriteLine("-------------------");
            ForLoopBack();
            Console.WriteLine("-------------------");
            BreakForLoop();
            Console.WriteLine("-------------------");
            SkipIterationForLoop();


        }
        private static void ForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void ForLoopBack()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        private static void BreakForLoop()
        {
            int skaicius = 5;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == skaicius)
                {
                    break; // sustos ir neeis toliau
                }
            }
        }

        private static void SkipIterationForLoop()
        {
            int iteracijaKuriaNorimePraleisti = 5;
            for (int i = 0; i < 10; i++)
            {
               
                if (i == iteracijaKuriaNorimePraleisti)
                {
                    continue;  // praleis vieta ir sugriz i fora
                }
                Console.WriteLine(i);
            }
        }

        private static void ForLoopNesting()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}