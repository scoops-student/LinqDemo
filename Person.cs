using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDemo
{
    public class Person
    {
        public enum Type
        {
            Unknown,
            Student,
            Employee,
            Owner,
        }

        public int Id { get; set; } = 0;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public Person.Type PersonType { get; set; } = Type.Unknown;

        public static IEnumerable<Person> Scoops()
        {
            return new List<Person>
            {
                new Person
                {
                    Id = 1,
                    FirstName = "Nico",
                    LastName = "Deleu",
                    PersonType = Type.Owner,
                },
                new Person
                {
                    Id = 2,
                    FirstName = "Hannah",
                    LastName = "Kiekens",
                    PersonType = Type.Employee,
                },
                new Person
                {
                    Id = 3,
                    FirstName = "Ayoub",
                    LastName = "Ibourt ",
                    PersonType = Type.Student,
                },
                new Person
                {
                    Id = 4,
                    FirstName = "Femke",
                    LastName = "Vermander",
                    PersonType = Type.Student,
                },
            };
        }
    }


}
