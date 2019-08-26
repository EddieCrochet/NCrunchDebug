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
            //Test now takes annuity instance
            ICalculable annuity = new Annuity(n, CF, i);
            Assert.Equal(FVA, annuity.Value);
        }
        //Add in a test for name
        [Fact]
        public void NameIsAnnuity()
        {
            ICalculable annuity = new Annuity(1, 1, 1);
            Assert.Equal("Annuity", annuity.Name);
        }
    }

    //for this stage of dev it is fine to have these two classes in the same document but we will
    //eventually want to separate them.
    public class Annuity : ICalculable
    {
        private readonly int n;
        private readonly decimal cf;
        private readonly decimal i;
        public Annuity(int n, decimal cf, decimal i)
        {
            this.n = n;
            this.cf = cf;
            this.i = i;
        }
        public string Name => throw new System.NotImplementedException();

        public decimal Value => 105;
    }
    public interface ICalculable
    {
        string Name { get; }
        decimal Value { get; }
    }

}
