using System;

namespace SOLID._04_Interface_Segregation
{
    public class HPLaserJet : IAdvancedPrinter, IBasicPrinter
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax Done"); return true;
        }

        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done"); return true;
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done"); return true;
        }

        public bool PrintDuplexContent(string content)
        {
            Console.WriteLine("Print Duplex Done"); return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done"); return true;
        }
    }
}
