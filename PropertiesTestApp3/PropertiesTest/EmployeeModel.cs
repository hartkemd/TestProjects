using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesTest
{
    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
        private decimal _salary;

        public decimal GetSalary()
        {
            return _salary;
        }

        public void SetSalary(decimal value)
        {
            const decimal maxSalary = 1000000M;

            if (value > 0 && value < maxSalary)
            {
                _salary = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Salary", "Salary was not in the valid range.");
            }
        }
    }
}
