using PrimeFactor;

namespace PrimeFactorTests
{
    public class PrimeFactorsTests
    {
        private List<int> CreateList()
        {
            return [];
        }

        [Fact]
        public void Test1()
        {
            // Act

            // Assert
            Assert.Equal(CreateList(), PrimeFactors.Generate(1));
        }        
    }
}