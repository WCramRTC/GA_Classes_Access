using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Classes_Access
{
    public class Person
    {
        private string firstName;
        private string lastName;

        // Constructor
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // Properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        // Method to get full name
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }

}
