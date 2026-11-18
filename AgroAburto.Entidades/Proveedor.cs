using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroAburto.Entidades
{
    public class Proveedor : Persona
    {
        // Propiedades de proveedor
        public string TipoProducto { get; set; }
        public string CedulaJuridica { get; set; }

        // Constructor de proveedor
        public Proveedor(
            int id,
            string nombre,
            string apellidos,
            string telefono,
            string correo,
            string direccion,
            DateTime fechaIngreso,
            bool activo,
            string tipoProducto,
            string cedulaJuridica)
            : base(
                id,
                nombre,
                apellidos,
                telefono,
                correo,
                direccion,
                fechaIngreso,
                activo)
        {
            TipoProducto = tipoProducto;
            CedulaJuridica = cedulaJuridica;
        }
    }
}
