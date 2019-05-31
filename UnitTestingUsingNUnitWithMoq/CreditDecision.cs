using System;

namespace UnitTestingUsingNUnitWithMoq
{
    public class CreditDecision
    {
        public CreditDecision()
        {
        }

        public string MakeCreditDecision(int creditScore)
        {
            var service = new CreditDecisionService();
            return service.GetCreditDecision(creditScore);
        }
    }
}