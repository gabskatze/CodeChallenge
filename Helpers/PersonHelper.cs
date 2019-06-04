using CodeChallenge.Models;
using System.Collections.Generic;

namespace CodeChallenge.Helpers
{
    public class PersonHelper
    {
        public static List<Person> PersonList = new List<Person>();

        public static void AddPerson(Person person)
        {
            PersonList.Add(person);
        }
        
        public static List<Person> GetPeople()
        {
            return PersonList;
        }
    }
}