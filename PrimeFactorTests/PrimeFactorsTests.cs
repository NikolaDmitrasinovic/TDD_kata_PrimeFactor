using PrimeFactor;

namespace PrimeFactorTests
{
    public class PrimeFactorsTests
    {
        private List<int> CreateList(params int[] ints)
        {
            List<int> intsList = [];

            foreach (int i in ints)
            {
                intsList.Add(i);
            }

            return intsList;
        }

        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal(CreateList(), PrimeFactors.Generate(1));
        }

        [Fact]
        public void Test2()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal(CreateList(2), PrimeFactors.Generate(2));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(CreateList(3), PrimeFactors.Generate(3));
        }

        [Fact]
        public void Test4()
        {
            Assert.Equal(CreateList(2, 2), PrimeFactors.Generate(4));
        }

        [Fact]
        public void Test5()
        {
            Assert.Equal(CreateList(2, 3), PrimeFactors.Generate(6));
        }

        [Fact]
        public void Test6()
        {
            Assert.Equal(CreateList(2, 2, 2), PrimeFactors.Generate(8));
        }
    }
}