using static PrimeFactors.PrimeFactors;

namespace PrimeFactorTests
{
    public class PrimeFactorsTests
    {
        [Fact]
        public void Should_ReturnEmptyList_For1()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal([], Generate(1));
        }

        [Fact]
        public void Should_ReturnCorrectList_For2()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal([2], Generate(2));
        }

        [Fact]
        public void Should_ReturnCorrectList_For3()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal([3], Generate(3));
        }

        [Fact]
        public void Should_ReturnCorrectList_For4()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal([2, 2], Generate(4));
        }

        [Fact]
        public void Should_ReturnCorrectList_For6()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal([2, 3], Generate(6));
        }

        [Fact]
        public void Should_ReturnCorrectList_For8()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal([2, 2, 2], Generate(8));
        }

        [Fact]
        public void Should_ReturnCorrectList_For9()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal([3, 3], Generate(9));
        }
    }
}
