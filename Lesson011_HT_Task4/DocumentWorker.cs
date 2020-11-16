using System;
namespace Lesson011_HT_Task4
{
    public class DocumentWorker
    {
        public DocumentWorker()
        {
        }
        public void OpenDocument()
        {
            Console.WriteLine("Document is opened");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Documents can be edited in ProVersion");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Document can be saved in ProVersion");
        }

    }
}
