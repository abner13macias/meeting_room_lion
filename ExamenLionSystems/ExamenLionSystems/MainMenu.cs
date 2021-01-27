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
    public partial class MainMenu : Form
    {        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button_Consultar_Click(object sender, EventArgs e)
        {
            MenuSalas menuInfoSalas = new MenuSalas();
            menuInfoSalas.Show();
        }

        private void button_Registrar_Click(object sender, EventArgs e)
        {
            MenuRenta menuRentaSala = new MenuRenta();
            menuRentaSala.Show();
        }

        private void button_Liberar_Click(object sender, EventArgs e)
        {

        }
    }
}
