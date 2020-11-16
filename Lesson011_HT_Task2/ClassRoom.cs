using System;
namespace Lesson011_HT_Task2
{
    public class ClassRoom
    {
        public Pupil A;
        public Pupil B;
        public Pupil C;
        public Pupil D;
        public ClassRoom()
        {
        }
        public ClassRoom(Pupil A, Pupil B, Pupil C, Pupil D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }
        public ClassRoom(Pupil A, Pupil B, Pupil C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public ClassRoom(Pupil A, Pupil B)
        {
            this.A = A;
            this.B = B;
        }
    }
}
