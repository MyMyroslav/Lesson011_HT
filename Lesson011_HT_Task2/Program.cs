using System;

namespace Lesson011_HT_Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Pupil first = new ExcelentPupil();
            Pupil second = new GoodPupil();
            Pupil third = new BadPupil();
            Pupil fourth = new GoodPupil();
            ClassRoom aclass = new ClassRoom(first, second, third, fourth);
            first.Study();
            first.Read();
            first.Write();
            first.Relax();
            Console.WriteLine(" ");
            second.Study();
            second.Read();
            second.Write();
            second.Relax();
            Console.WriteLine(" ");
            third.Study();
            third.Read();
            third.Write();
            third.Relax();
            Console.WriteLine(" ");
            fourth.Study();
            fourth.Read();
            fourth.Write();
            fourth.Relax();
        }
    }
}
