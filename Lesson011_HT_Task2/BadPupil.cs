using System;
namespace Lesson011_HT_Task2
{
    public class BadPupil : Pupil
    {
        public BadPupil()
        {
        }
        public override void Study()
        {
            Console.WriteLine("Bad progress");
        }
        public override void Read()
        {
            Console.WriteLine("Bad progress in reading");
        }
        public override void Write()
        {
            Console.WriteLine("Bad progress in writing");
        }
        public override void Relax()
        {
            Console.WriteLine("A lot of time for relaxing");
        }
    }
}
