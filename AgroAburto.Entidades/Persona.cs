using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroAburto.Entidades
{
    public class Persona
    {
        //Propiedades de la clase padre
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Activo { get; set; }

        //Constructor de padre
        public Persona(
            int id,
            string nombre,
            string apellidos,
            string telefono,
            string correo,
            string direccion,
            DateTime fechaIngreso,
            bool activo)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
            FechaIngreso = fechaIngreso;
            Activo = activo;
        }
    }
}
