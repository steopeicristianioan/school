using school.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace school.repository
{
    public class BookRepository : Repository<Book>
    {
        public BookRepository(string dbConnection)
        {
            connection = CommonMethods.getConnectionString(dbConnection);
            readAll();
        }

        public override void readAll()
        {
            string sql = "select * from book";
            all = db.LoadData<Book, dynamic>(sql, new { }, connection);
        }
        public override void printAll()
        {
            foreach(Book book in all)
                Console.WriteLine(book);
        }


    }
}
