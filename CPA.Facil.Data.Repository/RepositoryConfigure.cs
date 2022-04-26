using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Facil.Data.Repository {
    public static class RepositoryConfigure {

        public static String ConnectionString = "";

        public static MySqlConnection NewConnection() {

            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

            return connection;

        }

    }
}
