using Gradebook;
using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(56.7);
            book.AddGrade(78.99);
            book.AddGrade(50.5);

            //act
            //var stats =book.ShowStatistics();


        }
    }
}
