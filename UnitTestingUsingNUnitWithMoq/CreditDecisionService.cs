using System;

namespace UnitTestingUsingNUnitWithMoq
{
    public class CreditDecisionService
    {
        public CreditDecisionService()
        {
        }

        public string GetCreditDecision(int creditScore)
        {
            if (creditScore < 550)
                return "Declined";
            else if (creditScore <= 675)
                return "Maybe";
            else
                return "We look forward to doing business with you!";
        }
    }
}