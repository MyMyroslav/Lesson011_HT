using System;
namespace Lesson011_HT
{
    public class title : Printer
    {
        public title()
        {
        }
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{value} - Title");
        }
    }
}
