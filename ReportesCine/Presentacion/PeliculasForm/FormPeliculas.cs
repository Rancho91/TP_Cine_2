using ReportesCine.Entidades;
using ReportesCine.Entidades.Auxiliares;
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

namespace ReportesCine.Presentacion.FormPeliculas
{
    public partial class FormPeliculas : Form
    {
      
        List<PeliculasE> lstPeliculas;
        List<Generos> lstGeneros;
        List<Paises> lstPaises;
        List<Clasificaciones> lstClasificaciones;
        PeliculasEService peService;
        GeneroService generoService;
        PaisService paisService;
        ClasificacionService claService;
        PeliculasE pelicula;
        
        public FormPeliculas()
        {
            InitializeComponent();
            lstPeliculas = new List<PeliculasE>();
            lstGeneros = new List<Generos>();
            lstPaises = new List<Paises>();
            lstClasificaciones = new List<Clasificaciones>();
            peService = new PeliculasEService();
            generoService = new GeneroService();
            paisService = new PaisService();
            claService = new ClasificacionService();
            pelicula = new PeliculasE();
            
            Cargar();

        }

        private async void Cargar()
        {
            lstGeneros = await generoService.Get();
            cboGenero.DataSource = lstGeneros;
            cboGenero.DisplayMember = "Genero";
            cboGenero.ValueMember = "Codigo";

            lstPaises = await paisService.Get();
            cboPais.DataSource = lstPaises;
            cboPais.DisplayMember = "Pais";
            cboPais.ValueMember = "Codigo";

            lstClasificaciones = await claService.Get();
            cboClasificacion.DataSource = lstClasificaciones;
            cboClasificacion.DisplayMember = "Clasificacion";
            cboClasificacion.ValueMember = "Codigo";

            CargarDGV();
        }

        private async void CargarDGV()
        {
            lstPeliculas = await peService.Get();
            dgvPeliculas.Rows.Clear();
            foreach (PeliculasE peliculas in lstPeliculas)
            {
                dgvPeliculas.Rows.Add(peliculas.Codigo, peliculas.Genero.Genero, peliculas.Nombre, peliculas.Pais.Pais, peliculas.Clasificacion.Clasificacion, peliculas.Duracion, "Eliminar", "Editar");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormPeliculas_Load(object sender, EventArgs e)
        {

        }

        private async void btnAgregarPelicula_Click(object sender, EventArgs e)
        {
            pelicula.Nombre = txtNombrePelicula.Text;
            pelicula.Duracion = TimeSpan.FromHours((int)nudHora.Value) + TimeSpan.FromMinutes((int)nupMinutos.Value);
            pelicula.Pais.Codigo = (int)cboPais.SelectedValue;
            pelicula.Clasificacion.Codigo = (int)cboClasificacion.SelectedValue;
            pelicula.Genero.Codigo = (int)cboClasificacion.SelectedValue;
            try
            {
                await peService.Post(pelicula);
                MessageBox.Show("Pelicula Creada");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo crear la pelicula");
            }

        }
    }
}
