using school.repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace test.repositoryTests
{
    public class CourseRepositoryTest
    {
        [Fact]
        public void testGetAll()
        {
            CourseRepository repository = new CourseRepository("Test");
            Assert.Equal(3, repository.All.Count);
        }
    }
}
