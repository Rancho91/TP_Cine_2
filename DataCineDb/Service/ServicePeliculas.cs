
using DataCineDb.Data;
using DataCineDb.Entidades;
using DataCineDb.Entidades.Maestras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCineDb.Service
{
    public class ServicePeliculas
    {
        DbHelper helper = DbHelper.ObtenerInstancia();

        public List<Peliculas> GetPeliculas()
        {
            DataTable dt = helper.Consultar("SP_GET_TODAS_PELICULAS");
            List<Peliculas> peliculas = new List<Peliculas>();

            foreach (DataRow row in dt.Rows)
            {
                peliculas.Add(
                    new Peliculas(
                         (int)row[0],
                        row[2].ToString(),
                       new Generos( row[1].ToString()),
                       new Clasificaciones( row[4].ToString()),
                       new Paises( row[3].ToString()),                 
                       TimeSpan.Parse( row[5].ToString())
                        ));
            }
            return peliculas;
        }

        public List<Funciones> GetFuncionesPorPelicula(int codigoPelicula)
        {
            List<Funciones> funciones = new List<Funciones>();
            List<Parametros> parametros = new List<Parametros>();
            parametros.Add(new Parametros("@codigo_pelicula", codigoPelicula));

            DataTable dt = helper.Consultar("sp_funciones_por_pelicula_y_sala_con_idioma", parametros);

            foreach (DataRow row in dt.Rows)
            {
                Funciones funcion = new Funciones();
                funcion.Codigo = (int)row["COD_FUNCION"];
                funcion.Pelicula.Codigo = (int)row["COD_PELICULA"];
                funcion.Horario = TimeSpan.Parse(row["HORARIO"].ToString());
                funcion.Fecha = DateTime.Parse(row["FECHA"].ToString());
                funcion.TerceraDimencion = (bool)row["TERCERA_DIMENCION"];
                funcion.Subtitulada = (bool)row["SUBTITULOS"];
                funcion.Precio = (decimal)row["PRECIO"];
                funcion.Idioma.Idioma = row["NombreIdioma"].ToString();

                funciones.Add(funcion);
            }

            return funciones;
        }

        public bool postPelicula(Peliculas pelicula)
        {
            bool error=false;
            try
            {
                List<Parametros> parametros = new List<Parametros>();
                if (pelicula.Genero.Codigo > 0)
                {
                    parametros.Add(new Parametros("@cod_genero", pelicula.Genero.Codigo));
                }
                parametros.Add(new Parametros("@nombre", pelicula.Nombre));
                if (pelicula.Pais.Codigo > 0) parametros.Add(new Parametros("@cod_pais", pelicula.Pais.Codigo));
                if(pelicula.Clasificacion.Codigo>0) parametros.Add(new Parametros("@cod_clasificacion", pelicula.Clasificacion.Codigo));
                parametros.Add(new Parametros("@duracion", pelicula.Duracion));
                helper.Insertar("sp_crear_pelicula", parametros);

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Stack Trace: {ex}");
                return error;
            }


        }
        public bool modPelicula(Peliculas pelicula)
        {
            bool error = false;
            TimeSpan duracion = TimeSpan.FromHours(0) + TimeSpan.FromMinutes(0);
            try
            {
                List<Parametros> parametros = new List<Parametros>();
                if(pelicula.Codigo>0) parametros.Add(new Parametros("@cod_pelicula", pelicula.Codigo));

                if (pelicula.Genero.Codigo > 0)
                {
                    parametros.Add(new Parametros("@cod_genero", pelicula.Genero.Codigo));
                }
                if(pelicula.Nombre != "" || pelicula.Nombre != string.Empty) parametros.Add(new Parametros("@nombre", pelicula.Nombre));

                if (pelicula.Pais.Codigo > 0) parametros.Add(new Parametros("@cod_pais", pelicula.Pais.Codigo));

                if (pelicula.Clasificacion.Codigo > 0) parametros.Add(new Parametros("@cod_clasificacion", pelicula.Clasificacion.Codigo));
                if(pelicula.Duracion != duracion) parametros.Add(new Parametros("@duracion", pelicula.Duracion));

                helper.Insertar("sp_update_pelicula", parametros);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Stack Trace: {ex}");
                return error;
            }


        }
        public bool EliminarPelicula( int codigo)
        {
            bool error = false;
            try
            {
                List<Parametros> parametros = new List<Parametros>();

                parametros.Add(new Parametros("@cod_pelicula", codigo));

                helper.Insertar("sp_delete_pelicula", parametros);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Stack Trace: {ex}");
                return error;
            }

            
        }
        public List<Peliculas> GetPeliculas(int id)
        {
            List<Peliculas> peliculas = new List<Peliculas>();
            List<Parametros> parametros = new List<Parametros>();
            parametros.Add(new Parametros("@cod_pelicula", id));
            DataTable dt = helper.Consultar("sp_get_Pelicula_ID", parametros);

            foreach (DataRow row in dt.Rows)
            {
                peliculas.Add(
                    new Peliculas(
                         (int)row[0],
                        row[2].ToString(),
                       new Generos("",(int)row[1]),
                       new Clasificaciones("",(int)row[4]),
                       new Paises("",(int)row[3]),
                       TimeSpan.Parse(row[5].ToString())
                        ));
            }
            return peliculas;
        }
    }
}


