namespace CshrapTutorial
{

    public static class Utility
    {
        public static void SendEmail()
        {
            Console.WriteLine("Sending Email...");
        }

        public static void Print()
        {
            Console.WriteLine("Printing.....");
        }
    }
    internal class Part_19
    {
        int count = 0;

        public Part_19()
        {
            count++;
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public void Print()
        {
            Console.WriteLine(count);
        }

        static void Main()
        {
            Part_19 obj = new Part_19();
            Console.WriteLine(Part_19.Sum(3, 4));
            obj.Print();
            Part_19 obj2 = new Part_19();
            obj.Print();
            Part_19 obj3 = new Part_19();
            obj.Print();

            Utility.Print();
            Utility.SendEmail();
        }



    }
}
