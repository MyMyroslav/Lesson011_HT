using System;

namespace Lesson011_HT_Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter key:");
            string key = Console.ReadLine();
            if(key == null || key == "smpl")
            {
                DocumentWorker prog = new DocumentWorker();
                prog.OpenDocument();
                prog.EditDocument();
                prog.SaveDocument();
            }
            else if(key == "pro")
            {
                DocumentWorker prog = new ProDocumentWorker();
                prog.OpenDocument();
                prog.EditDocument();
                prog.SaveDocument();
            }
            else if(key == "exp")
            {
                DocumentWorker prog = new ExpertDocumentWorker();
                prog.OpenDocument();
                prog.EditDocument();
                prog.SaveDocument();
            }

        }
    }
}
