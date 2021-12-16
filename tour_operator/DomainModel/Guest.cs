using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour_operator.DomainModel
{
    class Guest : IUser
    {
        public int Id { get; set ; }
        public string FirstName { get; set ; }
        public TypeUsers TypeUser { get; set; }

        public Guest(int id, string fname)
        {
            Id = id;
            FirstName = fname;
        }
    }
}
