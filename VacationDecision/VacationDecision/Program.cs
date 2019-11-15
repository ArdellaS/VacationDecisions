using System;

namespace VacationDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the first step of your stress-free vacation.\n");
            string answer = "no";
            string vacay = "";
            string theme = "";
            do
            {
                
                while (true)
                {
                    Console.WriteLine("Please choose a vacation theme:\n Tropic \n Musical \n Adventurous\n");
                    theme = Console.ReadLine().ToLower();
                    

                    if (theme.Equals("musical", StringComparison.OrdinalIgnoreCase))
                    {
                        vacay = "New Orleans";
                        break;
                    }
                    if (theme.Equals("tropical", StringComparison.OrdinalIgnoreCase))
                    {
                        vacay = "Beach Vacation in Mexico";
                        break;
                    }
                    if (theme.Equals("adventurous", StringComparison.OrdinalIgnoreCase))
                    {
                        vacay = "Whitewater Rafting the Grand Canyon";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please choose from the given options.\n");
                        
                    }
                }
                
                string travel = "";
                int people;
                while (true)
                {
                    Console.WriteLine("How many will travel with you?");
                    people = int.Parse(Console.ReadLine());

                    if (people < 3)
                    {
                        travel = "First Class";
                        break;
                    }
                    if (people < 5)
                    {
                        travel = "Helicopter";
                        break;
                    }
                    if (people > 6)
                    {
                        travel = "Charter Flight";
                        break;
                    }
                    if(people == 0)
                    {
                        Console.WriteLine("Please enter a valid number.\n");
                        
                    }
                    
                    
                }
                


                string result = "Since you're a group of " + people + " going on a " + theme + " vacation, you should take a " + travel + " to a " + vacay;

                Console.WriteLine(result);
                Console.WriteLine("\nWould you like to plan another vacation?");
                answer = Console.ReadLine();
                Console.Clear();
            } while (answer.Equals("yes", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Have a great trip!");
        }
    }
}
