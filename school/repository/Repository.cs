using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLibrary;
using Microsoft.Extensions.Configuration;

namespace school.repository
{
    public abstract class Repository<T>
    {
        protected List<T> all;
        public List<T> All { get => this.all; }

        protected string connection;

        protected MySqlDataAccess db = new MySqlDataAccess();

        public abstract void readAll();
        public abstract void printAll();
    }
}
