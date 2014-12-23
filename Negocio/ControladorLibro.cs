using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;
using Utilidades;
using System.IO;
namespace Negocio
{
    public class ControladorLibro
    {
        public static List<Libro> getAllLibros()
        {
            return CatalogoLibros.getAllLibros();
        }

        public static bool agregarLibro(String titulo, String imagen, String detalle, String url, String ISBN)
        {
            if (titulo != null)
            {
                
                Libro libro = new Libro(titulo, imagen, detalle, url, ISBN);
                return CatalogoLibros.agregarLibro(libro);
            }
            else
            {
                return false;
            }
            
        }
    }
}
