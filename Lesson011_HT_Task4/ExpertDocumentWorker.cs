using System;
namespace Lesson011_HT_Task4
{
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public ExpertDocumentWorker()
        {
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document is saved in the new Expert mode");
        }
    }
}
