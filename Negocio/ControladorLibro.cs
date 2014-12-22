using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;
namespace Negocio
{
    public class ControladorLibro
    {
        public static List<Libro> getAllLibros()
        {
            return CatalogoLibros.getAllLibros();
        }
    }
}
