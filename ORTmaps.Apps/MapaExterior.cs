using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORTmaps.Apps
{
    public partial class MapaExterior : Form
    {
        public MapaExterior()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form opcionesL = new Opciones_L();
            opcionesL.Show();
            this.Hide();
        }

        private void MapaExterior_Load(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form opcionesR = new Opciones_R();
            opcionesR.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form opcionesK = new Opciones_K();
            opcionesK.Show();
            this.Hide();
        }
    }
}
