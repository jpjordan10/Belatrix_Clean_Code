using System;

namespace SOLID._01_SingleResponsability
{
    public class Sample
    {
        public void Sum(int firstNumber, int secondNumber)
        {
            var result = firstNumber + secondNumber;
            PrintResult(result);
        }

        private static void PrintResult(int result)
        {
            var mesagge = (result > 0 && result <= 10) ? Messages.LessThanEleven : Messages.GreaterThanTen;
            Console.WriteLine(string.Format("The sum is: {0} and is in range {1}", result, mesagge));
        }
    }

    public static class Messages
    {
        public const string LessThanEleven = "Value between 0 and 10";
        public const string GreaterThanTen = "Value between 11 and 20";
    }

}
