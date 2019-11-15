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
            string vacationType = "";
            do
            {
                
                while (true)
                {
                    Console.WriteLine("Please choose a vacation vacationType:\n Tropic \n Musical \n Adventurous\n");
                    vacationType = Console.ReadLine().ToLower();
                    

                    if (vacationType.Equals("musical", StringComparison.OrdinalIgnoreCase))
                    {
                        vacay = "New Orleans";
                        break;
                    }
                    if (vacationType.Equals("tropical", StringComparison.OrdinalIgnoreCase))
                    {
                        vacay = "Beach Vacation in Mexico";
                        break;
                    }
                    if (vacationType.Equals("adventurous", StringComparison.OrdinalIgnoreCase))
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
                int groupSize;
                while (true)
                {
                    Console.WriteLine("How many will travel with you?");
                    groupSize = int.Parse(Console.ReadLine());

                    if (groupSize < 3)
                    {
                        travel = "First Class";
                        break;
                    }
                    if (groupSize < 5)
                    {
                        travel = "Helicopter";
                        break;
                    }
                    if (groupSize > 6)
                    {
                        travel = "Charter Flight";
                        break;
                    }
                    if(groupSize == 0)
                    {
                        Console.WriteLine("Please enter a valid number.\n");
                        
                    }
                    
                    
                }
                


                string result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + travel + " to a " + vacay;

                Console.WriteLine(result);
                Console.WriteLine("\nWould you like to plan another vacation?");
                answer = Console.ReadLine();
                Console.Clear();
            } while (answer.Equals("yes", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Have a great trip!");
        }
    }
}
