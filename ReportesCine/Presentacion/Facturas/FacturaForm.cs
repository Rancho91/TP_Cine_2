using ReportesCine.Entidades.Maestras;
using ReportesCine.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportesCine;
using ReportesCine.Entidades.Reportes;
using Microsoft.Reporting.WinForms;
using System.ServiceProcess;
using ReportesCine.Entidades.Factura;

namespace ReportesCine.Presentacion.Facturas
{
    public partial class FacturaForm : Form
    {

        private FuncionService funcionService;
        private PeliculasEService peliculasService;
        private PeliculasXFuncion pxfService;

        private Dictionary<Button, bool> botonesEstado = new Dictionary<Button, bool>();

        List<ReporteButacasDisponibles> butacas;
        ReporteButacasDisponiblesService serviceButacas;
        FacturasE factura;
        Funciones funcion;
        public FacturaForm()
        {
            InitializeComponent();

            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    Button boton = (Button)control;
                    botonesEstado.Add(boton, false); // Inicialmente, todos los botones están en estado 'false'
                    boton.Click += Boton_Click; // Agrega el evento clic a cada botón
                }
            }
        }

        private void FacturaForm_Load(object sender, EventArgs e)
        {
            funcionService = new FuncionService();
            peliculasService = new PeliculasEService();

            butacas = new List<ReporteButacasDisponibles>();
            factura = new FacturasE();
            llenarPeliculas();
        }

        private async void llenarPeliculas()
        {

            List<PeliculasE> lst = await peliculasService.Get();

            cboPeliculas.DataSource = lst;

            cboPeliculas.DisplayMember = "nombre";

            cboPeliculas.ValueMember = "codigo";

            cboPeliculas.DropDownStyle = ComboBoxStyle.DropDownList;

            cboPeliculas.SelectedIndexChanged += async (sender, args) =>
            {
                if (cboPeliculas.SelectedValue != null && cboPeliculas.SelectedIndex != -1)
                {
                    pxfService = new PeliculasXFuncion((int)cboPeliculas.SelectedValue);

                    // Obtener las funciones correspondientes a la película seleccionada
                    List<Funciones> funcionesPorPelicula = await pxfService.GetIdPeliculasXFunciones();

                    cboFunciones.DataSource = funcionesPorPelicula;
                    cboFunciones.DisplayMember = "codigo"; // Ajusta este campo según el nombre de tu propiedad en Funciones
                    cboFunciones.ValueMember = "codigo"; // Ajusta este campo según el nombre de tu propiedad en Funciones
                    cboFunciones.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            };
        }

        private void CambiarImagenBoton(Button boton)
        {
            if (botonesEstado.ContainsKey(boton))
            {
                bool estadoActual = botonesEstado[boton];

                // Si el botón está en su estado original, cambia a la nueva imagen
                if (!estadoActual)
                {
                    boton.Image = Properties.Resources.butaca_roja; // Reemplaza "NuevaImagen" con el nombre de tu imagen
                    botonesEstado[boton] = true;
                }
                else
                {
                    // Si el botón está en el estado modificado, cambia a la imagen anterior
                    boton.Image = Properties.Resources.butaca_verde; // Reemplaza "ImagenAnterior" con el nombre de la imagen anterior
                    botonesEstado[boton] = false;
                }
            }
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (boton.Name != "btnBuscar")
            {
                // Obtén el código de la butaca del Tag del botón
                int codigoButaca =(int)boton.Tag ;

                // Busca la butaca en la lista de butacas asociadas a la función
                Butacas oButaca = funcion.Butacas.FirstOrDefault(b => b.Codigo == codigoButaca);

                if (oButaca == null)
                {
                    
                    Butacas newButaca = new Butacas();
                    newButaca.Codigo = codigoButaca;
                    funcion.Butacas.Add(newButaca);
                    // Añade aquí la lógica adicional según tus necesidades
                    // Por ejemplo, puedes actualizar la interfaz de usuario o realizar otras operaciones relacionadas con la compra de la butaca
                    MessageBox.Show($"Butaca {codigoButaca} comprada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Si la butaca ya está en la lista, retírala
                    funcion.Butacas.Remove(oButaca);
                    // Añade aquí la lógica adicional según tus necesidades
                    // Por ejemplo, puedes actualizar la interfaz de usuario o realizar otras operaciones relacionadas con la cancelación de la compra
                    MessageBox.Show($"Butaca {codigoButaca} cancelada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CambiarImagenBoton(boton);
            }

        }
    

    private async void btnBuscar_Click(object sender, EventArgs e)
        {
            serviceButacas = new ReporteButacasDisponiblesService(1,"Ñ");
            butacas = await serviceButacas.GetReporte();
            cargarButacas();
        }

        private async void cargarButacas()
        {

            for (int i = 1; i <= 20; i++)
            {
                string nombreBoton = "Butaca" + i.ToString();
                Button boton = Controls.Find(nombreBoton, true).FirstOrDefault() as Button;

                if (boton != null)
                {
                    // Obtén la butaca correspondiente en la lista
                    ReporteButacasDisponibles butaca = butacas[i - 1];

                    if (butaca != null)
                    {
                        boton.Tag = butaca.Codigo;
                        if (butaca.Estado == "Disponible")
                        {
                            boton.Image = Properties.Resources.butaca_verde; 
                            botonesEstado[boton] = false; // Cambia el estado del botón
                        }
                        else if (butaca.Estado == "No Disponible")
                        {
                            boton.Image = Properties.Resources.butaca_roja; 
                            botonesEstado[boton] = true;
                            boton.Enabled = false;
                                                    
                        }
                    }
                }

            }
        }

        private void butaca1_Click(object sender, EventArgs e)
        {

        }

        private void cboFunciones_SelectedIndexChanged(object sender, EventArgs e)
        {
           funcion = new Funciones();
            if (cboFunciones.SelectedItem != null)
            {
                funcion = (Funciones)cboFunciones.SelectedItem;
            }
        }

        private void bataca17_Click(object sender, EventArgs e)
        {
            // Obtén el botón que activó el evento
            Button boton = (Button)sender;

            // Obtén el índice del botón en la lista de botones
            int indiceBoton = ObtenerIndiceBoton(boton);

            // Verifica si el botón está en estado verde
            if (!botonesEstado[boton])
            {
                // El botón está en estado verde, crea una nueva butaca
                Butacas butaca = new Butacas();
                butaca.Codigo = butacas[indiceBoton].Codigo;

                // Agrega aquí la lógica para trabajar con la nueva butaca
                // ...

                // Por ejemplo, puedes mostrar un mensaje con el código de la butaca creada
            }
            else
            {
                // El botón está en estado rojo, busca el código en la lista de butacas y retíralo del array
                int codigoButaca = butacas[indiceBoton].Codigo;

                // Agrega aquí la lógica para trabajar con la butaca roja
                // ...

                // Por ejemplo, puedes mostrar un mensaje con el código de la butaca a retirar
                MessageBox.Show($"Butaca roja con código: {codigoButaca}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int ObtenerIndiceBoton(Button boton)
        {
            // Este método obtiene el índice del botón en la lista de botones
            // Itera sobre la lista de botones y retorna el índice del botón correspondiente

            for (int i = 0; i < botonesEstado.Count; i++)
            {
                if (botonesEstado.ElementAt(i).Key == boton)
                {
                    return i;
                }
            }

            return -1; // Retorna -1 si no se encuentra el botón (esto debería ser manejado según tus necesidades)
        }
    }
}
