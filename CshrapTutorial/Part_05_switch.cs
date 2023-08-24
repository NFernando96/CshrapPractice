namespace CshrapTutorial
{
    internal class Part_05_switch
    {
        public static void Main()
        {
            Console.Write("Enter any number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 0:
                    Console.WriteLine("Number is 0");
                    break;
                case 1:
                    Console.WriteLine("Number is 1");
                    break;
                case 2:
                    Console.WriteLine("Number is 2");
                    break;
                case 3:
                    Console.WriteLine("Number is 3 ");
                    break;
                default:
                    Console.WriteLine("Other number");
                    break;

            }
        }
    }
}
