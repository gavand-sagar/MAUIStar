using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIStar
{
    public class Address
    {
        public string City { get; set; }
        public string Country { get; set; }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Address Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DOB { get; set; }
        public Person()
        {
            Address = new Address();
        }
       
    }
}
