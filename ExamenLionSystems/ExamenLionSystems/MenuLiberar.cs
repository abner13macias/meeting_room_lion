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
    public partial class MenuLiberar : Form
    {
        //Se instancia un objeto de tipo Servicio para obtener información de las salas
        Servicio servicio = new Servicio();

        public MenuLiberar()
        {
            InitializeComponent();
            //Se muestran las salas ocupadas en la ListView
            servicio.mostrarSalasOcupadas(listView_SalasOcupadas, label_NoExistenSalas);
        }

        //Botón para cerrar la ventana
        private void button_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Liberar_Click(object sender, EventArgs e)
        {
            if (label_NoExistenSalas.Visible)
            {
                MessageBox.Show("No existen salas para liberar!");
            }
            else
            {
                //Se crea un DialogResult para confirmar que se quiere liberar la Sala seleccionada
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que quiere liberar esta sala?", "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        //Se ejecuta el método para liberar la sala
                        servicio.liberarSala(listView_SalasOcupadas.SelectedItems[0].Tag.ToString());
                        MessageBox.Show("Sala liberada");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al liberar la sala");
                    }
                }
            }            
        }
    }
}
