using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniChallege
{
    class Program
    {
        static void Main(string[] args)
        {
            Student newstudent = new Student("Joe", "Blogs", 1988, 12345);
            newstudent.GetInfo();
            Console.WriteLine();

            Teacher teach = new Teacher("Mr", "Butt", 1912, "Butt4lyfe", "Squats");
            teach.GetInfo();

            List<Person> PersonList = new List<Person>
            {
                teach,
                newstudent
            };

            //The menu options using a boolean value and while loop
            Console.WriteLine("Welcome to Swinburne Super-dooper Admin Menu System 2018.");

            bool Menu = true;

            while (Menu)
            {
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("1. Create Student");
                Console.WriteLine("2. Create Teacher");
                Console.WriteLine("3. Create Admin");
                Console.WriteLine("4. View People");
                Console.WriteLine("5. Exit Console");

                int menu;

                //A while loop to handle incorrect menu entries
                while (!int.TryParse(Console.ReadLine(), out menu) || menu < 1 || menu > 5)
                {
                    Console.WriteLine("Invalid input. Enter a number from 1 to 5: ");
                }

                //The menu using a switch statement
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Enter New Student details: (First name, surname, year of birth (as yyyy) and student ID: ");

                        PersonList.Add(new Student(
                        Console.ReadLine(),
                        Console.ReadLine(),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine())));
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("Enter New Teacher details: (First name, surname, year of birth (as yyyy), Username and Expertise: ");

                        PersonList.Add(new Teacher(
                        Console.ReadLine(),
                        Console.ReadLine(),
                        int.Parse(Console.ReadLine()),
                        Console.ReadLine(),
                        Console.ReadLine()));
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("Enter New Teacher details: (First name, surname, year of birth (as yyyy), Username and Expertise: ");

                        PersonList.Add(new Admin(
                        Console.ReadLine(),
                        Console.ReadLine(),
                        int.Parse(Console.ReadLine()),
                        Console.ReadLine(),
                        int.Parse(Console.ReadLine())));
                        Console.WriteLine();
                        break;

                    case 4:

                        foreach (var item in PersonList)
                        {
                            //IEnumerable<Person> PeopleList = PersonList.Cast<Person>();
                            //List<Person> PeopleList = PersonList.Cast<Person>().ToList();
                            //Console.WriteLine(PeopleList.Count);
                            //Console.WriteLine(PersonList.Count);
                            Console.WriteLine(item.GetInfo());
                            Console.WriteLine(item);
                            //PersonList.Cast(Person);
                        }
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine("Goodbye");
                        Menu = false;
                        break;

                    default:
                        Console.WriteLine("Error!");
                        Console.WriteLine();
                        break;
                }
            }

            Console.WriteLine("Press any key to exit");

            //Console.WriteLine("Enter New Student details: (First name, surname, year of birth (as yyyy) and student ID");

            //PersonList.Add(new Student(
            //    Console.ReadLine(),
            //    Console.ReadLine(),
            //    int.Parse(Console.ReadLine()),
            //    int.Parse(Console.ReadLine())));

            //Console.WriteLine("Enter New Student details: (First name, surname, year of birth (as yyyy) and student ID");

            //PersonList.Add(new Student(
            //Console.ReadLine(),
            //Console.ReadLine(),
            //int.Parse(Console.ReadLine()),
            //int.Parse(Console.ReadLine())));

            ////PersonList.Add(testStu);

            //foreach (Person p in PersonList)
            //{
            //    ;
            //}


            //Console.WriteLine(PersonList);

            //PersonList.ForEach(Console.WriteLine);


            //RESOURCES
            //http://www.java2s.com/Code/CSharp/Language-Basics/Switchbasedconsolemenu.htm

            //https://stackoverflow.com/questions/8933434/how-to-cast-listobject-to-listsomethingelse

            //https://stackoverflow.com/questions/4261153/multiple-params-in-a-list-in-c-how-to-create-without-a-class

            //https://stackoverflow.com/questions/15456845/getting-a-list-item-by-index
        }
    }
}
