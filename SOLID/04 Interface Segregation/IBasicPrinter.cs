namespace SOLID._04_Interface_Segregation
{
    interface IBasicPrinter
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);
    }
}
