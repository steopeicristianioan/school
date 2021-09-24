using school.model;
using school.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace school.view
{
    class EnrolmentView
    {
        private int option;
        private int person_ID;
        private EnrolmentRepository Erepository;
        private CourseRepository Crepository;

        private void Menu()
        {
            Console.WriteLine("Insert 1 to view your enrolments");
            Console.WriteLine("Insert 2 to enroll to a new course");
            Console.WriteLine("Insert 3 to withdraw from a course");
            Console.WriteLine("");
        }
        private void loadViewEnrolmentsMenu()
        {
            List<Enrolment> enrolments = Erepository.getEnrolmentsByPerson(person_ID);
            if(enrolments.Count == 0)
            {
                Console.WriteLine("You don t have any enrolments");
                return;
            }
            foreach(Enrolment enrolment in enrolments)
                Console.WriteLine(Crepository.getByID(enrolment.Course_ID) + 
                    "; Enrolled at: " + enrolment.Created_At.ToString("f"));
            Console.WriteLine("");
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
                        loadViewEnrolmentsMenu();
                }
            } while (ok);
        }

        public EnrolmentView(int person_ID)
        {
            this.person_ID = person_ID;
            Erepository = new EnrolmentRepository("Test");
            Crepository = new CourseRepository("Test");

            play();
        }
    }
}
