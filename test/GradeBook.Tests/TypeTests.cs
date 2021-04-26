using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {

        [Fact]
        public void CsharpCanPassByRef()
        {

            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetNameRef(ref book1, "New Name");

            //assert
            Assert.Equal("New Name", book1.Name);
           
        }

        private void GetBookSetNameRef(ref Book book, string name)
        {
            book = new Book(name);
            book.Name = name;
        }

        [Fact]
        public void CsharpIsPassByValue()
        {

            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            //assert
            Assert.Equal("Book 1", book1.Name);
           
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
            book.Name = name;
        }

        [Fact]
        public void CanSetNameFromRef()
        {

            //arrange
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            //assert
            Assert.Equal("New Name", book1.Name);
           
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDiffObjs()
        {

            //arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            //assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
           

        }

        [Fact]
        public void TwoVarsRefSameObj()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            
        }
        Book GetBook(string name){
                return new Book(name);
            }
    }
    
}
