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

        [Fact]
        public void testGetByName()
        {
            BookRepository repository = new BookRepository("Test");
            Assert.Equal(4, repository.getByName("Culegere").Count);
        }
        [Fact]
        public void testUpdateBorrower()
        {
            BookRepository repository = new BookRepository("Test");
            repository.updateBorrower(4, 1);
            repository.readAll();
            Assert.Equal(4, repository.All[0].Person_ID);
        }

    }
}
