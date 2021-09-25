using school.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace school.view
{
    class MenuView
    {
        private int option;
        private Person person;

        private BookView bookView;
        private EnrolmentView enrolmentView;

        private void Menu()
        {
            Console.WriteLine("\n--------------------- Main menu - " + person + " ---------------------");
            Console.WriteLine("Insert 1 to open book menu");
            Console.WriteLine("Insert 2 to open course menu");
            Console.WriteLine("Insert anything else to log out\n");
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
                        bookView = new BookView(person.ID);
                    else if (option == 2)
                        enrolmentView = new EnrolmentView(person.ID);
                    else Console.WriteLine("Goodbye\n");
                }
                else Console.WriteLine("Goodbye\n");
            } while (ok);
        }

        public MenuView(Person person)
        {
            this.person = person;
            play();
        }
    }
}
