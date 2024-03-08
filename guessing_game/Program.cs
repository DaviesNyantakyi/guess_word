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

        static void geusWord(string input)
        {
            int geuses = 0;
            string secretWord = "Google";
            while (input != secretWord && geuses < 4)
            {

                if (geuses < 4)
                {
                    Console.Write("Guess the secret word: ");
                    input = Console.ReadLine();
                    geuses++;
                }
                
            }

            if(geuses < 4)
            {
                Console.WriteLine("Wel done");
            }
            else
            {
                Console.WriteLine("You lose");
            }   


        }


    }
}
