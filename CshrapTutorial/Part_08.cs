namespace CshrapTutorial
{
    internal class Part_08
    {
        public static void Main()
        {
            string s = "Naleen";
            int len = s.Length;
            string newstr = @"Hello
                I am
                Fernando
                        ";
            Console.WriteLine(newstr);
            Console.WriteLine(s);
            Console.WriteLine($"length of string {s} is {len}");
            Console.WriteLine(s[len - 1]);

        }
    }
}
