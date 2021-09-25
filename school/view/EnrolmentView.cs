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
        private List<Course> courses;
        private List<Enrolment> enrolments;

        private void Menu()
        {
            Console.WriteLine("\n----------------Enrolment Menu--------------");
            Console.WriteLine("Insert 1 to view your enrolments");
            Console.WriteLine("Insert 2 to enroll to a new course");
            Console.WriteLine("Insert 3 to withdraw from a course");
            Console.WriteLine("Insert anything else to return to main menu");
            Console.WriteLine("");
        }
        private void loadViewEnrolmentsMenu()
        {
            if(enrolments.Count == 0)
            {
                Console.WriteLine("You don t have any enrolments");
                return;
            }
           for(int i = 0; i<enrolments.Count; i++)
                Console.WriteLine(courses[i] + "; Enrolled at: " + 
                    enrolments[i].Created_At.ToString("f"));
            Console.WriteLine("");
        }
        private void loadNewEnrolMenu()
        {
            Console.WriteLine("Insert the name of the course you want to enroll in");
            string input = Console.ReadLine();
            Course course = Crepository.getByName(input);
            if(course == null)
            {
                Console.WriteLine("There is no such course");
                return;
            }
            bool contains = false;
            foreach (Course c in courses)
                if (c.Equals(course))
                {
                    contains = true;
                    break;
                }
            if (contains)
                Console.WriteLine("You are already enrolled in this course!");
            else
            {
                Erepository.addEnrolment(person_ID, course.ID, DateTime.Now);
                Console.WriteLine("Succesfully enrolled in " + course.Name + "!");
                updateLists();
            }
        }
        private void loadWithdrawFromEnrolment()
        {
            Console.WriteLine("Insert the name of the course you want to withdraw from");
            string input = Console.ReadLine();
            Course course = Crepository.getByName(input);
            if (course == null)
            {
                Console.WriteLine("There is no such course");
                return;
            }
            bool contains = false;
            foreach (Course c in courses)
                if (c.Equals(course))
                {
                    contains = true;
                    break;
                }
            if (!contains)
                Console.WriteLine("You are not enrolled in that course!");
            else
            {
                Erepository.removeEnrolment(person_ID, course.ID);
                Console.WriteLine("Succesfully withdrawn from " + course.Name + "!");
                updateLists();
            }
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
                    else if (option == 2)
                        loadNewEnrolMenu();
                    else if (option == 3)
                        loadWithdrawFromEnrolment();
                    else ok = false;
                }
            } while (ok);
        }
        private void updateLists()
        {
            enrolments = Erepository.getEnrolmentsByPerson(person_ID);
            courses = new List<Course>();
            foreach (Enrolment enrolment in enrolments)
                courses.Add(Crepository.getByID(enrolment.Course_ID));
        }
        public EnrolmentView(int person_ID)
        {
            this.person_ID = person_ID;
            Erepository = new EnrolmentRepository("Test");
            Crepository = new CourseRepository("Test");

            updateLists();
            play();
        }
    }
}
