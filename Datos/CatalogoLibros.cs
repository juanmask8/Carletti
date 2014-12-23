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
                String ISBN = (String)dr.GetValue(1);
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

        public static bool agregarLibro(Libro libro)
        {
            int rta = -1;
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO LIBROS (ISBN,titulo,detalle,imagen,url) VALUES(@isbn,@titulo,@detalle,@imagen,@url)", DataConnectionManager.getInstance().getConnection());
                cmd.Parameters.Add("@isbn", SqlDbType.VarChar);
                cmd.Parameters["@isbn"].Value = libro.ISBN;
                cmd.Parameters.Add("@titulo", SqlDbType.VarChar);
                cmd.Parameters["@titulo"].Value = libro.titulo;
                cmd.Parameters.Add("@detalle", SqlDbType.VarChar);
                cmd.Parameters["@detalle"].Value = libro.detalle;
                cmd.Parameters.Add("@imagen", SqlDbType.VarChar);
                cmd.Parameters["@imagen"].Value = libro.imagen;
                cmd.Parameters.Add("@url", SqlDbType.VarChar);
                cmd.Parameters["@url"].Value = libro.url;
                DataConnectionManager.getInstance().getConnection().Open();
                rta = cmd.ExecuteNonQuery();
                
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
            if (rta > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
