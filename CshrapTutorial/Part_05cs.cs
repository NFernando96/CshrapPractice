namespace CshrapTutorial
{
    internal class Part_05cs
    {
        public static void Main()
        {
            Console.Write("Enter any number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x == 12)
            {
                Console.WriteLine("Number is equal to 12");
            }
            else if (x > 13)
            {
                Console.WriteLine("Number is grater than 12");
            }
            else
            {
                Console.WriteLine("Number is less than 12");
            }
        }
    }
}
