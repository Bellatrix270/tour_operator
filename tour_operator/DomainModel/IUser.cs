using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour_operator.DomainModel
{
    public interface IUser
    {
        int Id { get; set; }
        string FirstName { get; set; }
        TypeUsers TypeUser { get; set; }
    }
}
