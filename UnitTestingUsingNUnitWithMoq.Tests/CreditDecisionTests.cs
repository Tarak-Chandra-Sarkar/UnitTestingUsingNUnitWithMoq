using System;
using Moq;
using NUnit.Framework;

namespace UnitTestingUsingNUnitWithMoq.Tests
{
    [TestFixture]
    public class CreditDecisionTests
    {
        Mock<ICreditDecisionService> mockCreditDecisionService;

        CreditDecision systemUnderTest;

        [TestCase(100, "Declined")]
        [TestCase(549, "Declined")]
        [TestCase(550, "Maybe")]
        [TestCase(674, "Maybe")]
        [TestCase(675, "We look forward to doing business with you!")]
        public void MakeCreditDecision_Always_ReturnsExpectedResult(int creditScore, string expectedResult)
        {
            mockCreditDecisionService = new Mock<ICreditDecisionService>(MockBehavior.Strict);
            mockCreditDecisionService.Setup(p => p.GetCreditDecision(creditScore)).Returns(expectedResult);

            systemUnderTest = new CreditDecision(mockCreditDecisionService.Object);
            var result = systemUnderTest.MakeCreditDecision(creditScore);

            Assert.That(result, Is.EqualTo(expectedResult));

            mockCreditDecisionService.VerifyAll();
        }
    }
}
