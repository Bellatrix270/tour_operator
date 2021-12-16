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
    class OperatorFactory : UserFactory
    {
        DataRow[] rows;
        public OperatorFactory(string email, string password)
        {
            rows = ModelDB.GetDataFromTable("data_tour_operators")
                .Select($"email = '{email}' AND password_app = '{password}'");
        }

        public override IUser GetUser()
        {
            if (rows.Length == 0)
            {
                Operator _operatorNull = new Operator();
                return _operatorNull;
            }

            object[] operatorData = rows[0].ItemArray;

            int id = (int)operatorData[0];
            string fname = operatorData[1].ToString();
            string lname = operatorData[2].ToString();
            string patronymic = operatorData[3].ToString();
            string phone = operatorData[4].ToString();
            string email = operatorData[5].ToString();
            string password = operatorData[6].ToString();

            Operator _operator = new Operator(id, fname, lname, patronymic, phone, email, password);

            return _operator;
        }
    }
}
