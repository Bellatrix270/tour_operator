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
    class ClientFactory : UserFactory
    {
        DataRow[] rows;
        public ClientFactory(string phone, string password)
        {
            rows = ModelDB.GetDataFromTable("clients")
                .Select($"phone = '{phone}' AND password_app = `{password}`");
        }

        public override IUser GetUser()
        {
            object[] operatorData = rows[0].ItemArray;

            int id = (int)operatorData[0];
            string fname = operatorData[1].ToString();
            string lname = operatorData[2].ToString();
            string counrty = operatorData[3].ToString();
            string city = operatorData[4].ToString();
            string phone = operatorData[5].ToString();
            string password = operatorData[6].ToString();

            Client _client = new Client(id, fname, lname, counrty, city, phone);

            return _client;
        }
    }
}
