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
        private PeliculasXFuncionService pxfService;
        private FormaPagoService fpService;
        private ClientesService clientesService;
        private FacturaService facturaService;

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
            cboDescuento.SelectedIndex = 0;
            cboDescuento.DropDownStyle = ComboBoxStyle.DropDownList;

            funcionService = new FuncionService();
            peliculasService = new PeliculasEService();
            fpService = new FormaPagoService();
            clientesService = new ClientesService();
            facturaService = new FacturaService();

            butacas = new List<ReporteButacasDisponibles>();
            factura = new FacturasE();

            llenarClientes();
            llenarPeliculas();
            llenarFormasDePago();
            habilitarDeshabilitar();
        }

        private async void llenarClientes()
        {
            List<Clientes> lst = await clientesService.Get();

            cboClientes.DataSource = lst;

            cboClientes.DisplayMember = "Documento";

            cboClientes.ValueMember = "codigo";

            cboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void llenarFormasDePago()
        {
            List<FormasPagos> lst = await fpService.Get();

            cboFormaDePago.DataSource = lst;

            cboFormaDePago.DisplayMember = "formaPago";

            cboFormaDePago.ValueMember = "codigo";

            cboFormaDePago.DropDownStyle = ComboBoxStyle.DropDownList;
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
                    pxfService = new PeliculasXFuncionService((int)cboPeliculas.SelectedValue);

                    // Obtener las funciones correspondientes a la película seleccionada
                    List<Funciones> funcionesPorPelicula = await pxfService.GetIdPeliculasXFunciones();

                    cboFunciones.DataSource = funcionesPorPelicula;
                    cboFunciones.ValueMember = "codigo"; 
                    cboFunciones.DropDownStyle = ComboBoxStyle.DropDownList;

                    lstBoxFunc.DataSource = funcionesPorPelicula;
                    lstBoxFunc.DisplayMember = "ToString";
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

        private Button ObtenerBotonPorCodigoButaca(int codigoButaca)
        {
            foreach (Button boton in botonesEstado.Keys)
            {
                int codigo = (int)boton.Tag;
                if (codigo == codigoButaca)
                {
                    return boton;
                }
            }
            return null; // En caso de no encontrar el botón con el código de butaca especificado
        }

        private async void Boton_Click(object sender, EventArgs e)
        {
            try
            {
                Button boton = (Button)sender;

                if (boton.Name != "btnBuscar" && boton.Name != "btnGuardar" && boton.Name != "btnSalir" && boton.Name != "btnCancelar")
                {
                    // Obtén el código de la butaca del Tag del botón
                    int codigoButaca = (int)boton.Tag;

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
                        Calculartotal();
                    }
                    else
                    {
                        // Si la butaca ya está en la lista, retírala
                        funcion.Butacas.Remove(oButaca);
                        // Añade aquí la lógica adicional según tus necesidades
                        // Por ejemplo, puedes actualizar la interfaz de usuario o realizar otras operaciones relacionadas con la cancelación de la compra
                        MessageBox.Show($"Butaca {codigoButaca} cancelada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Calculartotal();
                    }

                    CambiarImagenBoton(boton);
                }
                else if (boton.Name == "btnSalir")
                {
                    btnSalir_Click(sender, e);
                }
                else if (boton.Name == "btnCancelar")
                {
                    cargarButacas();
                    lstBoxFunc.Enabled = true;
                    cboFunciones.Enabled = true;
                    lstBoxFunc.DataSource = null;
                    lstBoxFunc.Items.Clear();
                    cboPeliculas.SelectedIndex = -1;
                    cboFunciones.SelectedIndex = -1;
                    MessageBox.Show("Cancelación de butacas realizada correctamente.", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(boton.Name == "btnGuardar")
                {
                    factura.FormaPago.Codigo = (int)cboFormaDePago.SelectedValue;
                    factura.Cliente.Codigo = (int)cboClientes.SelectedValue;
                    factura.TipoFactura.Codigo = 2;
                    factura.Fecha = DateTime.Now;
                    funcion.Precio = ((Funciones)cboFunciones.SelectedItem).ObtenerPrecio();

                    if (cboDescuento.SelectedItem == "0%")
                    {
                        factura.Descuento = 0;
                        factura.AgregarFuncion(funcion);
                    }
                    else if (cboDescuento.SelectedItem == "5%")
                    {
                        factura.Descuento = 5;
                        funcion.Precio *= (decimal)0.95;
                        factura.AgregarFuncion(funcion);
                    }
                    else if (cboDescuento.SelectedItem == "15%")
                    {
                        factura.Descuento = 15;
                        funcion.Precio *= (decimal)0.85;
                        factura.AgregarFuncion(funcion);
                    }
                    else if(cboDescuento.SelectedItem == "25%")
                    {
                        factura.Descuento = 25;
                        funcion.Precio *= (decimal)0.75;
                        factura.AgregarFuncion(funcion);
                    }
                    else
                    {
                        factura.Descuento = 50;
                        funcion.Precio *= (decimal)0.50;
                        factura.AgregarFuncion(funcion);
                    }
                    await facturaService.Post(factura);
                    lblTotal.Text = "0";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error al cerrar el formulario: {ex.Message}");
            }
        }
    

    private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboPeliculas.SelectedItem == null)
            {
             
                MessageBox.Show("Por favor, seleccione una película", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            funcion = new Funciones();
            funcion.Codigo = (int)cboFunciones.SelectedValue;
            Funciones funcionSeleccionada = (Funciones)cboFunciones.SelectedItem;
            funcion.Precio = funcionSeleccionada.Precio;
            serviceButacas = new ReporteButacasDisponiblesService((int)cboFunciones.SelectedValue,"Ñ");
            butacas = await serviceButacas.GetReporte();
            cboFunciones.Enabled = false;
            lstBoxFunc.Enabled = false;
            habilitarDeshabilitar();
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



        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Cierra el formulario actual
            }
        }

        private void cboPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
           


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Calculartotal()
        {
            decimal total;
            if (factura != null)
            {
                if (cboDescuento.SelectedItem == "0%")
                {
                    factura.Descuento = 0;
                    total = funcion.Butacas.Count * funcion.Precio;
                    lblTotal.Text = total.ToString();
                }
                else if (cboDescuento.SelectedItem == "5%")
                {
                    factura.Descuento = 5;
                    total = funcion.Butacas.Count * funcion.Precio * (decimal)0.95;
                    lblTotal.Text = total.ToString();
                }
                else if (cboDescuento.SelectedItem == "15%")
                {
                    factura.Descuento = 15;
                    total = funcion.Butacas.Count * funcion.Precio * (decimal)0.85;
                    lblTotal.Text = total.ToString();

                }
                else if (cboDescuento.SelectedItem == "25%")
                {
                    factura.Descuento = 25;
                    total = funcion.Butacas.Count * funcion.Precio * (decimal)0.75;
                    lblTotal.Text = total.ToString();

                }
                else
                {
                    factura.Descuento = 50;
                    total = funcion.Butacas.Count * funcion.Precio * (decimal)0.50;
                    lblTotal.Text = total.ToString();

                }
            }
        }

        private void cboDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculartotal();
        }

        private void habilitarDeshabilitar()
        {
            btnCancelar.Enabled=!btnCancelar.Enabled;
            butaca1.Enabled = !butaca1.Enabled;
            butaca2.Enabled = !butaca2.Enabled;
            butaca3.Enabled = !butaca3.Enabled;
            butaca4.Enabled = !butaca4.Enabled;
            butaca5.Enabled = !butaca5.Enabled;
            butaca6.Enabled = !butaca6.Enabled;
            butaca7.Enabled = !butaca7.Enabled;
            butaca8.Enabled = !butaca8.Enabled;
            butaca9.Enabled = !butaca9.Enabled;
            butaca10.Enabled = !butaca10.Enabled;
            butaca11.Enabled = !butaca11.Enabled;
            butaca12.Enabled = !butaca12.Enabled;
            butaca13.Enabled = !butaca13.Enabled;
            butaca14.Enabled = !butaca14.Enabled;
            butaca15.Enabled = !butaca15.Enabled;
            butaca16.Enabled = !butaca16.Enabled;
            butaca17.Enabled = !butaca17.Enabled;
            butaca18.Enabled = !butaca18.Enabled;
            butaca19.Enabled = !butaca19.Enabled;
            butaca20.Enabled = !butaca20.Enabled;




        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarDeshabilitar();
        }

        private void listboxFunciones_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
