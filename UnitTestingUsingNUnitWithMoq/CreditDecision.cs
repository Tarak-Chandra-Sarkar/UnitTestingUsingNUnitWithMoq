using System;

namespace UnitTestingUsingNUnitWithMoq
{
    public class CreditDecision
    {
        readonly CreditDecisionService creditDecisionService;

        // We have made this loosely coupled but can not inject Moq instance instead of CreditDecisionService
        public CreditDecision(CreditDecisionService creditDecisionService)
        {
            this.creditDecisionService = creditDecisionService;
        }

        public string MakeCreditDecision(int creditScore)
        {
            return creditDecisionService.GetCreditDecision(creditScore);
        }
    }
}