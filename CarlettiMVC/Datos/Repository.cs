using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public abstract class Repository<TEntidad> where TEntidad : class
    {
        public static TEntidad GetById(int id)
        {
            TEntidad entidad = null;
            return entidad;
        }

        public static List<TEntidad> GetAll()
        {
            List<TEntidad> list = null;
            return list;
        }
    }
}
