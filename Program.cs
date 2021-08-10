using System;

namespace DO_Condiion
{
    class Program
    {
        static void Main(string[] args)
        {
            bool switCat = true;
            do
            {
                if (switCat)
                {
                    Console.WriteLine("Here a cute Cat");
                    Console.WriteLine("Do you want to see a Dog?");
                }
                else
                {
                    Console.WriteLine("Here a cute Dog");
                    Console.WriteLine("Do you want to see a Cat?");
                }
                switCat = !switCat;
            } while (Console.ReadLine() == "yes");
        }
    }
}
