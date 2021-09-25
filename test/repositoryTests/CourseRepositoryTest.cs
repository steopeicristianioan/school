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
        [Fact]
        public void testGetById()
        {
            CourseRepository repository = new CourseRepository("Test");
            Assert.Equal("Algoritmi vectori", repository.getByID(1).Name);
        }
        [Fact]
        public void testGetByName()
        {
            CourseRepository repository = new CourseRepository("Test");
            Assert.Equal(1, repository.getByName("Algoritmi vectori").ID);
        }
    }
}
