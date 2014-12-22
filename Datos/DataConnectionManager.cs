using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class DataConnectionManager
    {
        private static DataConnectionManager instancia;
        private SqlConnection con;
        private DataConnectionManager() { }


        public static DataConnectionManager getInstance()
        {
            if (instancia == null)
            {
                instancia = new DataConnectionManager();
            }
            return instancia;   
        }

        public SqlConnection getConnection()
        {
            if (con == null)
            {
                con = new SqlConnection(@"Data Source=CASA-PC\SQLEXPRESS;Initial Catalog=Carletti;Integrated Security=True");
            }
                return con;
        }

        public static List<Libro> DataReaderToList(SqlDataReader reader)
        {
            List<Libro> libros = new List<Libro>();
            while (reader.Read())
            {
                int id = (int)reader.GetValue(0);
                int ISBN = (int)reader.GetValue(1);
                String titulo = (String)reader.GetValue(2);
                String detalle = (String)reader.GetValue(3);
                String imagen = (String)reader.GetValue(4);
                String url = (String)reader.GetValue(5);
                libros.Add(new Libro(id,titulo,imagen,detalle,url,ISBN));
            }
            return libros;
        }

    }



    
}
