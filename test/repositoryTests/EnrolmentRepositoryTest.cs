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
        [Fact]
        public void testGetEnrolmentsByPersonID()
        {
            EnrolmentRepository repository = new EnrolmentRepository("Test");
            Assert.Equal(2, repository.getEnrolmentsByPerson(1).Count);
        }
        [Fact]
        public void testAdd()
        {
            EnrolmentRepository repository = new EnrolmentRepository("Test");
            repository.addEnrolment(1, 2, DateTime.Now);
            Assert.Equal(3, repository.getEnrolmentsByPerson(1).Count);
        }
        [Fact]
        public void testRemove()
        {
            EnrolmentRepository repository = new EnrolmentRepository("Test");
            repository.removeEnrolment(1, 2);
            Assert.Equal(2, repository.getEnrolmentsByPerson(1).Count);
        }
    }
}
