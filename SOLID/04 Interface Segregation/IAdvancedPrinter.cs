namespace SOLID._04_Interface_Segregation
{
    interface IAdvancedPrinter
    {
        bool FaxContent(string content);
        bool PrintDuplexContent(string content);
    }
}
