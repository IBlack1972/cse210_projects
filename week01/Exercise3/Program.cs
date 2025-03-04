using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string playAgain = "yes";
        while(playAgain == "yes")
        {
            int  theRealNumber = randomGenerator.Next(1, 100);
            int guessNumber = 0;

            Console.Write("What is your guess? ");
            string yourGuess = Console.ReadLine();
            int theRealGuess = int.Parse(yourGuess);


            while(theRealNumber != theRealGuess)
            {
                if(theRealNumber > theRealGuess)
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    yourGuess = Console.ReadLine();
                    theRealGuess = int.Parse(yourGuess);
                    guessNumber ++;
                }
                else if(theRealNumber < theRealGuess)
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    yourGuess = Console.ReadLine();
                    theRealGuess = int.Parse(yourGuess);
                    guessNumber ++; 
                }
            }
            Console.WriteLine($"You Guessed it in {guessNumber + 1} guesses!");
            Console.Write("Would you like to play again? (yes or no)");
            playAgain = Console.ReadLine();
        }
        
    }
}