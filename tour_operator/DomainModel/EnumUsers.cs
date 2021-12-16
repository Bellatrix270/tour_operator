using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour_operator.DomainModel
{
    public enum TypeUsers : int
    {
        [StringValue("`data_tour_operators`")]
        Operator = 1,
        [StringValue("`clients`")]
        Client = 2,
        [StringValue("`guests`")]
        Guest = 3
    }
}
