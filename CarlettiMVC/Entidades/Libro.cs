using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public String Titulo { get; set; }
        public String Detalle { get; set; }
        public String Copete { get; set; }
        public String LinkImagen { get; set; }
        public String LinkLibro { get; set; }
        public String ISBN { get; set; }
        public Libro(){}

        public Libro(int IdLibro, String Titulo, String Detalle, String Copete, String LinkImagen, String LinkLibro, String ISBN)
        {
            this.IdLibro = IdLibro;
            this.Titulo = Titulo;
            this.Detalle = Detalle;
            this.Copete = Copete;
            this.LinkImagen = LinkImagen;
            this.LinkLibro = LinkLibro;
            this.ISBN = ISBN;
        }

        public Libro(String Titulo, String Detalle, String Copete, String LinkImagen, String LinkLibro, String ISBN)
        {
            this.Titulo = Titulo;
            this.Detalle = Detalle;
            this.Copete = Copete;
            this.LinkImagen = LinkImagen;
            this.LinkLibro = LinkLibro;
            this.ISBN = ISBN;
        }

    }
}
