using System;
using Xunit;

namespace GradeBook.tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var book = new Book(""); //Is it legal to not have a name? This would be something to ask the business owner.

            //Act
            var actual = x + y;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
