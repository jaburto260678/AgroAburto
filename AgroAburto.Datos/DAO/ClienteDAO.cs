
using System;
using MySql.Data.MySqlClient;
using AgroAburto.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace AgroAburto.Datos.DAO
{
    public class ClienteDAO
    {
        //Metodo para registra un cliente
        public void RegistrarCliente(Cliente cliente)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                MySqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    //Registra los datos generales de la persona
                    string consultaPersona = @"INSERT INTO personas
                        (nombre, apellidos, telefono, correo,
                         direccion, fecha_ingreso, activo)
                        VALUES
                        (@nombre, @apellidos, @telefono, @correo,
                         @direccion, @fechaIngreso, @activo)";

                    MySqlCommand comandoPersona =
                        new MySqlCommand(consultaPersona, conexion, transaccion);

                    comandoPersona.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    comandoPersona.Parameters.AddWithValue("@apellidos", cliente.Apellidos);
                    comandoPersona.Parameters.AddWithValue("@telefono", cliente.Telefono);
                    comandoPersona.Parameters.AddWithValue("@correo",
                        string.IsNullOrWhiteSpace(cliente.Correo)
                        ? (object)DBNull.Value : cliente.Correo);
                    comandoPersona.Parameters.AddWithValue("@direccion",
                        string.IsNullOrWhiteSpace(cliente.Direccion)
                        ? (object)DBNull.Value : cliente.Direccion);
                    comandoPersona.Parameters.AddWithValue("@fechaIngreso", cliente.FechaIngreso);
                    comandoPersona.Parameters.AddWithValue("@activo", cliente.Activo);

                    comandoPersona.ExecuteNonQuery();

                    //Obtiene el ID generado en personas
                    int personaId = (int)comandoPersona.LastInsertedId;

                    //Registra los datos específicos del cliente
                    string consultaCliente = @"INSERT INTO clientes
                        (persona_id, tipo, cedula)
                        VALUES
                        (@personaId, @tipo, @cedula)";

                    MySqlCommand comandoCliente =
                        new MySqlCommand(consultaCliente, conexion, transaccion);

                    comandoCliente.Parameters.AddWithValue("@personaId", personaId);
                    comandoCliente.Parameters.AddWithValue("@tipo", cliente.Tipo);
                    comandoCliente.Parameters.AddWithValue("@cedula", cliente.Cedula);

                    comandoCliente.ExecuteNonQuery();

                    //Confirmar ambas inserciones
                    transaccion.Commit();
                }
                catch (Exception ex)
                {
                    //Error si se puede registrra cliente
                    transaccion.Rollback();
                    throw new Exception(
                        "No se pudo registrar el cliente: " + ex.Message);
                }
            }
        }

        //Metodo para listar de todos los clientes
        public List<Cliente> ListarClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string consulta = @"SELECT
            p.id,
            p.nombre,
            p.apellidos,
            p.telefono,
            p.correo,
            p.direccion,
            p.fecha_ingreso,
            p.activo,
            c.tipo,
            c.cedula
            FROM personas p
            INNER JOIN clientes c ON p.id = c.persona_id";

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Cliente cliente = new Cliente(
                                lector.GetInt32("id"),
                                lector.GetString("nombre"),
                                lector.GetString("apellidos"),
                                lector.GetString("telefono"),
                                lector.IsDBNull(lector.GetOrdinal("correo"))
                                    ? ""
                                    : lector.GetString("correo"),
                                lector.IsDBNull(lector.GetOrdinal("direccion"))
                                    ? ""
                                    : lector.GetString("direccion"),
                                lector.GetDateTime("fecha_ingreso"),
                                lector.GetBoolean("activo"),
                                lector.GetString("tipo"),
                                lector.GetString("cedula")
                            );

                            listaClientes.Add(cliente);
                        }
                    }
                }
            }
            //Retorna la lista de clientes
            return listaClientes;
        }

        //Metodo para actualizacion de un cliente
        public void ActualizarCliente(Cliente cliente)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                MySqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    //Actualiza los datos personales
                    string consultaPersona = @"UPDATE personas SET
                nombre = @nombre,
                apellidos = @apellidos,
                telefono = @telefono,
                correo = @correo,
                direccion = @direccion,
                activo = @activo
                WHERE id = @id";

                    using (MySqlCommand comando = new MySqlCommand(
                        consultaPersona, conexion, transaccion))
                    {
                        comando.Parameters.AddWithValue("@id", cliente.Id);
                        comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                        comando.Parameters.AddWithValue("@apellidos", cliente.Apellidos);
                        comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
                        comando.Parameters.AddWithValue("@correo",
                            string.IsNullOrWhiteSpace(cliente.Correo)
                            ? (object)DBNull.Value : cliente.Correo);
                        comando.Parameters.AddWithValue("@direccion",
                            string.IsNullOrWhiteSpace(cliente.Direccion)
                            ? (object)DBNull.Value : cliente.Direccion);
                        comando.Parameters.AddWithValue("@activo", cliente.Activo);

                        comando.ExecuteNonQuery();
                    }

                    //Actualiza los datos específicos del cliente
                    string consultaCliente = @"UPDATE clientes SET
                tipo = @tipo,
                cedula = @cedula
                WHERE persona_id = @id";

                    using (MySqlCommand comando = new MySqlCommand(
                        consultaCliente, conexion, transaccion))
                    {
                        comando.Parameters.AddWithValue("@id", cliente.Id);
                        comando.Parameters.AddWithValue("@tipo", cliente.Tipo);
                        comando.Parameters.AddWithValue("@cedula", cliente.Cedula);

                        comando.ExecuteNonQuery();
                    }

                    //Confirmacion los cambios
                    transaccion.Commit();
                }
                catch (Exception ex)
                {
                    //Mensaje si hay error al actualizar cliente
                    transaccion.Rollback();
                    throw new Exception(
                        "No se pudo actualizar el cliente: " + ex.Message);
                }
            }
        }

        //Metodo para desactivar un cliente
        public void DesactivarCliente(int id)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string consulta = @"UPDATE personas
                            SET activo = 0
                            WHERE id = @id";

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    comando.ExecuteNonQuery();
                }
            }
        }

    }
}

