using school.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace school.repository
{
    public class CourseRepository : Repository<Course>
    {
        public CourseRepository(string dbConnection)
        {
            connection = CommonMethods.getConnectionString(dbConnection);
            readAll();
        }

        public override void readAll()
        {
            string sql = "select * from course";
            all = db.LoadData<Course, dynamic>(sql, new { }, connection);
        }
        public override void printAll()
        {
            foreach(Course course in all)
                Console.WriteLine(course);
        }
    }
}
