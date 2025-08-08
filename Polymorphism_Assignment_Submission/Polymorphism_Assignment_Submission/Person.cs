using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Assignment
{
    public abstract class Person // Abstract class.
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void SayName(); // Abstact class method no implementation.
    }
}
