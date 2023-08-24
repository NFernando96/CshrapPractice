namespace CshrapTutorial
{

    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("I am drwing a shape");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("I am drawing a circle");
        }
    }

    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("I am drawing a square");
        }
    }

    internal class Part_16
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine($"Sum is {a + b}");
        }

        public void Sum(int a, int b, int c)
        {
            Console.WriteLine($"Sum is {a + b + c}");
        }
        static void Main()
        {
            //Part_16 part_16 = new Part_16();
            //part_16.Sum(12, 13);
            //part_16.Sum(13, 14, 15);

            Shape s = new Shape();
            Shape circle = new Circle();
            Shape square = new Square();

            s.Draw();
            circle.Draw();
            square.Draw();
        }
    }
}
