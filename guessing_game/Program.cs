using System;


class MyApp
{
    class Program
    {
        static void Main()
        {
            string input = "";
            geusWord(input);
        }

        static void geusWord( string input)
        {
            string secretWord = "Google";
            while (input != secretWord)
            {
                Console.Write("Guess the secret word: ");
                input = Console.ReadLine();

            }
            Console.WriteLine("Wel done");
        }
    }
}
