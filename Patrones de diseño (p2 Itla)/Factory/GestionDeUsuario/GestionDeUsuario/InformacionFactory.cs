using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeUsuario
{
    public class InformacionFactory
    {
        public static IInformacion CrearInformacion(string Sinfo)
        {
            if (Sinfo == "Cliente")
                return new Cliente();
            if (Sinfo == "Empleado")
                return new Empleado();
            if (Sinfo == "Proveedore")
                return new Proveedores();
            else
                return null;
        }
    }

}   
