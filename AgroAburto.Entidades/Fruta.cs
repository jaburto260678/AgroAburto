using AgroAburto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Fruta : Producto
{
    //Propiedades de fruta
    public string Tipo { get; set; }
    public string Madurez { get; set; }
    public string Medida { get; set; }

    //Constructor de fruta
    public Fruta(
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
        string madurez,
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
        Madurez = madurez;
        Medida = medida;
    }
}
