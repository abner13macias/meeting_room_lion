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
    public partial class Renta : Form
    {
        //Atributos de la clase 'Renta'
        Servicio servicio;
        string id_Sala;

        //Constructor de la clase 'Renta'
        public Renta(string id_Sala)
        {
            this.id_Sala = id_Sala;
            servicio = new Servicio(id_Sala);
            InitializeComponent();

            //Se asigna la información de la sala a los Labels correspondientes
            label_infoSala.Text = servicio.infoSala[0];
            label_InfoHorarioInicio.Text = servicio.infoSala[1];
            label_InfoHorarioFin.Text = servicio.infoSala[2];
        }

        //Botón para cerrar la ventana
        private void button_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Botón para Rentar una Sala
        private void button_Reservar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se ejecuta método de renta de salas
                servicio.registrarRenta(id_Sala, textBox_Cliente.Text);
                MessageBox.Show("Se ha completado su registro");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar su registro");
            }
        }
    }
}
