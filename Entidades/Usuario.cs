using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public String usuraio { get; set; }
        public String contraseña { get; set; }

        public Usuario() { }

        public Usuario(int idUsuario, String usuraio, String constraseña)
        {
            this.idUsuario = idUsuario;
            this.usuraio = usuraio;
            this.contraseña = constraseña;
        }

        public Usuario(String usuraio, String constraseña)
        {
            this.usuraio = usuraio;
            this.contraseña = constraseña;
        }
    }
}
