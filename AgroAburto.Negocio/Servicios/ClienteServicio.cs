
using System.Collections.Generic;
using AgroAburto.Datos.DAO;
using AgroAburto.Entidades;

namespace AgroAburto.Negocio.Servicios
{
    public class ClienteServicio
    {
        //Instancia del DAO de clientes
        private ClienteDAO clienteDAO = new ClienteDAO();

        //Metodo para llamar registrar cliente
        public void RegistrarCliente(Cliente cliente)
        {
            clienteDAO.RegistrarCliente(cliente);
        }

        //Metodo para llamar listar clientes
        public List<Cliente> ListarClientes()
        {
            return clienteDAO.ListarClientes();
        }

        //Metodo para llamar actualizar cliente
        public void ActualizarCliente(Cliente cliente)
        {
            clienteDAO.ActualizarCliente(cliente);
        }

        //Metodos para llamar desactivar cliente
        public void DesactivarCliente(int id)
        {
            clienteDAO.DesactivarCliente(id);
        }
    }
}

