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
            lblnombre.Text = "NOMBRE : FABRIZIO ENRIQUE RODRIGUEZ \n LEGAJO : 113838 \n TURNO : NOCHE \n PUESTO : DESARROLLADOR .NET";
            lblnombre.ForeColor = Color.Black;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lbljoaquin.Text = "NOMBRE : POSTILLON JOAQUIN \n LEGAJO : 113928 \n TURNO : NOCHE \n PUESTO : DESARROLLADOR .NET";
            lbljoaquin.ForeColor = Color.Black;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblema.Text = "NOMBRE :  CORTEZ EMANUEL \n LEGAJO : 113839 \n TURNO : NOCHE \n PUESTO : DESARROLLADOR .NET";
            lblema.ForeColor = Color.Black;
        }
    }
}
