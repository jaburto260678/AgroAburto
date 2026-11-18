using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroAburto.Entidades
{
    public class Cliente : Persona
    {
        // Propiedades de cliente
        public string Tipo { get; set; }
        public string Cedula { get; set; }

        // Constructor de la cliente
        public Cliente(
            int id,
            string nombre,
            string apellidos,
            string telefono,
            string correo,
            string direccion,
            DateTime fechaIngreso,
            bool activo,
            string tipo,
            string cedula)
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
            Tipo = tipo;
            Cedula = cedula;
        }
    }
}
