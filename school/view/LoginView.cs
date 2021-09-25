using school.model;
using school.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace school.view
{
    class LoginView
    {
        private int cardNumber;
        private Person_Id_CardRepository Crepository;
        private PersonRepository Prepository;
        private MenuView menuView;

        private void play()
        {
            bool ok;
            do
            {
                Console.WriteLine("\n--------------------Login--------------------");
                Console.WriteLine("Insert your card number");
                Console.WriteLine("Insert -1 to exit\n");
                string input = Console.ReadLine();
                ok = int.TryParse(input, out cardNumber);
                if (ok)
                {
                    if (cardNumber == -1)
                    {
                        Console.WriteLine("Goodbye!");
                        return;
                    }
                    Person_Id_Card card = Crepository.getByNumber(cardNumber);
                    Person person = Prepository.getByID(card.Person_ID);
                    if (card == null)
                        Console.WriteLine("There is no card asociated with this number");
                    else menuView = new MenuView(person);
                }
            } while (ok);
        }

        public LoginView()
        {
            Crepository = new Person_Id_CardRepository("Test");
            Prepository = new PersonRepository("Test");
            play();
        }
    }
}
