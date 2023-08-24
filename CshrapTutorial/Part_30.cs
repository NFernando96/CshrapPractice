namespace CshrapTutorial
{
    internal class Part_30
    {
        public static void CheckGraterThan7(int num, Predicate<int> handler)
        {
            var result = handler(num);
            Console.WriteLine(result);
        }

        public static void PrintSum(int a, int b, Func<int, int, int> delHandler)
        {
            Console.WriteLine($"Sum of {a} and {b} is {delHandler(a, b)}");
        }

        public static void Greet(string message, Action<string> greetHandler)
        {
            greetHandler(message);
        }

        static void Main()
        {
            Func<int, int, int> sumHandler = (a, b) => { return a + b; };
            PrintSum(1, 2, sumHandler);

            Action<string> greetHandler = (msg) => Console.WriteLine(msg);

            Greet("Hello Naleen", greetHandler);

            Predicate<int> handler = (num) =>
            {
                return num < 7;
            };

            CheckGraterThan7(10, handler);
        }
    }
}