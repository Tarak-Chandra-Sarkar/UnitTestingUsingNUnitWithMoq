using System;

namespace UnitTestingUsingNUnitWithMoq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var creditDecision = new CreditDecision();
            var result = creditDecision.MakeCreditDecision(700);
            Console.WriteLine($"Credit Decision = {result}"); 


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
