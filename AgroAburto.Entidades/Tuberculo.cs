using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroAburto.Entidades
{
    public class Tuberculo : Producto
    {
        // Propiedades de Tuberculo

        public string Tipo { get; set; }
        public string Medida { get; set; }

        // Constructor de tuberculo
        public Tuberculo(
            int id,
            string codigo,
            string nombre,
            string descripcion,
            decimal precioCompra,
            decimal precioVenta,
            decimal stock,
            DateTime fechaIngreso,
            DateTime? fechaVencimiento,
            bool activo,
            string tipo,
            string medida)
            : base(
                id,
                codigo,
                nombre,
                descripcion,
                precioCompra,
                precioVenta,
                stock,
                fechaIngreso,
                fechaVencimiento,
                activo)
        {
            Tipo = tipo;
            Medida = medida;
        }
    }
}
