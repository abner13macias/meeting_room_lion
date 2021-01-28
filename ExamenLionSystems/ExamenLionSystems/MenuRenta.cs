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
            servicio.mostrarSalasDisponibles(listView_SalasDisponibles, label_NoExistenSalas);       
        }

        private void button_Reservar_Click(object sender, EventArgs e)
        {
            if (label_NoExistenSalas.Visible)
            {
                MessageBox.Show("No hay Salas disponibles!");
            }
            else
            {
                //Al dar click al botón de 'Rentar', se abre la venta de renta
                try
                {
                    //Se obtiene el ID de las salas mostradas en la ListView
                    Renta renta = new Renta(listView_SalasDisponibles.SelectedItems[0].Tag.ToString());
                    renta.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error al procesar su solicitud");
                }
            }            
        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            //Se cierra la ventana al dar click al botón
            this.Close();
        }
    }
}
