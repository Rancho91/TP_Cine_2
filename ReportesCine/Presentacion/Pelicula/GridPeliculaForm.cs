using ReportesCine.Entidades.Maestras;
using ReportesCine.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesCine.Presentacion.Pelicula
{
    public partial class GridPeliculaForm : Form
    {
        List<Peliculas> listPelis;
        PeliculasService peliculaService;

        public GridPeliculaForm()
        {
            InitializeComponent();
            listPelis = new List<Peliculas>();
            peliculaService = new PeliculasService();
            CargarPeliculas();
        }

        private void GridPeliculaForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void CargarPeliculas()
        {
            listPelis = await peliculaService.Get();
            cbPeliculas.DataSource = listPelis;
            cbPeliculas.DisplayMember = "Nombre";
            cbPeliculas.ValueMember = "Codigo";
            
        }

        private void NuevoGB_Enter(object sender, EventArgs e)
        {

        }
    }
}
