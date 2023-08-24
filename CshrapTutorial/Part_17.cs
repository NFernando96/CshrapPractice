using CSharpTutorialLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshrapTutorial
{
    public class PrivateClass
    {
       
    }
    internal class Part_17
    {
        private void Display()
        {
            Console.WriteLine("display private");
        }

        static void Main()
        {
            MyPublicClass obj1 = new MyPublicClass();
            Part_17 obj2 = new Part_17();
            obj2.Display();
           
        }
    }
}
