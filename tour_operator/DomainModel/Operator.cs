using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour_operator.DomainModel
{
    public class Operator : IUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public TypeUsers TypeUser { get; set ; }

        public Operator(int id, string fname, string lname, string patronymic, 
            string phone, string email, string password)
        {
            Id = id;
            FirstName = fname;
            LastName = lname;
            Patronymic = patronymic;
            PhoneNumber = phone;
            Email = email;
            Password = password;
        }

        public Operator()
        {
            Id = -1;
            FirstName = "Empty";
            LastName = "Empty";
            Patronymic = "Empty";
            PhoneNumber = "Empty";
            Email = "Empty";
            Password = "Empty";
        }
    }
}
