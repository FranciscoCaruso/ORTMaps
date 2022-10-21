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
    public partial class Opciones_K : Form
    {
        public Opciones_K()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form Pantalla_Kiosco_esquina = new Pantalla_Kiosco_esquina();
            Pantalla_Kiosco_esquina.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form Kiosco_Simona = new Kiosco_Simona();
            Kiosco_Simona.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form Supermercado_Coto = new Supermercado_Coto();
            Supermercado_Coto.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form MapaExterior = new MapaExterior();
            MapaExterior.Show();
            this.Hide();
        }
    }
}
