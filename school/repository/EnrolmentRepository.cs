using school.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace school.repository
{
    public class EnrolmentRepository : Repository<Enrolment>
    {
        public EnrolmentRepository(string dbConnection)
        {
            connection = CommonMethods.getConnectionString(dbConnection);
            readAll();
        }

        public override void readAll()
        {
            string sql = "select * from enrolment";
            all = db.LoadData<Enrolment, dynamic>(sql, new { }, connection);
        }
        public override void printAll()
        {
            foreach(Enrolment enrolment in all)
                Console.WriteLine(enrolment);
        }
    }
}
