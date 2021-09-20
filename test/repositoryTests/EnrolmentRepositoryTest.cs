using school.repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace test.repositoryTests
{
    public class EnrolmentRepositoryTest
    {
        [Fact]
        public void testGetAll()
        {
            EnrolmentRepository repository = new EnrolmentRepository("Test");
            Assert.Equal(4, repository.All.Count);
        }
    }
}
