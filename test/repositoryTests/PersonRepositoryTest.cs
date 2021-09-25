using school.model;
using school.repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace test
{
    
    public  class PersonRepositoryTest
    {
        [Fact]
        public void testAllPersons()
        {
            PersonRepository personRepository = new PersonRepository("Test");
            List<Person> persons = personRepository.All;
            Assert.Equal("Cristian", persons[0].First_Name);
            Assert.Equal("professor", persons[2].Role);
        }
        [Fact]
        public void testGetProffesors()
        {
            PersonRepository personRepository = new PersonRepository("Test");
            foreach (Person person in personRepository.getProffesors())
                Console.WriteLine(person);
            Assert.Single(personRepository.getProffesors());
        }
        [Fact]
        public void testGetByID()
        {
            PersonRepository repository = new PersonRepository("Test");
            Assert.Null(repository.getByID(0));
            Assert.Equal("Cristian", repository.getByID(1).First_Name);
        }
    }
}
