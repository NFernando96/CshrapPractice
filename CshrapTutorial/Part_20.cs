namespace CshrapTutorial
{
    public abstract class Shape1
    {
        public abstract void Draw();
        public abstract void Draw2();

        public void Print()
        {
            Console.WriteLine("Printing");
        }
    }
    internal class Part_20 : Shape1
    {
        public override void Draw()
        {
            Console.WriteLine("Draw 1");
        }

        public override void Draw2()
        {
            Console.WriteLine("Draw 2");
        }

        static void Main()
        {
            Part_20 obj = new Part_20();
            obj.Draw();
            obj.Draw2();
            obj.Print();
        }
    }
}
