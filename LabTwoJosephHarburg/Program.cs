using System;

namespace LabTwoJosephHarburg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculation Application!\n");
            Console.WriteLine("Enter the name of the room:");
            string roomName = Console.ReadLine();
            Console.WriteLine("Enter a Length:");
            int userLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Width:");
            int userWidth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Height:");
            int userHeight = int.Parse(Console.ReadLine());
            int area = userLength * userWidth;
            int perimeter = 2 * (userLength + userWidth);
            Console.WriteLine($"The area of the {roomName} is {area}\n" +
                $"The Perimeter of the {roomName} is {perimeter}");


        }
    }
}
