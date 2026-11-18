using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroAburto.Entidades
{
    public class Producto
    {
        //Propiedades de la clase padre

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Stock { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public bool Activo { get; set; }

        //Constructor de padre
        public Producto(
            int id, 
            string codigo, 
            string nombre, 
            string descripcion,
            decimal precioCompra,
            decimal precioVenta,
            decimal stock,
            DateTime fechaIngreso,
            DateTime? fechaVencimiento,
            bool activo)
        {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            Stock = stock;
            FechaIngreso = fechaIngreso;
            FechaVencimiento = fechaVencimiento;
            Activo = activo;
        }
    }
}
