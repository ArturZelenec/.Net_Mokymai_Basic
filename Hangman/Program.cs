﻿using System.Text;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            bool MenuLoop = true;
            string menuSelect;
            int guessCount = 16;

            //Menu loop
            while (MenuLoop)
            {
                Console.Clear();
                VisualMenu();
                menuSelect = Console.ReadLine();

                switch (menuSelect)
                {
                    case "1":
                        GameLoop(guessCount);
                        break;

                    case "2":
                        GameRules();
                        break;

                    case "3":
                        GameHelp(out guessCount);
                        break;


                    case "9":
                        MenuLoop = false;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error");
                        Console.ResetColor();
                        PressToContinue(0);
                        Console.ReadKey();
                        break;
                }
            }
        }
        //Game Loop
        static void GameLoop(int guessCount)
        {
            //"Randomizer"
            Random random = new Random((int)DateTime.Now.Ticks);

            //Wordbank
            string[] wordBank = { "Volvo", "Ford", "Toyota", "Mazda", "Honda", "Nissan", "Audi", "Subaru" };

            //Pick random word
            string wGuess = wordBank[random.Next(0, wordBank.Length)];
            string wGuessConvertion = wGuess.ToUpper();

            //Convert it to _ 
            StringBuilder wordToUser = new StringBuilder(wGuess.Length);
            for (int i = 0; i < wGuess.Length; i++)
                wordToUser.Append('_');

            //Creating list for right and wrong guesses
            List<char> rightGuesses = new List<char>();
            List<char> wrongGuesses = new List<char>();

            //Game variables
            bool win = false;
            int revealedL = 0;
            char guess;
            string input;

            //Game contitions
            while (!win && guessCount > 0)
            {
                Console.Write("Enter a letter:");

                input = Console.ReadLine().ToUpper();
                guess = input[0];


                if (rightGuesses.Contains(guess))
                {
                    Console.WriteLine($"You have guessed \"{guess}\" before");
                    continue;
                }
                else if (wrongGuesses.Contains(guess))
                {
                    Console.WriteLine($"You have already wrongly guessed \"{guess}\"");
                    continue;
                }
                if (wGuessConvertion.Contains(guess))
                {
                    rightGuesses.Add(guess);

                    for (int i = 0; i < wGuess.Length; i++)
                    {
                        if (wGuessConvertion[i] == guess)
                        {
                            wordToUser[i] = wGuess[i];
                            revealedL++;
                        }
                    }
                    if (revealedL == wGuess.Length)
                        win = true;
                }
                else
                {
                    wrongGuesses.Add(guess);
                    Console.WriteLine($"\"{guess}\" is not in this word");
                    guessCount--;
                    Console.WriteLine($"{guessCount} guesses left");
                }
                Console.WriteLine(wordToUser.ToString());
            }

            if (win)
            {
                Console.WriteLine($"You guessed right!");
                PressToContinue(1);
            }
            else
            {
                Console.WriteLine($"You lost! \n The word was {wGuess}");
            }
            Console.ReadKey();



















        }
        //Visual Menu
        static void VisualMenu()
        {
            Console.WriteLine("Pasirinkite tema:"
                            + "\n-----------------------------------"
                            + "\n1. Play"
                            + "\n2. Rules"
                            + "\n3. Help(Easy Mode)"
                            + "\n9. Exit");
        }
        //Short description of game
        static void GameRules()
        {
            Console.WriteLine("Hangman is a word guessing game. \nYou start by guessing a letter until you can either guess the word or lose all your (16 by default) wrong guesses.");
            PressToContinue(0);
            Console.ReadKey();
        }
        //Word theme help + increased guesses
        static void GameHelp(out int guessCount)
        {
            guessCount = 26;
            Console.WriteLine("The theme of the words is \"car brands\".\nAmount of guesses set to 26.");
            PressToContinue(0);
            Console.ReadKey();
        }
        //"Press to..." messages
        static void PressToContinue(int message)
        {
            int press = message;
            switch (press)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Press any key to get back to menu selection");
                    Console.ResetColor();
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Press any key to exit");
                    Console.ResetColor();
                    break;
            }

        }
    }
}