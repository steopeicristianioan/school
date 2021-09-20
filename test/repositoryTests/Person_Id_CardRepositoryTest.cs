using school.repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace test.repositoryTests
{
    public class Person_Id_CardRepositoryTest
    {
        [Fact]
        public void testGetAll()
        {
            Person_Id_CardRepository repository = new Person_Id_CardRepository("Test");
            Assert.Equal(4, repository.All.Count);
        }
    }
}
