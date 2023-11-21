using CineApi.ReportesCine;
using ReportesCine.Presentacion.Facturas;
using ReportesCine.Presentacion.FormPeliculas;
using ReportesCine.Presentacion.Pelicula;
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
            GananciaFormaPagoFormReporte form = new GananciaFormaPagoFormReporte();
            form.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void funcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridFuncionForm form = new GridFuncionForm();
            form.ShowDialog();
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPeliculas form = new FormPeliculas();
            form.ShowDialog();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturaForm form = new FacturaForm();
            form.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informacionDesarrolladoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInformacionDesarrolladores f = new FormInformacionDesarrolladores();
            f.ShowDialog();
        }
    }
}
