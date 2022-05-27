using System;

namespace enum_
{
    class Program
{
    static void Main(string[] args)
    {
            /*switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Its a monday");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Its a last day of the work week");
                    break;
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("The weekend!");
                    break;
                default:
                    Console.WriteLine("The middle of the work week.");
                    break;
            }*/
            Console.WriteLine("What is your gender? 1 - male, 2 -female");
            string userInput = Console.ReadLine();
            Gender userGender = (Gender)Enum.Parse(typeof(Gender), userInput);

            if(userGender == Gender.Male)
            {
                Console.WriteLine("only women allowed!");
            }
            else
            {
                Console.WriteLine("Access denied");
            }
    }
}
}
