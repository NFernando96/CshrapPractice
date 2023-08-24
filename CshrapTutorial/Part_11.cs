namespace CshrapTutorial
{
    internal class Part_11
    {
        public static void Main()
        {
            Console.WriteLine("***** Snake Water Gun Game *****");

            char comp = '\0';
            var rnd = new Random();
            var str = "swg";
            var rndIndex = rnd.Next(str.Length);
            comp = str[rndIndex];

            Console.Write("Enter s / w / g : ");
            char user = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Computer : {comp} | User : {user}");

            if (comp == user)
            {
                Console.WriteLine("Draw");
            }
            if (comp == 's' && user == 'w')
            {
                Console.WriteLine("Computer wins");
            }
            if (comp == 's' && user == 'g')
            {
                Console.WriteLine("User wins");
            }
            if (comp == 'w' && user == 's')
            {
                Console.WriteLine("User wins");
            }
            if (comp == 'w' && user == 'g')
            {
                Console.WriteLine("Computer wins");
            }
            if (comp == 'g' && user == 'w')
            {
                Console.WriteLine("User wins");
            }
            if (comp == 'g' && user == 's')
            {
                Console.WriteLine("Computer wins");
            }




        }
    }
}
