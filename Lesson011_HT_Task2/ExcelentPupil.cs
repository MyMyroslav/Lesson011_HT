using System;
namespace Lesson011_HT_Task2
{
    public class ExcelentPupil : Pupil
    {
        public ExcelentPupil()
        {
        }
        public override void Study()
        {
            Console.WriteLine("Excelent progress");
        }
        public override void Read()
        {
            Console.WriteLine("Excelent progress in reading");
        }
        public override void Write()
        {
            Console.WriteLine("Excelent progress in writing");
        }
        public override void Relax()
        {
            Console.WriteLine("Do not have time for relaxing");
        }
    }
}
