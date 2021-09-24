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

        public List<Book> getByName(string name)
        {
            string sql = "select * from book where book_name like '%n%' ";
            return db.LoadData<Book, dynamic>(sql, new { n=name}, connection);
        }
        public Book getBookByName(string name)
        {
            string sql = "select * from book where book_name = @n ";
            List <Book> get = db.LoadData<Book, dynamic>(sql, new { n = name }, connection);
            if (get.Count == 0)
                return null;
            return get[0];
        }
        public void updateBorrower(int borrowerID, int bookID)
        {
            DateTime time = DateTime.Now;
            string sql = "update book set person_id = @borrowerID, created_at = @time where id = @bookID";
            db.LoadData<Book, dynamic>(sql, new { borrowerID = borrowerID, time = time, bookID = bookID }, connection);
        }

    }
}
