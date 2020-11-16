using System;
namespace Lesson011_HT_Task4
{
    public class ProDocumentWorker : DocumentWorker
    {
        public ProDocumentWorker()
        {
        }
        public override void EditDocument()
        {
            Console.WriteLine("Documents is edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document is saved in the old format, saving in other formats available in ExpertMode");
        }
    }
}
