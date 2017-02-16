using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using cis237inclass3;

namespace cis237inclass3UnitTest
{
    [TestClass]
    public class SalaryEmployeeUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            SalaryEmployee salaryEmployee = new SalaryEmployee("Anthony", "Aernie", 250m);
            string expected = "Aernie,Anthony";

            //act
            string actual = salaryEmployee.GetLastNameFirstName();

            //assert       
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetYearlySalaryTest()
        {
            SalaryEmployee salaryEmployee = new SalaryEmployee("Anthony", "Aernie", 250m);
            string expected = "$13,000.00";

            string actual = salaryEmployee.GetFormattedSalary();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalaryEmployeeTest()
        {
            string expectedFirstName = "Anthony";
            string expectedLastName = "Aernie";
            decimal expectedSalary = 250m * 52m;

            SalaryEmployee salaryEmployee = new SalaryEmployee("Anthony", "Aernie", 250m);           

            Assert.AreEqual(expectedFirstName, salaryEmployee.FirstName);
            Assert.AreEqual(expectedLastName, salaryEmployee.LastName);
            Assert.AreEqual(expectedSalary, salaryEmployee.Salary);
        }
    }

}
