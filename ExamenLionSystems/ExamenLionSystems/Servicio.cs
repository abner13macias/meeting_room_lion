using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenLionSystems
{
    class Servicio
    {
        //Instancia de las listas que se utilizarán en el transcurso de la ejecución
        //Instancia del objecto 'DBConnection', con el que se conecta a una DB en MySQL hospedada con PHPMyAdmin
        private List<Sala> salasTotales = new List<Sala>();
        private List<Sala> salasOcupadas = new List<Sala>();
        private List<Sala> salasDisponibles = new List<Sala>();
        private ConexionMySQL DBConnection = new ConexionMySQL();
        public string[] infoSala = new string[3];

        //Constructor de la clase Servicio, donde se obtiene la información de las salas
        public Servicio()
        {
            obtenerSalas();
            obtenerSalasOcupadas();
            calcularSalasDisponibles();
        }

        //Constructor alternativo de la clase 'Servicio'
        public Servicio(string id_Sala)
        {
            obtenerInfoSalaID(id_Sala);
        }

        //Método para obtener la información de una Sala en particular
        private void obtenerInfoSalaID(string id_Sala)
        {
            Sala sala = DBConnection.obtenerInfoSala(id_Sala);
            infoSala[0] = sala.nombre;
            infoSala[1] = sala.hora_inicio.ToString();
            infoSala[2] = sala.hora_fin.ToString();
        }

        //Se obtiene la información de todas las salas alojadas en la DB
        private void obtenerSalas()
        {
            salasTotales = DBConnection.obtenerSalas();
        }

        //Se obtiene la información de las salas ocupadas
        private void obtenerSalasOcupadas()
        {
            salasOcupadas = DBConnection.obtenerSalasOcupadas();
        }

        //En base a la totalida de las salas y las que están ocupadas, se calcula cuales son las salas que están libres
        private void calcularSalasDisponibles()
        {            
            //Se recorre la lista de todas las salas
            foreach (Sala sala in salasTotales)
            {
                //Se establece un parámetro booleano para identificar si existe o no, una sala ocupada dentro de la lista de todas las salas
                bool band = true;

                //Serecorre la lista de las salas ocupadas
                foreach (Sala salaOcupada in salasOcupadas)
                {
                    //Condición para identificar si la sala ocupada existe en la lista de salas
                    if (sala.id == salaOcupada.id)
                    {
                        band = false;
                    }
                }

                //Si la sala que se está recorriendo no apareció en la lista de salas ocupadas, se añade a la lista de salas disponibles
                if (band)
                {
                    salasDisponibles.Add(sala);
                }
            }
        }

        //Metodo donde se lee la lista de todas las salas y se manda a mostrar en la ListView de la Form 'MenuSalas'
        public void mostrarInfoSalas(ListView listView)
        {
            foreach (Sala sala in salasTotales)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = sala.id;
                item.Text = sala.nombre + ": HORA DE INICIO: " + sala.hora_inicio.ToString() + " HORA DE TERMINO: " + sala.hora_fin.ToString();
                listView.Items.Add(item);
            }
        }

        //Metodo donde se lee la lista de las salas disponibles y se manda a mostrar en la ListView de la Form 'MenuRenta'
        public void mostrarSalasDisponibles(ListView listView, Label existenSalasLabel)
        {
            //Se valida que existan salas ocupadas
            if (salasDisponibles.Count > 0)
            {
                foreach (Sala sala in salasDisponibles)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = sala.id;
                    item.Text = sala.nombre + ": HORA DE INICIO: " + sala.hora_inicio.ToString() + "  HORA DE TERMINO: " + sala.hora_fin.ToString();
                    listView.Items.Add(item);
                }
            }
            //De lo contrario se mostrará un mensaje avisando que no hay salas ocupadas
            else
            {
                listView.Visible = false;
                existenSalasLabel.Visible = true;
            }
        }

        //Método para mostrar las Salas ocupadas en la ListView
        public void mostrarSalasOcupadas(ListView listView, Label existenSalasLabel)
        {
            //Se valida que existan salas ocupadas
            if (salasOcupadas.Count > 0)
            {
                foreach (Sala sala in salasOcupadas)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = sala.id;
                    item.Text = sala.nombre + ": HORA DE INICIO: " + sala.hora_inicio.ToString() + "  HORA DE TERMINO: " + sala.hora_fin.ToString();
                    listView.Items.Add(item);
                }
            }
            //De lo contrario se mostrará un mensaje avisando que no hay salas ocupadas
            else
            {
                listView.Visible = false;
                existenSalasLabel.Visible = true;
            }
            
        }

        //Método para registrar la renta de una Sala
        public void registrarRenta(string id_Sala, string nombre)
        {
            DBConnection.crearRenta(id_Sala, nombre);
        }

        //Método para liberar la renta de una Sala
        public void liberarSala(string id_Sala)
        {
            DBConnection.liberarRenta(id_Sala);
        }
    }
}
