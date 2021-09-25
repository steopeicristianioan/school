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

        public Course getByID(int id)
        {
            string sql = "select * from course where id = @id";
            List<Course> courses = db.LoadData<Course, dynamic>(sql, new { id = id }, connection);
            if (courses.Count == 0)
                return null;
            return courses[0];
        }
        public Course getByName(string name)
        {
            string sql = "select * from course where name = @n";
            List<Course> courses = db.LoadData<Course, dynamic>(sql, new { n = name }, connection);
            if (courses.Count == 0)
                return null;
            return courses[0];
        }
    }
}
