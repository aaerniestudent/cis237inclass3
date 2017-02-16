using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{        
    interface IEmployee : ICloneable
    {

        //An interface contains only method declarations and properties
        //There is no need to put any access modifiers because it will always be public
        //We are specifying only public methods and proerties

        //any class that implements this interface must implement the following

        //methods
        string GetFormattedSalary();

        string GetLastNameFirstName();

        //properties
        string FirstName
        {
            get;
            set;
        }
        string LastName
        {
            get;
            set;
        }

        
    }
}
