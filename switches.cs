using System;
namespace App1
{
    class switches
    {
        public static void Main6(string[] args)
        {
            Console.WriteLine("What day is today? ");
            string day = Console.ReadLine();
            day = day.ToLower();   // FIXED

            switch (day)
            {
                case "monday":
                    Console.WriteLine("Oh today is Monday!");
                    break;

                case "tuesday":
                    Console.WriteLine("Oh today is Tuesday!");
                    break;

                case "wednesday":
                    Console.WriteLine("Oh today is Wednesday!");
                    break;

                case "thursday":
                    Console.WriteLine("Oh today is Thursday!");
                    break;

                case "friday":
                    Console.WriteLine("Oh today is Friday!");
                    break;

                case "saturday":
                    Console.WriteLine("Oh today is Saturday!");
                    break;

                case "sunday":
                    Console.WriteLine("Oh today is Sunday!");
                    break;

                default:
                    Console.WriteLine(day.ToUpper() + " is a invalid day!");
                    break;
            }
        }
    }
}
