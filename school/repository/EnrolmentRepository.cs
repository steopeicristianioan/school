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
            all = new List<Enrolment>();
            string sql = "select * from enrolment";
            all = db.LoadData<Enrolment, dynamic>(sql, new { }, connection);
        }
        public override void printAll()
        {
            foreach(Enrolment enrolment in all)
                Console.WriteLine(enrolment);
        }

        public List<Enrolment> getEnrolmentsByPerson(int person_ID)
        {
            string sql = "select * from enrolment where person_id = @id";
            return db.LoadData<Enrolment, dynamic>(sql, new { id = person_ID }, connection);
        }
        public void addEnrolment(int person_ID, int course_ID, DateTime time)
        {
            string sql = "insert into enrolment(person_id, course_id, created_at) values" +
                "(@person, @course, @time)";
            db.SaveData(sql, new { person = person_ID, course = course_ID, time = time }, connection);
            readAll();
        }
        public void removeEnrolment(int person_ID, int course_ID)
        {
            string sql = "delete from enrolment where person_id = @person and course_id = @course";
            db.SaveData(sql, new { person = person_ID, course = course_ID }, connection);
            readAll();
        }
    }
}
