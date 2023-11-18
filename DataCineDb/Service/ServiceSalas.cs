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
    public class ServiceSalas
    {
        DbHelper helper = DbHelper.ObtenerInstancia();
        public List<Salas> GetSalas()
        {
            DataTable dt = helper.Consultar("sp_get_Salas");
            List<Salas> paises = new List<Salas>();

            foreach (DataRow row in dt.Rows)
            {
                Salas sala = new Salas();
                sala.Codigo = (int)row[0];
                sala.Numero = (int)row[2];
                sala.Tipo.Codigo = (int)row[1];
                paises.Add(sala);
            }
            return paises;
        }
    }
}
