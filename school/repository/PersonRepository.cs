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
            readAll();
        }

        public override void readAll()
        {
            string sql = "select * from person";
            all = db.LoadData<Person, dynamic>(sql, new { }, connection);
        }
        public override void printAll()
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
