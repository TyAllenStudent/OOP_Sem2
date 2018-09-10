using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniChallege
{


    public class Person
    {
        public string FName { get; set; }
        public string SName { get; set; }
        public int YearOfBirth { get; set; }

        public string GetName()
        {
            string Name = $"{FName} {SName}";
            return Name;
        }

        public int GetAge()
        {
            int Age = YearOfBirth - DateTime.Now.Year;
            return Age;
        }

        public Person(string firstname, string surname, int yob)
        {
            FName = firstname;
            SName = surname;
            YearOfBirth = yob;
        }

        public virtual string GetInfo()
        {
            return ($"Name: {FName} {SName} Birth Year: {YearOfBirth} ");
        }
    }

    public class Student : Person
    {
        public int Id { get; set; }

        public override string GetInfo()
        {
            return ($"Name: {FName} {SName}" +
            $"Birth Year: {YearOfBirth}" +
            $"Student ID: {Id}");
        }

        public Student(string firstname, string surname, int yob, int id)
            : base(firstname, surname, yob)
        {
            Id = id;
        }
    }

    public class Staff : Person
    {
        public string Username { get; set; }

        public override string GetInfo()
        {
            return ($"Username: {Username}, Name: {FName} {SName} BirthYear: {YearOfBirth} ");
        }

        public Staff(string firstname, string surname, int yob, string username)
            : base(firstname, surname, yob)
        {
            Username = username;
        }
    }

    public class Teacher : Staff
    {
        public string Expertise;
        public override string GetInfo()
        {
            return ($"Name: {FName} {SName} "+
            $"Username: {Username} " +
            $"Birth Year: {YearOfBirth} " +
            $"Expertise: {Expertise} ");
        }

        public Teacher(string firstname, string surname, int yob, string un, string expertise)
            : base(firstname, surname, yob, un)
        {
            Expertise = expertise;
        }
    }

    public class Admin : Staff
    {
        public int OfficeNo;

        public override string GetInfo()
        {
            return($"Username: {Username} " +
            $"Name: {FName} {SName} " +
            $"Birth Year: {YearOfBirth} " +
            $"Office: {OfficeNo} ");
        }

        public Admin(string firstname, string surname, int yob, string un, int officeno)
            : base(firstname, surname, yob, un)
        {
            OfficeNo = officeno;
        }


    }

    //public class PersonLists
    //{
    //    public List<Person> PersonList = new List<Person>
    //    {

    //    };

    //}

}
