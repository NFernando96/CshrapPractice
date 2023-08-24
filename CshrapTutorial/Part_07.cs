namespace ConsoleApp1
{
    internal class Class1
    {
        public static void Main()
        {
            do
            {
                Console.WriteLine("Enter a number");
                var num = Convert.ToInt32(Console.ReadLine());

                var isReminderZero = num % 2 == 0;

                if (isReminderZero)
                {
                    Console.WriteLine($"{num} is an even number.");
                }
                else
                {
                    Console.WriteLine($"{num} is an odd number");
                }
            } while (TryAgain());
        }

        static bool TryAgain()
        {
            Console.WriteLine("Do you want to try again (y/n)? : ");
            var input = Console.ReadLine();

            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input. Assuming 'n'.");
                return false;
            }
        }
    }
}
