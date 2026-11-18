using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroAburto.Entidades
{
    public class DetalleVentas
    {
        // Propiedades de detalle ventas
        public int Id { get; set; }
        public int VentaId { get; set; }
        public Producto Producto { get; set; } //Trae propiedades de producto
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }

        // Constructor de detalle ventas
        public DetalleVentas(
            int id,
            int ventaId,
            Producto producto,
            decimal cantidad,
            decimal precioUnitario,
            decimal subtotal)
        {
            Id = id;
            VentaId = ventaId;
            Producto = producto;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Subtotal = subtotal;
        }
    }
}
