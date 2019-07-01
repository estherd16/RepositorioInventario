using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaDatos;

namespace capaNegocio
{
    public class logicaNegocioUsuarios
    {
        accesoDatosUsuarios au = new accesoDatosUsuarios();

        public int insertarUsuarios(Usuarios us)
        {
            return au.insertarUsuarios(us);
        }

        public List<Usuarios> listarUsuarios()
        {
            return au.listarUsuarios();
        }

        public int eliminarUsuarios(int idusuario)
        {
            return au.eliminarUsuarios(idusuario);
        }

        public int EditarUsuarios(Usuarios us)
        {
            return au.EditarUsuarios(us);
        }
        public List<Usuarios> BuscarUsuarios(string dato)
        {
            return au.BuscarUsuarios(dato);
        }
    }
}
