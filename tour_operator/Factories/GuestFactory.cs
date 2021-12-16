using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tour_operator.DomainModel;
using tour_operator.Model;

namespace tour_operator.Factories
{
    class GuestFactory : UserFactory
    {
        DataRow[] rows;
        public GuestFactory(string fname)
        {
            rows = ModelDB.GetDataFromTable("guest")
                .Select($"phone = '{fname}' AND password_app = `{fname}`");
        }

        public override IUser GetUser()
        {
            object[] operatorData = rows[0].ItemArray;

            int id = (int)operatorData[0];
            string fname = operatorData[1].ToString();

            Guest _guest = new Guest(id, fname);

            return _guest;
        }
    }
}
