namespace CshrapTutorial
{
    public class Employee
    {
        public string name;
        public int age;
        public int id;

        public Employee(string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine($"name : {name} , age : {age} , id : {id}");
        }
    }

    public class Manager : Employee
    {
        public Manager(string name, int age, int id) : base(name, age, id)
        {

        }

        public void AssignTasks()
        {
            Console.WriteLine("Assigning Tasks");
        }
    }

    public class Programmer : Employee
    {
        public Programmer(string name, int age, int id) : base(name, age, id)
        {

        }


        public void GetProgramm()
        {
            Console.WriteLine("Getting the programm");
        }
    }


    internal class Part_15
    {
        static void Main()
        {
            Employee emp = new Employee("Naleen", 26, 1);
            Programmer prg = new Programmer("Roshan", 27, 2);
            Manager mng = new Manager("Dasun", 28, 3);

            emp.DisplayEmployee();
            prg.DisplayEmployee();
            mng.DisplayEmployee();

            prg.GetProgramm();
            mng.AssignTasks();
        }
    }
}
