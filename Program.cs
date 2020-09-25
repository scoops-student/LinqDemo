using System;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Person.Scoops();

            /*
             * De meest voorkomende vorm is voor selectie en/of sorteren van C# objecten
             * Dit zal dikwijls de DbSet van Entity Framework zijn
             */
            var vasteWerknemers = data.Where(x => x.PersonType == Person.Type.Owner || x.PersonType == Person.Type.Employee)
                                      .OrderBy(x => x.FirstName); //IEnumerable<Person>


            /*
             * Soms heb je expliciet een kopie van de data nodig om te manipuleren
             * ToList kopieerd de data in geheugen
             * 
             * Dit heeft wel een enorme Performance impact als je achterliggend type DbSet is
             */
            var vasteWerknemersList = data.Where(x => x.PersonType == Person.Type.Owner || x.PersonType == Person.Type.Employee).ToList(); //Generic.List<Person>

            /*
             * Een object zoeken volgens zijn Identiteit 
             */
            int id = 42;
            var findPerson = data.Where(x => x.Id == id).FirstOrDefault();
            if (findPerson == null)
            {
                throw new ArgumentException(); // Argument id is onzin
            }

            /*
             * Belangrijk om te weten dat er ook een SQL geinspireerde syntax bestaat
             * In combinatie met EF kan dit zeer performante queries opleveren
             */
            var nameList = from person in data
                           where person.PersonType == Person.Type.Student
                           orderby person.LastName
                           select new { person.FirstName, person.LastName }; // Anonieme Type {string, string}

        }
    }
}
