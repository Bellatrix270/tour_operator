using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySqlConnector;
using System.Windows.Forms;

namespace tour_operator.Model
{
    /// <summary>
    /// Класс для работы с удалённой БД на хостинге Reg.ru.
    /// </summary>
    public static class Host_DB
    {
        public static MySqlConnection ConnectionDB = new MySqlConnection("Database=u1478686_corp_travel_on_earth;Data Source=37.140.192.191;User Id=u1478686_student;Password=rxj-HUr-wx2-pAH;convert zero datetime=True");

        public static void OpenConnection()
        {
            try
            {
                if (ConnectionDB.State == System.Data.ConnectionState.Closed)
                    ConnectionDB.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CloseConnection()
        {
            if (ConnectionDB.State == System.Data.ConnectionState.Open)
                ConnectionDB.Close();
        }

    }
}
