using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaDatos;

namespace capaNegocio
{
    public class logicaNegocioSolicitud
    {
        accesoDatosSolicitud aso = new accesoDatosSolicitud();

        public int insertarSolicitud(Solicitud so)
        {
            return aso.insertarSolicitud(so);
        }

        public List<Solicitud> listarSolicitud()
        {
            return aso.listarSolicitud();
        }

        public int eliminarSolicitud(int idsolicitud)
        {
            return aso.eliminarSolicitud(idsolicitud);
        }

        public int EditarSolicitud(Solicitud so)
        {
            return aso.EditarSolicitud(so);
        }
        public List<Solicitud> BuscarSolicitud(string dato)
        {
            return aso.BuscarSolicitud(dato);
        }
    }
}
