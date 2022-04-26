using CPA.Facil.Data.Repository.Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Facil.Data.Repository.Database.MySQL {
    public class MyCommand : ICommand {

        private MySqlCommand command;
        private MySqlConnection connection;

        public MyCommand(String sql, MySqlConnection connection) {
            this.connection = connection;
            command = new MySqlCommand(sql, connection);
        }

        public int Execute() {
            int result = command.ExecuteNonQuery();
            this.connection.Close();
            return result;
        }

        public T Read<T>() {

            MySqlDataReader read = command.ExecuteReader();

            if (!read.Read())
                throw new Exception("Nenhum registro encontrado.");

            T result = Mapping<T>(read);

            this.connection.Close();

            return result;

        }

        public List<T> ReadAll<T>() {

            MySqlDataReader read = command.ExecuteReader();

            List<T> result = new List<T>();

            while (read.Read()) {
                result.Add(Mapping<T>(read));
            }

            this.connection.Close();

            return result;

        }

        public T ReadValue<T>(string columnName) {

            MySqlDataReader read = command.ExecuteReader();

            if(!read.Read())
                throw new Exception("Nenhum registro encontrado.");

            T valor = (T)read.GetValue(read.GetOrdinal(columnName));

            this.connection.Close();

            return valor;

        }

        public void NewParameter(string name, object value) {

            command.Parameters.AddWithValue(name, value);

        }

        private T Mapping<T>(MySqlDataReader read) {

            T obj = (T)Activator.CreateInstance(typeof(T), new object[] { });

            for (int i = 0; i < read.FieldCount; i++) {

                var nomeColuna = read.GetName(i);
                var objColuna = obj.GetType().GetProperty(nomeColuna);

                if (objColuna != null) {
                    objColuna.SetValue(obj, read.GetValue(i), null);
                }

            }

            return obj;

        }
    }
}
