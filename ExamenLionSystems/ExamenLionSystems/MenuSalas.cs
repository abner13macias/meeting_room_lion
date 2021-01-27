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
    public partial class MenuSalas : Form
    {
        Servicio servicio = new Servicio();

        public MenuSalas()
        {
            InitializeComponent();
            servicio.mostrarInfoSalas(listView_InfoSalas);
        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
