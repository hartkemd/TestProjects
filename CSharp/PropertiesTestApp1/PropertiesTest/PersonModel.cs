using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesTest
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; private set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        private int _password;

        public int Password
        {
            set { _password = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set {
                if (value >= 0 && value <= 125)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age needs to be in a valid range.");
                }
            }
        }
        private string _ssn;

        public string SSN
        {
            get {
                string output = "***-**-" + _ssn.Substring(_ssn.Length - 4);
                return output;
            }
            set { _ssn = value; }
        }

        public PersonModel()
        {

        }

        public PersonModel(string lastName)
        {
            LastName = lastName;
        }
    }
}
