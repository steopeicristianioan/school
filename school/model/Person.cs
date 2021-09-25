using System;
using System.Collections.Generic;
using System.Text;

namespace school.model
{
    public class Person
    {
        private int id;
        private string first_name;
        private string last_name;
        private string email;
        private int age;
        private string role;

        //getters & setters
        #region
        public int ID { get => this.id; set => this.id = value; }
        public string First_Name { get => this.first_name; set => this.first_name = value; }
        public string Last_Name { get => this.last_name; set => this.last_name = value; }
        public string Email { get => this.email; set => this.email = value; }
        public int Age { get => this.age; set => this.age = value; }
        public string Role { get => this.role; set => this.role = value; }
        #endregion

        public Person() { }
        public Person(int id, string first_name, string last_name, string email, int age, string role)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.age = age;
            this.role = role;
        }

        public override string ToString()
        {
            return this.first_name + " " + this.last_name;
        }
        public override bool Equals(object obj)
        {
            Person other = (Person)obj;
            return id == other.id;
        }
        public override int GetHashCode()
        {
            return id;
        }
    }
}
