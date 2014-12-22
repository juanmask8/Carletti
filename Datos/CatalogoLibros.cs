using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class CatalogoLibros
    {

        public static List<Libro> getAllLibros()
        {
            List<Libro> Libros = new List<Libro>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM LIBROS", DataConnectionManager.getInstance().getConnection());
                DataConnectionManager.getInstance().getConnection().Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Libros = DataConnectionManager.DataReaderToList(dr);
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

            return Libros;

        }

        public static Libro getLibroByTitulo(String titulo)
        {
            Libro libro = null;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM LIBROS WHERE TITULO = @titulo", DataConnectionManager.getInstance().getConnection());
                cmd.Parameters.Add("@titulo", SqlDbType.VarChar);
                cmd.Parameters["@titulo"].Value = titulo;
                DataConnectionManager.getInstance().getConnection().Open();
                SqlDataReader dr = cmd.ExecuteReader();
                int id = (int)dr.GetValue(0);
                int ISBN = (int)dr.GetValue(1);
                String tit = (String)dr.GetValue(2);
                String detalle = (String)dr.GetValue(3);
                String imagen = (String)dr.GetValue(4);
                String url = (String)dr.GetValue(5);
                libro = new Libro(id, tit, imagen, detalle, url, ISBN);
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
            return libro;
        }
    }
}
