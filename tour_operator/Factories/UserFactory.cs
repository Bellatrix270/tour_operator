using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tour_operator.DomainModel;

namespace tour_operator.Factories
{
    public abstract class UserFactory
    {
        public abstract IUser GetUser();
    }
}
