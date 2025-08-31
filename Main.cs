using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PasswordNamespace
{
    internal class PasswordMain
    {
        public static string password;

        public static bool hasGuessedCorrectly;

        public static void mainn()
        {
            PasswordThingy();

            Console.Title = "Password Test";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Type 'Exit' if you didn't mean to type this. If you did mean to, just click anything.");
            string Answer = Console.ReadLine();

            if (Answer == "Exit")
            {
                Console.Clear();
                Program.MainTi();
            }
            else
            {
                Console.Clear();
            }

            Console.WriteLine("What's the password?");
            string Input = Console.ReadLine();

            if (Input == password)
            {
                hasGuessedCorrectly = true;
                Console.WriteLine("Correct!");
            }
            else
            {
                hasGuessedCorrectly = false;
            }

            while (!hasGuessedCorrectly)
            {
                Console.WriteLine("Incorrect, try again.");
                string secondGuess = Console.ReadLine();

                if (secondGuess == password)
                {
                    hasGuessedCorrectly = true;
                    Console.WriteLine("Correct!");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        public static void PasswordThingy()
        {
            using (WebClient webClient = new WebClient())
            {
                password = webClient.DownloadString("https://pastebin.com/raw/C3YmV6VE").Trim();
            }
        }
    }
}
