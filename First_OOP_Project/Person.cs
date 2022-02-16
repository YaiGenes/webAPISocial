using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_OOP_Project
{
    class Person
    {
        // private fields
        private string _firstname = "";
        private string _lastname = "";
        private string _occupation = "";
        private int _age = 0;
        private int _count = 64;

        //public fields
        public string FirstName { get { return _firstname; } }
        public string Lastname { get { return _lastname; } }
        public string Occupation { get { return _occupation; } }
        public int Age { get { return _age; } }
        public int Count { get { return _count; } set { _count = value; } }



        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="firstname">firstname</param>
        /// <param name="lastname">lastname</param>
        /// <param name="occupation">occupation</param>
        /// <param name="age">age</param>

        public Person(string firstname, string lastname, string occupation, int age)
        {
            _firstname = firstname;
            _lastname = lastname;
            _occupation = occupation;
            _age = age;
        }
    }
}
