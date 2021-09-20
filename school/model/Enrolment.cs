using System;
using System.Collections.Generic;
using System.Text;

namespace school.model
{
    public class Enrolment
    {
        private int person_id;
        private int course_id;
        private DateTime created_at;

        //getters & setters
        #region
        public int Person_ID { get => this.person_id; set => this.person_id = value; }
        public int Course_ID { get => this.course_id; set => this.course_id = value; }
        public DateTime Created_At { get => this.created_at; set => this.created_at = value; }
        #endregion

        public Enrolment() { }
        public Enrolment(int person_id, int course_id, DateTime created_at)
        {
            this.person_id = person_id;
            this.course_id = course_id;
            this.created_at = created_at;
        }

        public override string ToString()
        {
            return person_id.ToString() + "," + course_id.ToString();
        }
        public override bool Equals(object obj)
        {
            Enrolment other = (Enrolment)obj;
            return person_id == other.person_id && course_id == other.course_id;
        }
        public override int GetHashCode()
        {
            return person_id + course_id;
        }
    }
}
