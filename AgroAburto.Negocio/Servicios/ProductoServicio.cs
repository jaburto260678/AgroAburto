using AgroAburto.Datos.DAO;
using AgroAburto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroAburto.Negocio.Servicios
{
    public class ProductoServicio
    {
        //Instancia del DAO de productos
        private ProductoDAO productoDAO = new ProductoDAO();

        //Metodo para llamar registrar fruta
        public void RegistrarFruta(Fruta fruta)
        {
            productoDAO.RegistrarFruta(fruta);
        }

        //Metodo para llamar registrar hortaliza
        public void RegistrarHortaliza(Hortaliza hortaliza)
        {
            productoDAO.RegistrarHortaliza(hortaliza);
        }

        //Metodo para llamar registrar tubérculo
        public void RegistrarTuberculo(Tuberculo tuberculo)
        {
            productoDAO.RegistrarTuberculo(tuberculo);
        }

        //Metodo para llamar registrar grano
        public void RegistrarGrano(Grano grano)
        {
            productoDAO.RegistrarGrano(grano);
        }

        //Metodo para llamar listar productos
        public List<Producto> ListarProductos()
        {
            return productoDAO.ListarProductos();
        }

        //Metodo para llamar actualizar producto
        public void ActualizarProducto(Producto producto)
        {
            productoDAO.ActualizarProducto(producto);
        }

        //Metodo para llamar desactivar producto
        public void DesactivarProducto(int id)
        {
            productoDAO.DesactivarProducto(id);
        }

        //Metodo para llamar buscar productos
        public List<Producto> BuscarProducto(string busqueda, bool? estado, string? categoria)
        {
            return productoDAO.BuscarProducto(busqueda, estado, categoria);
        }
    }
}
