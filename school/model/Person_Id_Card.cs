using System;
using System.Collections.Generic;
using System.Text;

namespace school.model
{
    public class Person_Id_Card
    {
        private int id;
        private int person_id;
        private int card_number;

        //setters & getters
        #region
        public int ID { get => this.id; set => this.id = value; }
        public int Person_ID { get => this.person_id; set => this.person_id = value; }
        public int Card_Number { get => this.card_number; set => this.card_number = value; }
        #endregion

        public Person_Id_Card() { }
        public Person_Id_Card(int id, int person_id, int card_number)
        {
            this.id = id;
            this.person_id = person_id;
            this.card_number = card_number;
        }

        public override string ToString()
        {
            return id.ToString();
        }
        public override bool Equals(object obj)
        {
            Person_Id_Card other = (Person_Id_Card)obj;
            return id == other.id;
        }
        public override int GetHashCode()
        {
            return id;
        }
    }
}
