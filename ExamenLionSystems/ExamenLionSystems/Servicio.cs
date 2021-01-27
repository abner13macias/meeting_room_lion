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
        private List<Sala> salasTotales = new List<Sala>();
        private List<Sala> salasOcupadas = new List<Sala>();
        private List<Sala> salasDisponibles = new List<Sala>();
        private ConexionMySQL DBConnection = new ConexionMySQL();

        public Servicio()
        {
            obtenerSalas();
            obtenerSalasOcupadas();
            calcularSalasDisponibles();
        }

        private void obtenerSalas()
        {
            salasTotales = DBConnection.obtenerSalas();
        }

        private void obtenerSalasOcupadas()
        {
            salasOcupadas = DBConnection.obtenerSalasOcupadas();
        }

        private void calcularSalasDisponibles()
        {            
            foreach (Sala sala in salasTotales)
            {
                bool band = true;
                foreach (Sala salaOcupada in salasOcupadas)
                {
                    if (sala.id == salaOcupada.id)
                    {
                        band = false;
                    }
                }

                if (band)
                {
                    salasDisponibles.Add(sala);
                }
            }
        }

        public void mostrarSalasDisponibles(ListView listView)
        {
            foreach (Sala sala in salasDisponibles)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = sala.id;
                item.Text = sala.nombre + ": HORA DE INICIO: " + sala.hora_inicio.ToString() + "  HORA DE TERMINO: " + sala.hora_fin.ToString();

                listView.Items.Add(item);
            }
        }
    }
}
