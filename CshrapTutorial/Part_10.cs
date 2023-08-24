namespace CshrapTutorial
{
    internal class Part_10
    {
        public static void Main()
        {
            //Program - 01

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("* ");

            //    }
            //    Console.WriteLine();
            //}

            //Program - 02
            Console.Write("Enter any integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"Then number {num} you entered is : Even");
            }
            else
            {
                Console.WriteLine($"Then number {num} you entered is : Odd");
            }



        }
    }
}
