using CPA.Facil.Data.Repository.Database.MySQL;
using CPA.Facil.Data.Repository.Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Facil.Data.Repository {
    public static class RepositoryResolver {

        public static ICommand NewCommand(String sql) {

            MySqlConnection connection = RepositoryConfigure.NewConnection();
            return new MyCommand(sql, connection);

        }

    }
}
