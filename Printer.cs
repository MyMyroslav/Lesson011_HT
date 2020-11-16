using System;
namespace Lesson011_HT
{
    public class Printer
    {
        public Printer()
        {
        }
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
}
