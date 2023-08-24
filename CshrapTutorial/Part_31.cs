namespace CshrapTutorial
{
    internal class Part_31
    {
        static void Print1()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Method 1 - " + i);

                if (i == 2)
                {
                    Thread.Sleep(5000);
                }
            }
        }

        static void Print2()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Method 2 - " + i);
            }
        }
        static void Main()
        {
            //Print1();
            //Print2();

            Thread t1 = new Thread(new ThreadStart(Print1));
            Thread t2 = new Thread(new ThreadStart(Print2));
            t1.Start();
            t2.Start();
        }
    }
}
