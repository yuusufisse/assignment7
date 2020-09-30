using System;

namespace assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first name");
            string fiName = Console.ReadLine();
            Console.Write("Enter last name");
            string laName = Console.ReadLine();
            //Call, save what ever comes back - maybe you need it later
            string received = DisplayResult(fiName, laName);
            Console.WriteLine(recieved);
            Console.WriteLine();
            DisplayResult("Welcome " + fiName.ToUpper() + " " + laName.ToUpper() + " on board!");
        }
        //Definition
        private static void DisplayResult(string first, string second)
        {
            Console.WriteLine("Welcome " + 
                string.Format("{0} {1}", first.ToUpper(), second.ToUpper()) + 
                " on board!");
        }
        //Overloaded version of method DisplayResult()
        private static void DisplayResult(string message)
        {
            Console.WriteLine(message);
        }
    }
}
