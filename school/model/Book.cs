using System;
using System.Collections.Generic;
using System.Text;

namespace school.model
{
    public class Book
    {
        private int id;
        private int person_id;
        private string book_name;
        private DateTime created_at;

        //setters & getters
        #region
        public int ID { get => this.id; set => this.id = value; }
        public int Person_ID { get => this.person_id; set => this.person_id = value; }
        public string Book_Name { get => this.book_name; set => this.book_name = value; }
        public DateTime Created_At { get => this.created_at; set => this.created_at = value; }
        #endregion

        public Book() { }
        public Book(int id, int person_id, string book_name, DateTime created_at)
        {
            this.id = id;
            this.person_id = person_id;
            this.book_name = book_name;
            this.created_at = created_at;
        }

        public override string ToString()
        {
            return book_name + ((person_id == 5) ? " - not borrowed" : " - borrowed");
        }
        public override bool Equals(object obj)
        {
            Book other = (Book)obj;
            return id == other.id;
        }
        public override int GetHashCode()
        {
            return id;
        }
    }
}
