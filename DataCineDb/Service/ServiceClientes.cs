using DataCineDb.Data;
using DataCineDb.Entidades.Maestras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCineDb.Service
{
    public class ServiceClientes
    {
        DbHelper helper = DbHelper.ObtenerInstancia();
        public List<Clientes> GetClientes()
        {
            DataTable dt = helper.Consultar("sp_obtener_datos_cliente");
            List<Clientes> lstClientes = new List<Clientes>();

            foreach (DataRow row in dt.Rows)
            {
                Clientes cliente = new Clientes();
                cliente.Codigo = (int)row[0];
                cliente.Nombre = row[1].ToString();
                cliente.Apellido = row[2].ToString();
                cliente.Documento = row[3].ToString();
                lstClientes.Add(cliente);
            }
            return lstClientes;
        }
    }
}
