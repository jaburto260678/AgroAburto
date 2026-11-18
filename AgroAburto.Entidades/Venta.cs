using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroAburto.Entidades
{
    public class Venta
    {
        // Propiedades de venta
        public int Id { get; set; }
        public string NumeroVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public Cliente Cliente { get; set; }
        public decimal Subtotal { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }

        // Constructor de venta
        public Venta(
            int id,
            string numeroVenta,
            DateTime fechaVenta,
            Cliente cliente,
            decimal subtotal,
            decimal iva,
            decimal total,
            string estado)
        {
            Id = id;
            NumeroVenta = numeroVenta;
            FechaVenta = fechaVenta;
            Cliente = cliente;
            Subtotal = subtotal;
            IVA = iva;
            Total = total;
            Estado = estado;
        }
    }
}
