using DataCineDb.Data;
using DataCineDb.Entidades.Factura;
using DataCineDb.Entidades.Maestras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCineDb.Service
{
    public class ServiceFacturaCompleta
    {
        DbHelper helper = DbHelper.ObtenerInstancia();
        public List<Facturas> GetFacturaCompleta()
        {
            DataTable dt = helper.Consultar("sp_factura_completa");
            List<Facturas> facturas = new List<Facturas>();

            foreach (DataRow row in dt.Rows)
            {
                Facturas factura = new Facturas();
                Funciones funcion = new Funciones();
                Clientes cliente = new Clientes();

                factura.Numero = (int)row[0];
                factura.Fecha = (DateTime)row[1];
                factura.Descuento = (int)row[2];
                funcion.Pelicula.Nombre = row[3].ToString();
                funcion.Fecha = DateTime.Parse(row[4].ToString());
                funcion.Horario = (TimeSpan)row[5];
                factura.FormaPago.FormaPago = row[6].ToString();
                cliente.Nombre = row[7].ToString();
                cliente.Apellido = row[8].ToString();
                funcion.Precio = (decimal)row[10];

                factura.Funciones.Add(funcion);
                factura.Cliente = cliente;
                facturas.Add(factura);
            }
            return facturas;
        }
    }
}
