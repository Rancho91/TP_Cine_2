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

namespace ReportesCine.Presentacion.Pelicula
{
    public partial class EditarFuncionForms : Form
    {
        List<Peliculas> listPelis;
        List<Salas> listSalas;
        List<Idiomas> idiomas;
        Funciones funcion;
        PeliculasService peliculaService;
        SalasService salaService;
        IdiomaService idiomaService;
        FuncionService funcionService;
        Salas sala; 
        
        public EditarFuncionForms(int CodigoFuncion)
        {
            InitializeComponent();
            listPelis = new List<Peliculas>();
            peliculaService = new PeliculasService();
            salaService = new SalasService();
            listSalas = new List<Salas>();
            idiomas = new List<Idiomas>();
            idiomaService = new IdiomaService();
            sala = new Salas();
            funcionService = new FuncionService(CodigoFuncion);
            funcion = new Funciones();
            cargarForm();

        }

        private void EditarFuncionForms_Load(object sender, EventArgs e)
        {
 
        }

        private async void cargarForm()
        {
            funcion = await funcionService.GetId();

            listPelis = await peliculaService.Get();
            cbPeliculas.DataSource = listPelis;
            cbPeliculas.DisplayMember = "Nombre";
            cbPeliculas.ValueMember = "Codigo";

            listSalas = await salaService.Get();

            cbSalas.DataSource = listSalas;
            cbSalas.DisplayMember = "Codigo";
            cbSalas.ValueMember = "Codigo";


            idiomas = await idiomaService.Get();
            cbIdioma.DataSource = idiomas;
            cbIdioma.DisplayMember = "Idioma";
            cbIdioma.ValueMember = "Codigo";

            nudHora.Value = (int)funcion.Horario.Hours;
            nupMinutos.Value = (int)funcion.Horario.Minutes;

            FechaDTP.Value = funcion.Fecha;

            nupPrecio.Value = Math.Round((decimal)funcion.Precio, 2);

            ChBSubtitulada.Checked = funcion.Subtitulada;
            ChB3D.Checked = funcion.TerceraDimencion;
                

        }







    }
}
