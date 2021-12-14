using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour_operator.Model
{
    public class ModelDB
    {
        MySqlCommand cmd = Host_DB.ConnectionDB.CreateCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        /// <summary>
        /// Проверка на наличие данных в базе данных. После запроса соединение закрывается.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>Возвращает true, если данные содержаться в таблице, в противном случае false.</returns>
        public bool IsExistOperator(string email, string password)
        {
            Host_DB.OpenConnection();

            bool isExistOperator = false;

            cmd.CommandText = "SELECT * FROM `data_tour_operators` WHERE `email` = @email AND `password_app` = @pass";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pass", password);

            object id = cmd.ExecuteScalar();

            if (id != null)
                isExistOperator = true;

            Host_DB.CloseConnection();

            return isExistOperator;
        }
    }
}
