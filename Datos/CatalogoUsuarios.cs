using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Entidades;
using System.Data;

namespace Datos
{
    class CatalogoUsuarios
    {
        public static Usuario validarUsuarioContraseña(String user, String pass)
        {
            Usuario usuario = null;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM LIBROS WHERE USUARIO = @USUARIO AND CONTRASEÑA = @CONTRASEÑA", DataConnectionManager.getInstance().getConnection());
                cmd.Parameters.Add("@USUARIO", SqlDbType.VarChar);
                cmd.Parameters["@USUARIO"].Value = user;
                cmd.Parameters.Add("@CONTRASEÑA", SqlDbType.VarChar);
                cmd.Parameters["@CONTRASEÑA"].Value = pass;
                DataConnectionManager.getInstance().getConnection().Open();
                SqlDataReader dr = cmd.ExecuteReader();
                int id = (int)dr.GetValue(0);
                String us = (String)dr.GetValue(1);
                String pas = (String)dr.GetValue(2);
                usuario.idUsuario = id;
                usuario.usuraio = us;
                usuario.constraseña = pas;
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

            return usuario;
        }
    }
}
