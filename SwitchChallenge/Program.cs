using System;

namespace SwitchChallenge
{
    class Program
    {
        static void Main()
        {
            {
                string savedByTheBell = "Jessie Spano";

                switch (savedByTheBell)
                {
                    case "Zack Morris":
                        Console.WriteLine("He is not a good guy.");
                        break;
                    case "Lisa Turtle":
                        Console.WriteLine("She has style and flair!");
                        break;
                    case "Jessie Spano":
                        Console.WriteLine("She is always smart and spunky!");
                        break;
                    case "AC Slater":
                        Console.WriteLine("He is everyone's favorite jock!");
                        break;
                    default:
                        Console.WriteLine("That character was not one of the favorites!");
                        break;
                }
            }
        }
    }
} 





