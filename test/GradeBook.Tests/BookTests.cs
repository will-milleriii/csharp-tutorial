using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookAverageTest()
        {

            //arrange
            var book = new Book("");
            book.AddGrade(89.0);
            book.AddGrade(92.5);
            book.AddGrade(75.5);
         

            //act
            var result = book.GetStatistics();
        
            //assert
            Assert.Equal(85.7, result.Average, 1);
            Assert.Equal(92.5, result.High, 1);
            Assert.Equal(75.5, result.Low, 1);
            Assert.Equal('B', result.Letter);


        }
    }
}
