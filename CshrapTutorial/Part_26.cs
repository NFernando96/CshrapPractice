namespace CshrapTutorial
{
    public class Display
    {
        public void DisplayTest()
        {
            Console.WriteLine("Displaying Test");
        }
    }

    public static class DisplayExtentions
    {
        public static void NewDisplay(this Display display)
        {
            Console.WriteLine("Displaying New");
        }
    }
    internal class Part_26
    {
        static void Main()
        {
            Display obj = new Display();
            obj.DisplayTest();
            obj.NewDisplay();
        }
    }
}
