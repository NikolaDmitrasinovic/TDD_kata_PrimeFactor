using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
using static PrimeFactors.PrimeFactors;

namespace PrimeFactorTests
{
    public class PrimeFactorsTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal([], Generate(1));
        }

        [Fact]
        public void Test2()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal([2], Generate(2));
        }

        [Fact]
        public void Test3()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal([3], Generate(3));
        }

        [Fact]
        public void Test4()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal([2, 2], Generate(4));
        }

        // first try code ( followed the guide)
        //private List<int> CreateList(params int[] ints)
        //{
        //    List<int> intsList = [];

        //    foreach (int i in ints)
        //    {
        //        intsList.Add(i);
        //    }

        //    return intsList;
        //}

        //[Fact]
        //public void Test1()
        //{
        //    // Arrange

        //    // Act

        //    // Assert
        //    Assert.Equal(CreateList(), Generate(1));
        //}

        //[Fact]
        //public void Test2()
        //{
        //    // Arrange

        //    // Act

        //    // Assert
        //    Assert.Equal(CreateList(2), Generate(2));
        //}

        //[Fact]
        //public void Test3()
        //{
        //    Assert.Equal(CreateList(3), Generate(3));
        //}

        //[Fact]
        //public void Test4()
        //{
        //    Assert.Equal(CreateList(2, 2), Generate(4));
        //}

        //[Fact]
        //public void Test5()
        //{
        //    Assert.Equal(CreateList(2, 3), Generate(6));
        //}

        //[Fact]
        //public void Test6()
        //{
        //    Assert.Equal(CreateList(2, 2, 2), Generate(8));
        //}

        //[Fact]
        //public void Test7()
        //{
        //    Assert.Equal(CreateList(3, 3), Generate(9));
        //}
    }
}