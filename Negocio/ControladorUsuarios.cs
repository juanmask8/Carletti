using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;
using Utilidades;
namespace Negocio
{
    public class ControladorUsuarios
    {
        public static Boolean validarUsuarioContraseña(String user, String pass)
        {
            if (Formato.isUser(user) && Formato.isUser(pass))
            {
                if (CatalogoUsuarios.validarUsuarioContraseña(user, pass) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public static Usuario getUsuario(String user)
        {
            if (Formato.isUser(user))
            {
                return CatalogoUsuarios.getUsuario(user);
            }
            else
            {
                return null;
            }
        }

        public static List<Usuario> getAllUsuarios()
        {
            return CatalogoUsuarios.getAllUsuarios();
        }

        public static bool agregarUsuario(String user,String pass)
        {
            Usuario usu = new Usuario(user,pass);
            return CatalogoUsuarios.agregarUsuario(usu);
        }

        public static bool actualizarUsuario(int idUsuario, String user, String pass)
        {
            Usuario usu = new Usuario(idUsuario, user, pass);
            return CatalogoUsuarios.actualizarUsuario(usu);
        }

        public static bool borrarUsuario(int idUsuario, String user, String pass)
        {
            Usuario usu = new Usuario(idUsuario, user, pass);
            return CatalogoUsuarios.borrarUsuario(usu);
        }



    }
}
