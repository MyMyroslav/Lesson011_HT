using System;
namespace Lesson011_HT
{
    public class name : Printer
    {
        public name()
        {
        }
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{value} - Name");
        }
    }
}
