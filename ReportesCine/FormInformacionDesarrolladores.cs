using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesCine
{
    public partial class FormInformacionDesarrolladores : Form
    {
        public FormInformacionDesarrolladores()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lblnombre.Text = "NOMBRE : RODRIGUEZ FABRIZIO ENRIQUE  \n LEGAJO : 113838 \n TURNO : NOCHE \n PUESTO : DESARROLLADOR .NET";
            lblnombre.ForeColor = Color.Red;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lbljoaquin.Text = "NOMBRE : POSTILLON JOAQUIN \n LEGAJO : 113928 \n TURNO : NOCHE \n PUESTO : DESARROLLADOR .NET";
            lbljoaquin.ForeColor = Color.Red;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblema.Text = "NOMBRE :  CORTEZ EMANUEL \n LEGAJO : 113839 \n TURNO : NOCHE \n PUESTO : DESARROLLADOR .NET";
            lblema.ForeColor = Color.Red;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblrami.Text = "NOMBRE :  SANCHEZ SOLANO RAMIRO  \n LEGAJO : 113855 \n TURNO : NOCHE \n PUESTO : DESARROLLADOR .NET";
            lblrami.ForeColor = Color.Red;
        }
    }
}
