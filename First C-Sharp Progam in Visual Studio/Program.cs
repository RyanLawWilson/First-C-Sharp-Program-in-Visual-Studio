using System;

namespace First_C_Sharp_Progam_in_Visual_Studio
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name?");            
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.Read();
        }
    }
}
