namespace CshrapTutorial
{
    delegate int SumDel(int n1, int n2);
    internal class Part_29
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static void PrintSum(int a, int b, SumDel delhandler)
        {

            Console.WriteLine($"Sum of {a} and {b} is {delhandler(a, b)}");
        }

        static void Main()
        {
            //SumDel sumHandler = Sum;
            //Using annonymous method
            SumDel sumHandler = delegate (int a, int b)
            {
                return (a + b);
            };
            PrintSum(10, 23, sumHandler);

            //Using lamda functions
            SumDel sumHandler1 = (a, b) => { return (a + b); };
            PrintSum(20, 56, sumHandler1);
        }
    }
}
