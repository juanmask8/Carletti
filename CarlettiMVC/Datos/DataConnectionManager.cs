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
                con = new SqlConnection(@"Data Source=CASA-PC\sqlexpress;Initial Catalog=Carletti2;Integrated Security=True");
            }
                return con;
        }

        public static List<Libro> DataReaderToList(SqlDataReader reader)
        {
            List<Libro> libros = new List<Libro>();
            while (reader.Read())
            {
                int id = (int)reader.GetValue(0);
                String ISBN = (String)reader.GetValue(6);
                String titulo = (String)reader.GetValue(1);
                String detalle = (String)reader.GetValue(2);
                String imagen = (String)reader.GetValue(4);
                String url = (String)reader.GetValue(5);
                String copete = (String)reader.GetValue(3);
                libros.Add(new Libro(id,titulo,detalle,copete,imagen,url,ISBN));
            }
            return libros;
        }

    }



    
}
