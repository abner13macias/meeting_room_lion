using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenLionSystems
{
    public partial class MenuRenta : Form
    {
        //Se instancia un objeto de tipo Servicio para obtener información de las salas
        Servicio servicio = new Servicio();

        public MenuRenta()
        {
            InitializeComponent();
            //Se instancia un objeto de tipo Servicio para obtener información de las salas disponibles
            servicio.mostrarSalasDisponibles(listView_SalasDisponibles);       
        }

        private void button_Reservar_Click(object sender, EventArgs e)
        {

        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            //Se cierra la ventana al dar click al botón
            this.Close();
        }
    }
}
