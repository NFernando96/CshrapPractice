namespace CshrapTutorial
{
    internal class Part_09
    {
        public static void Main()
        {
            Console.WriteLine("Enter any 3 number here");
            Console.Write("a : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b : ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c : ");
            double c = Convert.ToDouble(Console.ReadLine());

            double d = a * b * c;
            Console.WriteLine($"multiplication of {a} , {b} , {c} is : {d:F3}");
        }
    }
}
