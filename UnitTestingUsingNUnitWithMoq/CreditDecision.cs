using System;

namespace UnitTestingUsingNUnitWithMoq
{
    public class CreditDecision
    {
        readonly ICreditDecisionService creditDecisionService;

        // This assumes that there is an existing ICreditDecisionService interface
        // and that CreditDecisionService implements it.
        public CreditDecision(ICreditDecisionService creditDecisionService)
        {
            this.creditDecisionService = creditDecisionService;
        }

        public string MakeCreditDecision(int creditScore)
        {
            return creditDecisionService.GetCreditDecision(creditScore);
        }
    }
}