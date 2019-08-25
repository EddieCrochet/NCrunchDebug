using System;
using Xunit;
using Xunit.Sdk;

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
        [Fact]
        public void AssertsTrue() => Assert.True(true);
    }

    //for this stage of dev it is fine to have these two classes in the same document but we will
    //eventually want to separate them.
    public class Annuity
    {
        public static decimal ComputeFutureValue(int n, decimal CF, decimal i)
        {
            return 105;
            //just return correct answer for now to play with debug
        }
    }
}
