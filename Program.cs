using System;

namespace DO_Condiion
{
    class Program
    {
        static void Main(string[] args)
        {
            string select = "";

            do
            {
                Console.WriteLine("Here a cute Cat");
                Console.WriteLine("Do you want to see a Dog? (input yes)");
                select = Console.ReadLine();

                Console.WriteLine("Here a cute Dog");
                Console.WriteLine("Do you want to see a Cat? (input yes)");
                select = Console.ReadLine();

            } while (select == "yes");
            Console.WriteLine("\n");
            Console.WriteLine("Good Bye");
        }
    }
}
