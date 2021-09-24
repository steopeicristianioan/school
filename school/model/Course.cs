using System;
using System.Collections.Generic;
using System.Text;

namespace school.model
{
    public class Course
    {
        private int id;
        private string name;
        private string department;

        //setters & getters
        #region
        public int ID { get => this.id; set => this.id = value; }
        public string Name { get => this.name; set => this.name = value; }
        public string Department { get => this.department; set => this.department = value; }
        #endregion

        public Course() { }
        public Course(int id, string name, string department)
        {
            this.id = id;
            this.name = name;
            this.department = department;
        }

        public override string ToString()
        {
            return name + " - " + department;
        }
        public override bool Equals(object obj)
        {
            Course other = (Course)obj;
            return id == other.id;
        }
        public override int GetHashCode()
        {
            return id;
        }
    }
}
