using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroAburto.Entidades
{
    public class Usuario : Persona
    {
        // Propiedades de usuario
        public string Rol { get; set; }

        // Constructor de usuario
        public Usuario(
            int id,
            string nombre,
            string apellidos,
            string telefono,
            string correo,
            string direccion,
            DateTime fechaIngreso,
            bool activo,
            string rol)
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
            Rol = rol;
        }
    }
}
