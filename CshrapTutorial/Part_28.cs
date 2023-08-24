namespace CshrapTutorial
{

    public class Fruit
    {
        private string[] names = new string[10];

        public string this[int i]
        {
            get { return names[i]; }
            set { names[i] = value; }
        }

    }
    internal class Part_28
    {
        static void Main()
        {
            Fruit fruit = new Fruit();
            fruit[0] = "banana";
            fruit[1] = "mango";
            fruit[2] = "apple";
            fruit[3] = "pine apple";
            fruit[4] = "papaya";

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine(fruit[i]);
            }
        }
    }
}
