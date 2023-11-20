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
    public partial class GridFuncionForm : Form
    {
        List<PeliculasE> listPelis;
        List<Salas> listSalas;
        List<Idiomas> idiomas;
        List<Funciones> listFunciones;
        PeliculasEService peliculaService;
        SalasService salaService;
        IdiomaService idiomaService;
        FuncionService funcionService;
        Salas sala;

        public GridFuncionForm()
        {
            InitializeComponent();

            listPelis = new List<PeliculasE>();
            peliculaService = new PeliculasEService();
            salaService = new SalasService();
            listSalas = new List<Salas>();
            idiomas = new List<Idiomas>();
            idiomaService = new IdiomaService();
            sala = new Salas();
            funcionService = new FuncionService();
            listFunciones = new List<Funciones>();


            Cargar();


        }

        private async void GridPeliculaForm_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Cargar()
        {
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

            listFunciones = await funcionService.Get();

            cargarDGV();
        }

        private void NuevoGB_Enter(object sender, EventArgs e)
        {

        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            if ((int)cbSalas.SelectedValue < 1)
            {
                MessageBox.Show("Error: Debe seleccionar una sala.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Salas sala = new Salas();
            sala.Codigo = (int)cbSalas.SelectedValue;
            Funciones funcion = new Funciones();
            if ((int)cbPeliculas.SelectedValue < 1)
            {
                MessageBox.Show("Error: Debe seleccionar una pelicula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            funcion.Pelicula.Codigo = (int)cbPeliculas.SelectedValue;
            funcion.Idioma.Codigo = (int)cbIdioma.SelectedValue;

            DateTime fechaSeleccionada = DateTime.Parse(FechaDTP.Value.ToString());
            if (DateTime.Now > DateTime.Parse(FechaDTP.Value.ToString()))
            {
                MessageBox.Show("Error: La fecha seleccionada no puede ser menor que la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            funcion.Fecha = fechaSeleccionada;
            funcion.Horario = TimeSpan.FromHours((int)nudHora.Value) + TimeSpan.FromMinutes((int)nupMinutos.Value);
            
            funcion.Subtitulada = ChBSubtitulada.Checked;
            funcion.TerceraDimencion = ChB3D.Checked;
            if(nupPrecio.Value <1000)
            {
                MessageBox.Show("Error: No puede haber precios a 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            funcion.Precio = nupPrecio.Value;
            sala.agregarFuncion(funcion);
            try
            {
                await funcionService.Post(sala);
                MessageBox.Show("Funcion creada exitosamente");

            }
            catch
            {
                MessageBox.Show("no se pudo crear la funcion");
            }
            Cargar();




        }

        private void cargarDGV()
        {
            dgvFunciones.Rows.Clear();
            foreach (Funciones funcion in listFunciones)
            {
                dgvFunciones.Rows.Add(funcion.Codigo, funcion.Pelicula.Nombre, funcion.Sala.Numero, funcion.Horario, funcion.Idioma.Idioma, funcion.Fecha.ToString("yyyy-MM-dd"), funcion.TerceraDimencion, funcion.Subtitulada, funcion.Precio, "Eliminar","Editar");
            }
        }

        private async void dgvFunciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFunciones.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                if (e.RowIndex >= 0 && dgvFunciones.Rows[e.RowIndex].Cells["codigo"].Value != null)
                {

                    int codigoFuncion = Convert.ToInt32(dgvFunciones.Rows[e.RowIndex].Cells["codigo"].Value);
                    FuncionService deleteService = new FuncionService(codigoFuncion);
                    DateTime fechaCelda = DateTime.Parse(dgvFunciones.Rows[e.RowIndex].Cells["ClFecha"].Value.ToString());

                    if (fechaCelda < DateTime.Now.AddDays(-1))
                    {
                        MessageBox.Show("Error: La fecha es menor que la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    try
                    {
                        await deleteService.Delete();
                        dgvFunciones.Rows.RemoveAt(e.RowIndex);
                        Cargar();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
            }
            if (dgvFunciones.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                if (e.RowIndex >= 0 && dgvFunciones.Rows[e.RowIndex].Cells["codigo"].Value != null)
                {

                   
                    int codigoFuncion = Convert.ToInt32(dgvFunciones.Rows[e.RowIndex].Cells["codigo"].Value);
                    EditarFuncionForms editarForm = new EditarFuncionForms(codigoFuncion);
                    editarForm.ShowDialog();
                    Cargar();

                }
            }
        }
    }
}
