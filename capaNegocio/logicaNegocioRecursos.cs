using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaDatos;

namespace capaNegocio
{
    public class logicaNegocioRecursos
    {
        accesoDatosRecursos ar = new accesoDatosRecursos();

        public int insertarRecursos(recursos rec)
        {
            return ar.insertarRecursos(rec);
        }

        public List<recursos> listarRecursos()
        {
            return ar.listarRecursos();
        }

        public int eliminarRecursos(int idrecursos)
        {
            return ar.eliminarRecursos(idrecursos);
        }

        public int EditarRecursos(recursos rec)
        {
            return ar.EditarRecursos(rec);
        }
        public List<recursos> BuscarRecursos(string dato)
        {
            return ar.BuscarRecursos(dato);
        }
    }
}
