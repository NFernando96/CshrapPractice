namespace CshrapTutorial
{
    internal class Part_22
    {
        public static void Main()
        {
            try
            {
                int a = 6;
                int b = 0;
                Console.WriteLine(a / b);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Dividewd Sucessfully");
        }
    }
}
