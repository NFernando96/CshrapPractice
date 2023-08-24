//namespace CshrapTutorial
//{
//    internal class Part_24
//    {
//        static void Main()
//        {
//            int a = 6;
//            Object obj = a;
//            Console.WriteLine(obj);

//            int b = (int)obj;
//            Console.WriteLine(b);
//        }
//    }
//}

namespace CshrapTutorial
{
    internal class Part_24
    {
        static int score = 0;
        private static int maxAttempts;

        static void Main(string[] args)
        {
            PlayGame();
        }

        static void PlayGame()
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101); // Generates a random number between 1 and 100
            int attempts = 0;
            int maxAttempts = 10;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I have chosen a number between 1 and 100. Try to guess it.");

            while (attempts < maxAttempts)
            {
                Console.Write("Enter your guess: ");
                int guessedNumber = int.Parse(Console.ReadLine());

                if (guessedNumber < targetNumber)
                {
                    Console.WriteLine("Too low! Try a higher number.");
                }
                else if (guessedNumber > targetNumber)
                {
                    Console.WriteLine("Too high! Try a lower number.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number {targetNumber} in {attempts + 1} attempts.");
                    UpdateScore(attempts);
                    break;
                }

                attempts++;
            }

            if (attempts == maxAttempts)
            {
                Console.WriteLine($"Sorry, you've run out of attempts. The number was {targetNumber}.");
            }

            PlayAgain();
        }

        static void UpdateScore(int attempts)
        {
            score += maxAttempts - attempts;
            Console.WriteLine($"Your current score: {score}");
        }

        static void PlayAgain()
        {
            Console.Write("Do you want to play again? (yes/no): ");
            string playAgainInput = Console.ReadLine().ToLower();

            if (playAgainInput == "yes")
            {
                PlayGame();
            }
            else
            {
                Console.WriteLine($"Thank you for playing! Your final score: {score}");
            }
        }
    }
}
