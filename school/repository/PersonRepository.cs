using school.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace school.repository
{
    public class PersonRepository : Repository<Person>
    {
        public PersonRepository(string dbConnection)
        {
            connection = CommonMethods.getConnectionString(dbConnection);
            readAllPersons();
        }

        public void readAllPersons()
        {
            string sql = "select * from person";
            all = db.LoadData<Person, dynamic>(sql, new { }, connection);
        }
        public void printAllPersons()
        {
            foreach(Person person in all)
                Console.WriteLine(person);
        }
        public List<Person> getProffesors()
        {
            string sql = "select * from person where role = 'professor';";
            return db.LoadData<Person, dynamic>(sql, new { }, connection);
        }
    }
}
