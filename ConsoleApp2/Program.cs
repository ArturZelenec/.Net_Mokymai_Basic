using System;
using System.Threading;

namespace ConsoleApplication1
{

    struct Game
    {
        public string word;
        public char[] stars;
        public int count;

    }
    internal class Program
    {
        private static Game game;
        private static void Main(string[] args)
        {
            const int maxCount = 15;

            Console.Write("Iveskite zodi:");
            string str = Console.ReadLine().ToLower();
            game.word = str;
            game.stars = new string('*', str.Length).ToCharArray();

            char symbol = ' ';
            Thread th = new Thread(() =>
            {
                while (true)
                {
                    Console.WriteLine(new string('-', 30));
                    NewWord(symbol);
                    Console.WriteLine("Zagadanoje slovo " + string.Join("", game.stars));
                    Console.WriteLine(new string('-', 30));
                    Console.WriteLine("Kolicestvo popytok {0},U vas ostalos {1}", game.count, maxCount - game.count);
                    if (game.word.Equals(string.Join("", game.stars)))
                    {
                        Console.WriteLine("You are win!");
                        return;

                    }
                    if (game.count == maxCount)
                    {
                        Console.WriteLine("You are lose!");
                        return;
                    }

                   
                }
            });
            th.Start();
            Thread th2 = new Thread(() =>
            {
                while (true)
                {
                    symbol = (Char.ToLower(Console.ReadKey().KeyChar));
                    game.count++;
                    Thread.Sleep(300);
                }
            });
            th2.IsBackground = true;
            th2.Start();
            Console.ReadKey(true);

        }

        static void NewWord(char s)
        {

            for (int i = 0; i < game.word.Length; i++)
            {
                if (game.word[i] == s)
                {
                    game.stars[i] = s;
                }
            }
        }
    }
}