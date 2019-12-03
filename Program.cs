using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,\nPlease type you name");
            string input = Console.ReadLine();
            Console.WriteLine("Nice to meet you {0}!", input);
            Console.WriteLine("The current date is " + DateTime.Now);
        }
    }
}
