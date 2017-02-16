using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    public class SalaryEmployee : Employee
    {
        //*****************************
        //Variable / Backing fields
        //*****************************
        private decimal weeklySalary;

        //*****************************
        //Properties
        //*****************************

        public decimal Salary
        {
            get { return weeklySalary * WEEKS_PER_YEAR; }
        }

        //******************************
        //Public Methods
        //******************************

        public override string ToString()
        {
            return base.ToString() + " " + Salary.ToString("C");
        }

        public override string GetFormattedSalary()
        {
            return Salary.ToString("C");
        }

        public override object Clone()
        {
            return new SalaryEmployee(this.FirstName,this.LastName,this.weeklySalary);
        }

        //*****************************
        //Constructors
        //*****************************
        public SalaryEmployee(string FirstName, string LastName, decimal WeeklySalary) : base(FirstName, LastName)
        {
            this.weeklySalary = WeeklySalary;
        }        
    }
}
