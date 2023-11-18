using DataCineDb.Data;
using DataCineDb.Entidades.Auxiliares;
using DataCineDb.Entidades.Maestras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCineDb.Service
{
    public class ServiceFunciones
    {
        DbHelper helper = DbHelper.ObtenerInstancia();
        public List<Funciones> getFunciones()
        {
            List<Funciones> funciones = new List<Funciones>();
            DataTable dt = helper.Consultar("SP_GET_TODAS_FUNCIONES");
                foreach (DataRow row in dt.Rows)
            {
                Salas sala = new Salas();
                sala.Numero = (int)row[9];
                funciones.Add(
                new Funciones(
                (int)row[0],
                 new Peliculas(row[1].ToString()),
                DateTime.Parse(row[3].ToString()),
                TimeSpan.Parse(row[2].ToString()),
                (decimal)row[7],
                (bool)row[6],
                (bool)row[5],
                new Idiomas(row[8].ToString()),
                sala

                    ));

            }
            return funciones;
        }
        public Funciones getFuncionesButacas(int codFuncion)
        {
            Funciones funcion = new Funciones();
            funcion.Codigo = codFuncion;
            List<Parametros> parametros = new List<Parametros>();
            parametros.Add(new Parametros("@cod_funcion", codFuncion));
            DataTable dt = helper.Consultar("SP_FUNCIONES_BUTACAS", parametros);
            funcion.Pelicula.Codigo = (int)dt.Rows[0][1];
            funcion.Sala.Codigo = (int)dt.Rows[0][2];
            funcion.Horario = TimeSpan.Parse(dt.Rows[0][3].ToString());
            funcion.Fecha = DateTime.Parse(dt.Rows[0][4].ToString());
            funcion.TerceraDimencion = (bool)dt.Rows[0][5];
            funcion.Subtitulada = (bool)dt.Rows[0][6];
            funcion.Precio = (decimal)dt.Rows[0][7];
            funcion.Idioma.Codigo= (int)dt.Rows[0][1];



            return funcion;
        }

        public void postFunciones(Salas sala)
        {
            
                foreach (Funciones funcion in sala.Funciones)
                {
                    List<Parametros> listParametros = new List<Parametros>();
                    listParametros.Add(new Parametros("@Cod_pelicula", funcion.Pelicula.Codigo));
                    listParametros.Add(new Parametros("@Cod_sala", sala.Codigo));
                    listParametros.Add(new Parametros("@Horario", funcion.Horario));
                    listParametros.Add(new Parametros("@terceraDimencion", funcion.TerceraDimencion));
                    listParametros.Add(new Parametros("@subtitulos", funcion.Subtitulada));
                    listParametros.Add(new Parametros("@fecha", funcion.Fecha));
                    listParametros.Add(new Parametros("@Precio", funcion.Precio));
                    listParametros.Add(new Parametros("@Cod_idioma", funcion.Idioma.Codigo));
                    helper.Insertar("SP_FUNCIONES_INSERT", listParametros);
                }
             
          
            


        }

        public void putFunciones(Funciones funcion)
        {

           
                List<Parametros> listParametros = new List<Parametros>();
                listParametros.Add(new Parametros("@cod_funcion", funcion.Codigo));
                if (funcion.Pelicula.Codigo > 0) listParametros.Add(new Parametros("@Cod_pelicula", funcion.Pelicula.Codigo));
                if (funcion.Sala.Codigo > 0) listParametros.Add(new Parametros("@Cod_sala", funcion.Sala.Codigo));
                if (funcion.Horario > (TimeSpan.FromHours(0) + TimeSpan.FromMinutes(0))) listParametros.Add(new Parametros("@Horario", funcion.Horario));
                listParametros.Add(new Parametros("@terceraD", funcion.TerceraDimencion));
                listParametros.Add(new Parametros("@subtitulos", funcion.Subtitulada));
                listParametros.Add(new Parametros("@fecha", funcion.Fecha));
                if(funcion.Precio >0) listParametros.Add(new Parametros("@Precio", funcion.Precio));
                if(funcion.Idioma.Codigo>0) listParametros.Add(new Parametros("@Cod_idioma", funcion.Idioma.Codigo));

                helper.Insertar("sp_update_funcion", listParametros);


        }
        public bool deleteFuncion(int codigo)
        {
            List<Parametros> listParametros = new List<Parametros>();
            listParametros.Add(new Parametros("@cod_funcion", codigo));
            try
            {
                helper.Insertar("sp_delete_funcion", listParametros);
                return true;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
    }
}
