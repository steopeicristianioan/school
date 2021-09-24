using school.model;
using school.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace school.view
{
    class BookView
    {
        private int person_ID;
        private int option;
        private BookRepository repository;

        private void Menu()
        {
            Console.WriteLine("Insert 1 to search books (by name)");
            Console.WriteLine("Insert 2 to borrow specific book");
            Console.WriteLine("Insert 3 to return a specific book");
            Console.WriteLine("");
        }
        private void loadSearchMenu()
        {
            Console.WriteLine("Insert book name");
            string name = Console.ReadLine();
            List<Book> books = repository.getByName(name);
            if (books.Count == 0)
                Console.WriteLine("No books match your search");
            else
                foreach (Book book in books)
                    Console.WriteLine(book);
            Console.WriteLine("");
        }
        private void loadBorrowMenu()
        {
            Console.WriteLine("Insert the book name of the book that you want to borrow");
            string name = Console.ReadLine();
            Book book = repository.getBookByName(name);
            if(book == null)
            {
                Console.WriteLine("There is no such book");
                return;
            }
            if(book.Person_ID != 5)
            {
                Console.WriteLine("The book " + name + " is borrowed now");
                return;
            }
            repository.updateBorrower(person_ID, book.ID);
            repository.readAll();
            Console.WriteLine("The book " + name + " has been successfully borrowed \n");
        }
        private void loadReturnMenu()
        {
            Console.WriteLine("Insert the book name of the book that you want to return");
            string name = Console.ReadLine();
            Book book = repository.getBookByName(name);
            if (book == null)
            {
                Console.WriteLine("There is no such book");
                return;
            }
            if(book.Person_ID != person_ID)
            {
                Console.WriteLine("The book " + name + " is not borrowed by you");
                return;
            }
            repository.updateBorrower(5, book.ID);
            repository.readAll();
            Console.WriteLine("The book " + name + " has been successfully returned \n");
        }

        private void play()
        {
            bool ok;
            do
            {
                Menu();
                string input = Console.ReadLine();
                ok = int.TryParse(input, out option);
                if (ok)
                {
                    if (option == 1)
                        loadSearchMenu();
                    else if (option == 2)
                        loadBorrowMenu();
                    else if (option == 3)
                        loadReturnMenu();
                }
            } while (ok);
        }
        public BookView(int person_ID)
        {
            this.person_ID = person_ID;
            repository = new BookRepository("Test");

            play();
        }
    }
}
