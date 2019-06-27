using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaDatos;

namespace capaNegocio
{
    class logicaNegocioCuentas
    {
        accesoDatosCuentas acu = new accesoDatosCuentas();

        public int insertarCuentas(Cuentas cu)
        {
            return acu.insertarCuentas(cu);
        }

        public List<Cuentas> listarCuentas()
        {
            return acu.listarCuentas();
        }

        public int eliminarCuentas(int idcuenta)
        {
            return acu.eliminarCuentas(idcuenta); 
        }

        public int EditarCuentas(Cuentas cu)
        {
            return acu.EditarCuentas(cu); 
        }
        public List<Cuentas> BuscarCuentas(string dato)
        {
            return acu.BuscarCuentas(dato);
        }
    }
}
