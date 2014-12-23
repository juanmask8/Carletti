﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Libro
    {
        public int idLibro {get;set;}
        public String titulo { get; set; }
        public String imagen { get; set; }
        public String detalle { get; set; }
        public String url { get; set; }
        public String ISBN { get; set; }

        public Libro() { }

        public Libro(int idLibro, String titulo, String imagen, String detalle, String url, String ISBN)
        {
            this.idLibro = idLibro;
            this.titulo = titulo;
            this.imagen = imagen;
            this.detalle = detalle;
            this.url = url;
            this.ISBN = ISBN;
        }

        public Libro(String titulo, String imagen, String detalle, String url, String ISBN)
        {
            this.titulo = titulo;
            this.imagen = imagen;
            this.detalle = detalle;
            this.url = url;
            this.ISBN = ISBN;
        }

    }
}
