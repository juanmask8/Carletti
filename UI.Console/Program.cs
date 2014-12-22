using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;

namespace UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(Libro libro in Datos.CatalogoLibros.getAllLibros())
            {
                System.Console.WriteLine(libro.titulo);
            }
            System.Console.Read();
        }
    }
}
