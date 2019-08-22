using System;
using Xunit;

namespace NCrunch.Debug
{
    public class AnnuityTests
    {
        [Theory] // a theory in xUnit is a [Test] that takes parameters
        [InlineData(1, 100, 5, 105)]
        public void ComputesExpectedFutureValue(int n, decimal CF, decimal i, decimal FVA)
        {
            var actual = Annuity.ComputeFutureValue(n, CF, i);
            Assert.Equal(FVA, actual);
        }
    }
}
