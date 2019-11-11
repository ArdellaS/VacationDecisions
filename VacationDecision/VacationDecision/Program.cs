using System;

namespace VacationDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the first step of your stress-free vacation");

            Console.WriteLine("Please choose a vacation theme:\n Tropic \n Musical \n Adventurous");
            string theme = Console.ReadLine().ToLower();
            string vacay = "";

            if (theme.Equals("musical", StringComparison.OrdinalIgnoreCase))
            {
                vacay = "New Orleans";
            }
            if (theme.Equals("tropical", StringComparison.OrdinalIgnoreCase))
            {
                vacay = "Beach Vacation in Mexico";
            }
            if (theme.Equals("adventurous", StringComparison.OrdinalIgnoreCase))
            {
                vacay = "Whitewater Rafting the Grand Canyon";
            }

            Console.WriteLine("How many will travel with you?");
            int people = int.Parse(Console.ReadLine());


            string travel = "";

            if (people <3)
            {
                travel = "First Class";
            }
            if (people <5)
            {
                travel = "Helicopter";
            }
            if (people > 6)
            {
                travel = "Charter Flight";
            }

            string result = "Since you're a group of " + people + " going on a " + theme + " vacation, you should take a " +  travel + " to a " + vacay;
            
            Console.WriteLine(result);

        }
    }
}
