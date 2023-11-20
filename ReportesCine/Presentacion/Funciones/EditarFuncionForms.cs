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
        List<PeliculasE> listPelis;
        List<Salas> listSalas;
        List<Idiomas> idiomas;
        Funciones funcion;
        PeliculasEService peliculaService;
        SalasService salaService;
        IdiomaService idiomaService;
        FuncionService funcionService;
        Salas sala; 
        
        public EditarFuncionForms(int CodigoFuncion)
        {
            InitializeComponent();
            listPelis = new List<PeliculasE>();
            peliculaService = new PeliculasEService();
            salaService = new SalasService();
            listSalas = new List<Salas>();
            idiomas = new List<Idiomas>();
            idiomaService = new IdiomaService();
            sala = new Salas();
            funcionService = new FuncionService(CodigoFuncion);
            funcion = new Funciones();
            funcion.Codigo = CodigoFuncion;
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
            cbPeliculas.SelectedValue = funcion.Pelicula.Codigo;
            listSalas = await salaService.Get();

            cbSalas.DataSource = listSalas;
            cbSalas.DisplayMember = "Codigo";
            cbSalas.ValueMember = "Codigo";
            cbSalas.SelectedValue = funcion.Sala.Codigo;

            idiomas = await idiomaService.Get();
            cbIdioma.DataSource = idiomas;
            cbIdioma.DisplayMember = "Idioma";
            cbIdioma.ValueMember = "Codigo";
            cbIdioma.SelectedValue = funcion.Idioma.Codigo;

            nudHora.Value = (int)funcion.Horario.Hours;
            nupMinutos.Value = (int)funcion.Horario.Minutes;

            FechaDTP.Value = funcion.Fecha;

            nupPrecio.Value = Math.Round((decimal)funcion.Precio, 2);

            ChBSubtitulada.Checked = funcion.Subtitulada;
            ChB3D.Checked = funcion.TerceraDimencion;
                

        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if((int)cbSalas.SelectedValue < 1)
            {
                MessageBox.Show("Error: Debe seleccionar una sala.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            funcion.Sala.Codigo = (int)cbSalas.SelectedValue;
            
            if ((int)cbPeliculas.SelectedValue < 1)
            {
                MessageBox.Show("Error: Debe seleccionar una pelicula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            funcion.Pelicula.Codigo = (int)cbPeliculas.SelectedValue;
            funcion.Idioma.Codigo = (int)cbIdioma.SelectedValue;
            DateTime fechaSeleccionada = DateTime.Parse(FechaDTP.Value.ToString());
            if (DateTime.Now.AddDays(-1) > DateTime.Parse(FechaDTP.Value.ToString()))
            {
                MessageBox.Show("Error: La fecha seleccionada no puede ser menor que la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            funcion.Fecha = fechaSeleccionada;

            funcion.Horario = TimeSpan.FromHours((int)nudHora.Value) + TimeSpan.FromMinutes((int)nupMinutos.Value);

            funcion.Subtitulada = ChBSubtitulada.Checked;
            funcion.TerceraDimencion = ChB3D.Checked;
            if (nupPrecio.Value < 1000)
            {
                MessageBox.Show("Error: No puede haber precios a 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            funcion.Precio = nupPrecio.Value;
            sala.agregarFuncion(funcion);
            try
            {
                await funcionService.put(funcion);
                MessageBox.Show("se modifico la funcion");
                this.Close();

            }
            catch
            {
                MessageBox.Show("no se pudo crear la funcion");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Quieres salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
