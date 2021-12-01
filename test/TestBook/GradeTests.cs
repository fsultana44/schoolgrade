using System;
using Gradebook;
using Xunit;

namespace TestBook
{
    public class GradeTests
    {
        [Fact]
        public void CalculateAverageGrade()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(56.7);
            book.AddGrade(78.99);
            book.AddGrade(50.5);
            // act
            var result = book.GetStatistics();
            //assert
            Assert.Equal(26.33, result.Average);
            Assert.Equal(78.99, result.High);
            Assert.Equal(1.79, result.Low,2);

        }
    }
}
