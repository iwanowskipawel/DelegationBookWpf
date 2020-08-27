using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.Model
{
    public abstract class Person
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{ FirstName } { LastName }";
    }
}
