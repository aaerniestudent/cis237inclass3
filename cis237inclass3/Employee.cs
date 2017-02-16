using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    public abstract class Employee : IEmployee //Implements the IEmployee interface
    {
        protected const decimal WEEKS_PER_YEAR = 52;
        //*****************************
        //Variable / Backing fields
        //*****************************
        private string firstName;
        private string lastName;


        //properties
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

        //methods
        private string FirstAndLastName()
        {
            return firstName + " " + lastName;
        }

        public override string ToString()
        {
            return FirstAndLastName();
        }

        //an abstract method MUST have no method body
        //an abstract method MUST be overriden by all childs
        //abstract based on the information that this class has, 
        //we have no idea how to calc a salary or format one
        //implementation must be left to the child
        public abstract string GetFormattedSalary();        


        //A virtual method MUST have a method body
        //A virtual method can be overriden in chlid classes, but not required
        //We made this method virtual because we already have all of the needed information to provide a method body. 
        //we left it virtual in case a subclass would like to override it for some reason.
        public virtual string GetLastNameFirstName()
        {
            return this.lastName + "," + this.firstName;
        }

        //constructors
        public Employee(string FirstName, string LastName)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
        }

        public abstract object Clone();       
    }
}
