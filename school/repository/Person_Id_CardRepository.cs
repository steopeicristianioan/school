using school.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace school.repository
{
    public class Person_Id_CardRepository : Repository<Person_Id_Card>
    {
        public Person_Id_CardRepository(string dbConnection)
        {
            connection = CommonMethods.getConnectionString(dbConnection);
            readAll();
        }

        public override void readAll()
        {
            string sql = "select * from person_id_card";
            all = db.LoadData<Person_Id_Card, dynamic>(sql, new { }, connection);
        }
        public override void printAll()
        {
            foreach (Person_Id_Card person_Id_Card in all)
                Console.WriteLine(person_Id_Card);
        }
    }
}
