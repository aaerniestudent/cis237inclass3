using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a new instance of the User Interface class
            UserInterface ui = new UserInterface();           

            //Let's make an array to hold a bunch of instances of the SalaryEmployee class
            IEmployee[] Employees = new Employee[10];

            //Let's add some SalaryEmployees to our array
            Employees[0] = new SalaryEmployee("David", "Barnes", 835.00m);
            Employees[1] = new SalaryEmployee("James", "Kirk", 453.00m);
            Employees[2] = new SalaryEmployee("Jean-Luc", "Picard", 290.00m);
            Employees[3] = new HourlyEmployee("Benjamin", "Sisko", 40m, 26.00m);
            Employees[4] = new HourlyEmployee("Kathryn", "Janeway", 20m, 15.00m);
            Employees[5] = new SalaryEmployee("Johnathan", "Archer", 135.00m);

            //Index for open spot
            int nextOpen = 6;

            //Get some input from the user
            int choice = ui.GetUserInput();

            //While the choice they selected is not 2, continue to do work
            while (choice != 3)
            {
                //See if the input they sent is equal to 1.
                if (choice == 1)
                {
                    //Create a string that can be concated to
                    string outputString = "";

                    //Print out the SalaryEmployees in the array
                    foreach (IEmployee emp in Employees)
                    {
                        if (emp != null)
                        {
                            //Concat to the outputString
                            outputString += emp.ToString() + " " + emp.GetFormattedSalary() +
                                Environment.NewLine;
                        }
                    }

                    //Use the UI class to print out the string
                    ui.Output(outputString);
                }

                if (choice == 2)
                {
                    Employees[nextOpen++] = getClonedEmployee(Employees[0]);
                }

                //re-prompt the user for input
                choice = ui.GetUserInput();
            }

        }

        static IEmployee getClonedEmployee(ICloneable clone)
        {
            //cast to IEmployee because clone returns an object
            return (IEmployee)clone.Clone();
        }
    }
}
