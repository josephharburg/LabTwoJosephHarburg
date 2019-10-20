using System;

namespace LabTwoJosephHarburg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculation Application!\n");
            bool repeat = true;
            bool repeatTwo = true;
            
            while (repeat){
                Console.WriteLine("Enter the name of the room:");
                string roomName = Console.ReadLine();
                Console.WriteLine("Enter a Length:");
                double userLength = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter a Width:");
                double userWidth = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter a Height:");
                double userHeight = double.Parse(Console.ReadLine());
                double area = userLength * userWidth;
                double perimeter = 2 * (userLength + userWidth);
                double volume = userHeight * userWidth * userLength;
                
                Console.WriteLine($"The area of the {roomName} is {area}\n" +
                    $"The Perimeter of the {roomName} is {perimeter}\n " +
                   $"The Volume of the {roomName} is {volume} \n Do you wish to continue? Enter (y/n)");
                do
                {
                    string userContinue = Console.ReadLine().ToLower();
                    if (userContinue == "y" || userContinue == "yes")
                    {
                        Console.WriteLine("Great Lets do it again!");
                        repeatTwo = false;

                    }
                    else if (userContinue == "n" || userContinue == "no")
                    {
                        Console.WriteLine("Thanks for using my App!");
                        repeat = false;
                        return;
                    }
                    else if (userContinue != "y" || userContinue != "yes" && userContinue != "n" || userContinue != "no")
                    {
                        Console.WriteLine("Im sorry thats not a valid response! Try again!");
                        repeatTwo = true;
                    }
                } while (repeatTwo);

            }


        }
    }
}
