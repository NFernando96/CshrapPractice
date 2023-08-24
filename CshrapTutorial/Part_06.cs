

namespace CsharpTutorial
{
    internal class Part_06
    {
        public static void Main()
        {
            int total = 0;
            int count = 0;
            int num;

            do
            {
                Console.Write("Enter a number (or any non-numeric value to stop): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out num))
                {
                    // If the input is a valid number, add it to the total and increment count
                    total += num;
                    count++;
                }
                else
                {
                    // If the input is not a valid number, break out of the loop
                    break;
                }

            } while (true);

            // Calculate and display the average
            if (count > 0)
            {
                double average = (double)total / count;
                Console.WriteLine("Average of the numbers you entered: " + average);
            }
            else
            {
                Console.WriteLine("Cannot calculate the average. No numbers were entered.");
            }
        }
    }
}
