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
        //Definición de los parámetros para la conexión a la base de datos
        Sala sala;
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor de la clase ConexionMySQL donde se inicializa la conexión
        public ConexionMySQL()
        {
            Initialize();
        }

        //Método para inicializar la conexión a la base de datos
        private void Initialize()
        {
            server = "localhost";
            database = "db_salajuntas";
            uid = "root";
            password = "";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        //Método para abrir la conexión a la base de datos
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
                        MessageBox.Show("No se puede conectar al servidor.  Contacte al administrador");
                        break;

                    case 1045:
                        MessageBox.Show("Credenciales inválidas, por favor intente de nuevo");
                        break;
                }
                return false;
            }
        }

        //Nétodo para cerrar la conexión
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

        //Método para obtener la información de todas las salas a través de MySQL
        public List<Sala> obtenerSalas()
        {
            //Se crea una lista donde almacenar la información de los objetos Sala
            List<Sala> listaSalas = new List<Sala>();

            //Se declara la Query de SQL
            string query = "SELECT s.ID_Sala, s.Nombre, s.Hora_Inicio, s.Hora_Fin FROM salas s";

            //Se valda que la conexión a la DB esté abierta
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    //Se crea una instancia de un objeto Sala con los datos obtenidos de la consulta SQL
                    sala = new Sala(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetTimeSpan(2), dataReader.GetTimeSpan(3));
                    //Se añade el objeto a la lista que se acaba de crear
                    listaSalas.Add(sala);
                }

                dataReader.Close();
                this.CloseConnection();
            }
            //Se retorna la lista con los objetos creados
            return listaSalas;
        }

        //Método para  obtener información de las salas ocupadas
        public List<Sala> obtenerSalasOcupadas()
        {
            //Se crea una lista donde almacenar la información de los objetos Sala
            List<Sala> listaSalas = new List<Sala>();

            //Se declara la Query de SQL
            string query = "SELECT s.ID_Sala, s.Nombre, s.Hora_Inicio, s.Hora_Fin FROM rentas r, salas s WHERE r.ID_Sala=s.ID_Sala AND r.Status='Ocupado'";

            //Se valida que la conexión a la DB esté abierta
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    //Se crea una instancia de un objeto Sala con los datos obtenidos de la consulta SQL
                    sala = new Sala( dataReader.GetInt32(0) ,dataReader.GetString(1), dataReader.GetTimeSpan(2), dataReader.GetTimeSpan(3));
                    //Se añade el objeto a la lista que se acaba de crear
                    listaSalas.Add(sala);
                }

                dataReader.Close();
                this.CloseConnection();
            }
            //Se retorna la lista con los objetos creados
            return listaSalas;
        }

        //Método para obtener la información de una Sala mediante SQL
        public Sala obtenerInfoSala(string id_Sala)
        {
            //Se declara un objeto de tipo Sala
            Sala sala = new Sala();

            //Se declara la Query de SQL
            string query = "SELECT s.Nombre, s.Hora_Inicio, s.Hora_Fin FROM salas s WHERE s.ID_Sala =" + id_Sala;

            //Se valida que la conexión a la DB esté abierta
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    //Se crea una instancia de un objeto Sala con los datos obtenidos de la consulta SQL
                    sala = new Sala(dataReader.GetString(0), dataReader.GetTimeSpan(1), dataReader.GetTimeSpan(2));
                }

                dataReader.Close();
                this.CloseConnection();
            }
            //Se retorna el objeto Sala creado
            return sala;
        }

        //Método para registrar la renta de una Sala en SQL
        public void crearRenta(string id_Sala, string nombre)
        {
            //Se declara la Query de SQL
            string query = "INSERT INTO rentas (ID_Sala, Usuario) VALUES (" + " ' " + id_Sala + " ' " + ", " + " ' " + nombre + " ' " + ")";

            //Se valida que la conexión a la DB esté abierta
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
    }
}
