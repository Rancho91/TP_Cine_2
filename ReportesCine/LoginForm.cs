using CineApi.ReportesCine;
using ReportesCine.Reportes.forms;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void peliculasGananciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formReporte = new Form1();

            // Mostrar el formulario
            formReporte.ShowDialog();
        }

        private void gananciaFormaPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GananciaFormaPagoForm form = new GananciaFormaPagoForm();
            form.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
