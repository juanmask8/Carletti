using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class LibroRepository
    {
        public static Libro GetLibroById(int id)
        {
            Libro libro = null;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM LIBRO WHERE IdLibro = "+id, DataConnectionManager.getInstance().getConnection());
                /*
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.Value = id;
                cmd.Parameters.Add(param);
                 * */
                /*
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;
                */
                DataConnectionManager.getInstance().getConnection().Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idr = (int)reader.GetValue(0);
                    String ISBN = (String)reader.GetValue(6);
                    String titulo = (String)reader.GetValue(1);
                    String detalle = (String)reader.GetValue(2);
                    String imagen = (String)reader.GetValue(4);
                    String url = (String)reader.GetValue(5);
                    String copete = (String)reader.GetValue(3);
                    libro = new Libro(idr, titulo, detalle, copete, imagen, url, ISBN);
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DataConnectionManager.getInstance().getConnection().Close();
            }
            //libro = new Libro(2, "tituloasd", "detalleasd", "copeteasd", "imagenasd", "urlasd", "ISBNasd");
            return libro;
        }

        public static List<Libro> GetAll()
        {
            List<Libro> listaDeLibros = new List<Libro>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM LIBRO", DataConnectionManager.getInstance().getConnection());
                DataConnectionManager.getInstance().getConnection().Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idr = (int)reader.GetValue(0);
                    String ISBN = (String)reader.GetValue(6);
                    String titulo = (String)reader.GetValue(1);
                    String detalle = (String)reader.GetValue(2);
                    String imagen = (String)reader.GetValue(4);
                    String url = (String)reader.GetValue(5);
                    String copete = (String)reader.GetValue(3);
                    listaDeLibros.Add(new Libro(idr, titulo, detalle, copete, imagen, url, ISBN));
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DataConnectionManager.getInstance().getConnection().Close();
            }
            return listaDeLibros;
        }
    }
}
