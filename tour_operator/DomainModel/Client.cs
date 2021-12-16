using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour_operator.DomainModel
{
    public class Client : IUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public TypeUsers TypeUser { get; set; }

        public Client(int id, string fname, string lname, string country, 
            string city, string phone)
        {
            Id = id;
            FirstName = fname;
            LastName = lname;
            Country = country;
            City = city;
            PhoneNumber = phone;
        }
    }
}
