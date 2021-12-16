using MySqlConnector;
using System.Data;
using tour_operator.DomainModel;
using tour_operator.Factories;

namespace tour_operator.Model
{
    public static class ModelDB
    {
        private static MySqlCommand cmd = Host_DB.ConnectionDB.CreateCommand();
        private static MySqlDataAdapter adapter = new MySqlDataAdapter();

        public static DataTable GetDataFromTable(string tableName = null)
        {
            Host_DB.OpenConnection();

            DataTable db = new DataTable();
            cmd.CommandText = $"SELECT * FROM `{tableName}`";
            adapter.SelectCommand = cmd;
            adapter.Fill(db);

            Host_DB.CloseConnection();

            return db;
        }


        /// <summary>
        /// Проверка на наличие данных в базе данных. После запроса соединение закрывается.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>Возвращает true, если данные содержаться в таблице, в противном случае false.</returns>
        public static IUser GetLoginUser(TypeUsers type, string email = "", string phone = "", string password = "")
        {
            Host_DB.OpenConnection();

            UserFactory factory = GetFactory(type, email, phone, password);
            IUser user = factory.GetUser();

            Host_DB.CloseConnection();

            return user;
        }

        private static UserFactory GetFactory(TypeUsers type, string email, string phone, string password)
        {
            switch (type)
            {
                case TypeUsers.Operator: return new OperatorFactory(email, password);

                case TypeUsers.Client: return new ClientFactory(phone, password);

                case TypeUsers.Guest: return new GuestFactory("Petya");

                default: return null;
            }
        }
    }
}
