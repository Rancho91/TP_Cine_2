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


namespace ReportesCine.Presentacion.Facturas
{
    public partial class FacturaForm : Form
    {

        private FuncionService funcionService;

        private ReporteButacasDisponiblesService reporteDBService;

        private Dictionary<Button, bool> botonesEstado = new Dictionary<Button, bool>();

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
            llenarFunciones();
        }

        private async void llenarFunciones()
        {

            List<Funciones> lst = await funcionService.Get();

            cboFunciones.DataSource = lst;

            cboFunciones.DisplayMember = "codigo";

            cboFunciones.ValueMember = "codigo";

            cboFunciones.DropDownStyle = ComboBoxStyle.DropDownList;
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
            CambiarImagenBoton(boton);
        }
    }
}
