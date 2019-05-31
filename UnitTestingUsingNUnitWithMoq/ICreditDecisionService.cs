using System;

namespace UnitTestingUsingNUnitWithMoq
{
    public interface ICreditDecisionService
    {
        string GetCreditDecision(int creditScore);
    }
}