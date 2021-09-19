using school.model;
using school.repository;
using System;

namespace school
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonRepository personRepository = new PersonRepository("Test");
            foreach (Person person in personRepository.getProffesors())
                Console.WriteLine(person);
        }
    }
}
