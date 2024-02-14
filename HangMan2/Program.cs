namespace HangMan2
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {


                string[] words = { "GALATASARAY", "OKAN", "DOMATES", "İSKENDER", "ARABA" };
                Random random = new Random();
                string wordToGuess = words[random.Next(words.Length)].ToUpper(); // Convert word to uppercase
                char[] guessedWord = new char[wordToGuess.Length];
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    guessedWord[i] = '_';

                }

                int attemptsLeft = 10;
                bool wordGuessed = false;

                Console.WriteLine(" Welcome to HangMan2 game! ");
                Console.WriteLine(" You have 10 attempts to guess the word ");
                Console.WriteLine("The word has " + wordToGuess.Length + " letters. Good luck!");


                while (attemptsLeft > 0 && !wordGuessed)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Attempts left: " + attemptsLeft);
                    Console.WriteLine(" Current word: " + string.Join(" ", guessedWord));
                    Console.WriteLine(" Guess a letter: ");
                    char guess = Char.ToUpper(Console.ReadLine()[0]);

                    bool found = false;

                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == guess)
                        {
                            guessedWord[i] = wordToGuess[i];
                            found = true;
                        }
                    }


                    if (!found)
                    {
                        attemptsLeft--;
                        Console.WriteLine(" Incorrect guess!");

                    }

                    if (string.Equals(wordToGuess, new string(guessedWord)))
                    {
                        wordGuessed = true;

                    }
                }

                if (wordGuessed)
                {
                    Console.WriteLine(" Congratulations! You have guessed the word: " + wordToGuess);
                }
                else
                {
                    Console.WriteLine(" Sorry, you just ran out of attempts. The word was: " + wordToGuess);
                }

                Console.WriteLine("Do you want to play again? (YES/NO)  ");
                string playAgainInput = Console.ReadLine().ToLower(); // Convert input to lowercase

                playAgain = (playAgainInput == "yes");
            }
            
        }
    }
}