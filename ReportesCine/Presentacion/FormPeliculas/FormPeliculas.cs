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
        List<Peliculas> lstPeliculas;
        List<Generos> lstGeneros;
        List<Paises> lstPaises;
        List<Clasificaciones> lstClasificaciones;
        PeliculasService peService;
        GeneroService generoService;
        PaisService paisService;
        ClasificacionService claService;
        
        public FormPeliculas()
        {
            InitializeComponent();
            lstPeliculas = new List<Peliculas>();
            lstGeneros = new List<Generos>();
            lstPaises = new List<Paises>();
            lstClasificaciones = new List<Clasificaciones>();
            peService = new PeliculasService();
            generoService = new GeneroService();
            paisService = new PaisService();
            claService = new ClasificacionService();
            

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

        private void CargarDGV()
        {
            dgvPeliculas.Rows.Clear();
            foreach (Peliculas peliculas in lstPeliculas)
            {
                dgvPeliculas.Rows.Add(peliculas.Codigo, peliculas.Genero, peliculas.Nombre, peliculas.Pais, peliculas.Clasificacion, peliculas.Duracion, "Eliminar", "Editar");
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
    }
}
