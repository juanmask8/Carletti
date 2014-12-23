using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Entidades;
using System.Data;

namespace Datos
{
    public class CatalogoUsuarios
    {
        public static Usuario validarUsuarioContraseña(String user, String pass)
        {
            Usuario usuario = null;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM USUARIOS WHERE usuario = @USUARIO AND contraseña = @CONTRASEÑA", DataConnectionManager.getInstance().getConnection());
                cmd.Parameters.Add("@USUARIO", SqlDbType.VarChar);
                cmd.Parameters["@USUARIO"].Value = user;
                cmd.Parameters.Add("@CONTRASEÑA", SqlDbType.VarChar);
                cmd.Parameters["@CONTRASEÑA"].Value = pass;
                DataConnectionManager.getInstance().getConnection().Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = (int)dr.GetValue(0);
                    String us = (String)dr.GetValue(1);
                    String pas = (String)dr.GetValue(2);
                    usuario = new Usuario(id, us, pas);
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

            return usuario;
        }

        public static Usuario getUsuario(String user)
        {
            Usuario usuario = null;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM USUARIOS WHERE usuario = @USUARIO", DataConnectionManager.getInstance().getConnection());
                cmd.Parameters.Add("@USUARIO", SqlDbType.VarChar);
                cmd.Parameters["@USUARIO"].Value = user;                
                DataConnectionManager.getInstance().getConnection().Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = (int)dr.GetValue(0);
                    String us = (String)dr.GetValue(1);
                    String pas = (String)dr.GetValue(2);
                    usuario = new Usuario(id, us, pas);
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

            return usuario;
        }

        public static List<Usuario> getAllUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM USUARIOS", DataConnectionManager.getInstance().getConnection());
                DataConnectionManager.getInstance().getConnection().Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = (int)dr.GetValue(0);
                    String us = (String)dr.GetValue(1);
                    String pas = (String)dr.GetValue(2);
                    Usuario usuario = new Usuario(id, us, pas);
                    usuarios.Add(usuario);
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

            return usuarios;

        }

        public static bool agregarUsuario(Usuario usuario)
        {
            int rta = -1;
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios (usuario,contraseña) VALUES(@usuario,@contraseña)", DataConnectionManager.getInstance().getConnection());
                cmd.Parameters.Add("@usuraio", SqlDbType.VarChar);
                cmd.Parameters["@usuraio"].Value = usuario.usuraio;
                cmd.Parameters.Add("@contraseña", SqlDbType.VarChar);
                cmd.Parameters["@contraseña"].Value = usuario.contraseña;
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

        public static bool borrarUsuario(Usuario usuario)
        {
            int rta = -1;
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Usuarios WHERE idUsuario = @idUsuario)", DataConnectionManager.getInstance().getConnection());
                cmd.Parameters.Add("@idUsuario", SqlDbType.VarChar);
                cmd.Parameters["@idUsuario"].Value = usuario.idUsuario; 
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
            
        public static bool actualizarUsuario(Usuario usuario)
        {
            int rta = -1;
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Usuarios usuario=@usuario,contraseña=@contraseña WHERE idUsuario = @idUsuario)", DataConnectionManager.getInstance().getConnection());
                cmd.Parameters.Add("@usuraio", SqlDbType.VarChar);
                cmd.Parameters["@usuraio"].Value = usuario.usuraio;
                cmd.Parameters.Add("@contraseña", SqlDbType.VarChar);
                cmd.Parameters["@contraseña"].Value = usuario.contraseña;
                cmd.Parameters.Add("@idUsuario", SqlDbType.VarChar);
                cmd.Parameters["@idUsuario"].Value = usuario.idUsuario;
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
