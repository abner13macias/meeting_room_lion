using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ExamenLionSystems
{
    class ConexionMySQL
    {
        private MySqlConnection connection;
        Sala sala;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public ConexionMySQL()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "db_salajuntas";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<Sala> obtenerSalas()
        {
            List<Sala> listaSalas = new List<Sala>();
            string query = "SELECT s.ID_Sala, s.Nombre, s.Hora_Inicio, s.Hora_Fin FROM salas s";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    sala = new Sala(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetTimeSpan(2), dataReader.GetTimeSpan(3));
                    listaSalas.Add(sala);
                }

                dataReader.Close();
                this.CloseConnection();
            }
            return listaSalas;
        }

        public List<Sala> obtenerSalasOcupadas()
        {
            List<Sala> listaSalas = new List<Sala>();
            string query = "SELECT s.ID_Sala, s.Nombre, s.Hora_Inicio, s.Hora_Fin FROM rentas r, salas s WHERE r.ID_Sala=s.ID_Sala AND r.Status='Ocupado'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    sala = new Sala( dataReader.GetInt32(0) ,dataReader.GetString(1), dataReader.GetTimeSpan(2), dataReader.GetTimeSpan(3));
                    listaSalas.Add(sala);
                }

                dataReader.Close();
                this.CloseConnection();
            }
            return listaSalas;
        }
    }
}
