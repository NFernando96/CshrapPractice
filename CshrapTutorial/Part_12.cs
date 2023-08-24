using School;

namespace CshrapTutorial

{
    public class Car
    {
        public string model;
        public string color;
        public int price;
        public int year;

        public void Start()
        {
            Console.WriteLine("Car is started");
        }

        public void Stop()
        {
            Console.WriteLine("Car is stopped");
        }

        public void Run()
        {
            Console.WriteLine("Car is running");
        }
    }
    internal class Part_12
    {
        public static void Main()
        {
            /*  Car car1 = new Car();
              car1.model = "Honda";
              car1.color = "Black";
              car1.year = 2022;
              car1.price = 5;

              Console.WriteLine($"moedl: {car1.model}, color: {car1.color}, year: {car1.year}, price: {car1.price}");

              car1.Start();
              car1.Run();
              car1.Stop();*/

            Student stu = new Student();
            Teacher tea = new Teacher();
            Department dept = new Department();

            stu.Display();
            tea.Display();
            dept.Display();
        }
    }
}
