namespace CshrapTutorial
{
    public interface ICatergory
    {
        public bool Add();
        public void Display();

        public void Print();
    }

    public class Catergory : ICatergory
    {
        public bool Add()
        {
            Console.WriteLine("Added");
            return true;
        }

        public void Display()
        {
            Console.WriteLine("Displaying catergory");
        }

        public void Print()
        {
            Console.WriteLine("Printing");
        }
    }
    internal class Part_21
    {
        static void Main()
        {
            ICatergory catergory = new Catergory();
            catergory.Add();
            catergory.Display();
            catergory.Print();
        }
    }
}
