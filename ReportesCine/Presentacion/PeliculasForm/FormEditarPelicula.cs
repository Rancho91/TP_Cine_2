using ReportesCine.Entidades;
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

namespace ReportesCine.Presentacion.Peliculas
{
    public partial class FormEditarPelicula : Form
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
        public FormEditarPelicula(int codPelicula)
        {
            InitializeComponent();
            lstPeliculas = new List<PeliculasE>();
            lstGeneros = new List<Generos>();
            lstPaises = new List<Paises>();
            lstClasificaciones = new List<Clasificaciones>();
            peService = new PeliculasEService(codPelicula);
            generoService = new GeneroService();
            paisService = new PaisService();
            claService = new ClasificacionService();
            pelicula = new PeliculasE();

            Cargar();
        }

        private  void FormEditarPelicula_Load(object sender, EventArgs e)
        {
            

        }
        private async void Cargar()
        {
            List<PeliculasE> list =await peService.GetId();
            pelicula = list[0] ;
            lstGeneros = await generoService.Get();
            cboGenero.DataSource = lstGeneros;
            cboGenero.DisplayMember = "Genero";
            cboGenero.ValueMember = "Codigo";
            cboGenero.SelectedValue = pelicula.Genero.Codigo;

            lstPaises = await paisService.Get();
            cboPais.DataSource = lstPaises;
            cboPais.DisplayMember = "Pais";
            cboPais.ValueMember = "Codigo";
            cboPais.SelectedValue = pelicula.Pais.Codigo;

            lstClasificaciones = await claService.Get();
            cboClasificacion.DataSource = lstClasificaciones;
            cboClasificacion.DisplayMember = "Clasificacion";
            cboClasificacion.ValueMember = "Codigo";
            cboClasificacion.SelectedValue = pelicula.Clasificacion.Codigo;

            txtNombrePelicula.Text = pelicula.Nombre;
            nudHora.Value = (int)pelicula.Duracion.Hours;
            nupMinutos.Value = (int)pelicula.Duracion.Minutes;
           
        }

        private async void btnEditarPelicula_Click(object sender, EventArgs e)
        {
            pelicula.Nombre = txtNombrePelicula.Text;
            pelicula.Duracion = TimeSpan.FromHours((int)nudHora.Value) + TimeSpan.FromMinutes((int)nupMinutos.Value);
            pelicula.Pais.Codigo = (int)cboPais.SelectedValue;
            pelicula.Clasificacion.Codigo = (int)cboClasificacion.SelectedValue;
            pelicula.Genero.Codigo = (int)cboGenero.SelectedValue;
            try
            {
                await peService.put(pelicula);
                MessageBox.Show("Pelicula Modificada");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar la pelicula");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
