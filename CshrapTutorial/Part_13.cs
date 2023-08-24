namespace CshrapTutorial
{

    public class Person
    {
        public string name;
        public int age;
        public int id;

        public Person()
        {
            name = "Unknow";
            age = 0;
            Console.WriteLine("Constructor is called");
        }

        public Person(int pAge, int pId)
        {
            name = "NALEEN";
            age = pAge;
            id = pId;
        }
        public void Display()
        {
            Console.WriteLine($"name : {name} , age : {age} , id : {id}");
        }

    }
    internal class Part_13
    {
        public static void Main()
        {
            Person p1 = new Person(26, 962420770);
            Person p2 = new Person();
            p1.Display();
            p2.Display();

        }
    }
}
