using System;
namespace Lesson011_HT_Task2
{
    public class GoodPupil : Pupil
    {
        public GoodPupil()
        {
        }
        public override void Study()
        {
            Console.WriteLine("Good progress");
        }
        public override void Read()
        {
            Console.WriteLine("Good progress in reading");
        }
        public override void Write()
        {
            Console.WriteLine("Good progress in writing");
        }
        public override void Relax()
        {
            Console.WriteLine("Do not have a lot of time for relaxing");
        }
    }
}
