using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class HourlyEmployee : Employee
    {

        
        //*****************************
        //Variable / Backing fields
        //*****************************
        private decimal hourlyRate;
        private decimal hoursPerWeek;

        //*****************************
        //Properties
        //*****************************

        public decimal Salary
        {
            get { return this.hourlyRate * WEEKS_PER_YEAR * hoursPerWeek; }
        }


        //******************************
        //Public Methods
        //******************************


        public override string ToString()
        {
            return base.ToString() + " " + this.Salary.ToString("C");
        }

        //*****************************
        //Constructors
        //*****************************
        public HourlyEmployee(string FirstName, string LastName, decimal HourlyRate, decimal HoursPerWeek) :
            base(FirstName,LastName)
        {            
            this.hourlyRate = HourlyRate;
            this.hoursPerWeek = HoursPerWeek;
        }
    }
}
