using school.repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace test.repositoryTests
{
    public class BookRepositoryTest
    {
        [Fact]
        public void testGetAll()
        {
            BookRepository repository = new BookRepository("Test");
            Assert.Equal(4, repository.All.Count);
        }
    }
}
