using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AgroAburto.Entidades;

namespace AgroAburto.Datos.DAO
{
    public class ProductoDAO
    {
        //Metodo para registrar fruta
        public void RegistrarFruta(Fruta fruta)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                MySqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    // Inserto los datos generales del producto
                    string consultaProducto = @"INSERT INTO productos
                        (codigo, nombre, descripcion, precio_compra,
                         precio_venta, stock, fecha_ingreso,
                         fecha_vencimiento, activo)
                        VALUES
                        (@codigo, @nombre, @descripcion, @precioCompra,
                         @precioVenta, @stock, @fechaIngreso,
                         @fechaVencimiento, @activo)";

                    MySqlCommand comandoProducto =
                        new MySqlCommand(consultaProducto, conexion, transaccion);

                    comandoProducto.Parameters.AddWithValue("@codigo", fruta.Codigo);
                    comandoProducto.Parameters.AddWithValue("@nombre", fruta.Nombre);
                    comandoProducto.Parameters.AddWithValue("@descripcion", fruta.Descripcion);
                    comandoProducto.Parameters.AddWithValue("@precioCompra", fruta.PrecioCompra);
                    comandoProducto.Parameters.AddWithValue("@precioVenta", fruta.PrecioVenta);
                    comandoProducto.Parameters.AddWithValue("@stock", fruta.Stock);
                    comandoProducto.Parameters.AddWithValue("@fechaIngreso", fruta.FechaIngreso);
                    comandoProducto.Parameters.AddWithValue("@fechaVencimiento",
                        fruta.FechaVencimiento.HasValue
                        ? fruta.FechaVencimiento.Value
                        : DBNull.Value);
                    comandoProducto.Parameters.AddWithValue("@activo", fruta.Activo);
                    //Ejecuta el insert
                    comandoProducto.ExecuteNonQuery();

                    //Obtener el ID del producto registrado
                    int productoId = (int)comandoProducto.LastInsertedId;

                    //Insertar las características de la fruta
                    string consultaFruta = @"INSERT INTO frutas
                        (producto_id, tipo, madurez, medida)
                        VALUES
                        (@productoId, @tipo, @madurez, @medida)";

                    MySqlCommand comandoFruta =
                        new MySqlCommand(consultaFruta, conexion, transaccion);
                    comandoFruta.Parameters.AddWithValue("@productoId", productoId);
                    comandoFruta.Parameters.AddWithValue("@tipo", fruta.Tipo);
                    comandoFruta.Parameters.AddWithValue("@madurez", fruta.Madurez);
                    comandoFruta.Parameters.AddWithValue("@medida", fruta.Medida);

                    //Ejecuta el insert
                    comandoFruta.ExecuteNonQuery();

                    //Confirmar la transaccion de los dos insert.
                    transaccion.Commit();
                }
                catch (Exception ex)
                {
                    //Devuelve todas las transacciones.
                    transaccion.Rollback();
                    throw new Exception("No se pudo registrar la fruta: " + ex.Message);
                }
            }
        }

        // Metodo para registrar hortaliza
        public void RegistrarHortaliza(Hortaliza hortaliza)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                MySqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    //Insertar los datos generales del producto
                    string consultaProducto = @"INSERT INTO productos
                        (codigo, nombre, descripcion, precio_compra,
                         precio_venta, stock, fecha_ingreso,
                         fecha_vencimiento, activo)
                        VALUES
                        (@codigo, @nombre, @descripcion, @precioCompra,
                         @precioVenta, @stock, @fechaIngreso,
                         @fechaVencimiento, @activo)";

                    MySqlCommand comandoProducto =
                        new MySqlCommand(consultaProducto, conexion, transaccion);

                    comandoProducto.Parameters.AddWithValue("@codigo", hortaliza.Codigo);
                    comandoProducto.Parameters.AddWithValue("@nombre", hortaliza.Nombre);
                    comandoProducto.Parameters.AddWithValue("@descripcion", hortaliza.Descripcion);
                    comandoProducto.Parameters.AddWithValue("@precioCompra", hortaliza.PrecioCompra);
                    comandoProducto.Parameters.AddWithValue("@precioVenta", hortaliza.PrecioVenta);
                    comandoProducto.Parameters.AddWithValue("@stock", hortaliza.Stock);
                    comandoProducto.Parameters.AddWithValue("@fechaIngreso", hortaliza.FechaIngreso);
                    comandoProducto.Parameters.AddWithValue("@fechaVencimiento",
                        hortaliza.FechaVencimiento.HasValue
                        ? hortaliza.FechaVencimiento.Value
                        : DBNull.Value);
                    comandoProducto.Parameters.AddWithValue("@activo", hortaliza.Activo);

                    //Ejecuta el insert
                    comandoProducto.ExecuteNonQuery();

                    //Obtener el ID del producto registrado
                    int productoId = (int)comandoProducto.LastInsertedId;

                    //Registrar las características de la hortaliza
                    string consultaHortaliza = @"INSERT INTO hortalizas
                        (producto_id, tipo, medida)
                        VALUES
                        (@productoId, @tipo, @medida)";

                    MySqlCommand comandoHortaliza =
                        new MySqlCommand(consultaHortaliza, conexion, transaccion);

                    comandoHortaliza.Parameters.AddWithValue("@productoId", productoId);
                    comandoHortaliza.Parameters.AddWithValue("@tipo", hortaliza.Tipo);
                    comandoHortaliza.Parameters.AddWithValue("@medida", hortaliza.Medida);

                    //Ejecuta el insert
                    comandoHortaliza.ExecuteNonQuery();

                    //Confirmar la transaccion de los dos insert.
                    transaccion.Commit();
                }
                catch (Exception ex)
                {
                    //Devuelve todas las transacciones.
                    transaccion.Rollback();
                    throw new Exception("No se pudo registrar la hortaliza: " + ex.Message);
                }
            }
        }

        //Metodo para registrar tuberculo
        public void RegistrarTuberculo(Tuberculo tuberculo)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                MySqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    //Registrar los datos generales del producto
                    string consultaProducto = @"INSERT INTO productos
                        (codigo, nombre, descripcion, precio_compra,
                         precio_venta, stock, fecha_ingreso,
                         fecha_vencimiento, activo)
                        VALUES
                        (@codigo, @nombre, @descripcion, @precioCompra,
                         @precioVenta, @stock, @fechaIngreso,
                         @fechaVencimiento, @activo)";

                    MySqlCommand comandoProducto =
                        new MySqlCommand(consultaProducto, conexion, transaccion);

                    comandoProducto.Parameters.AddWithValue("@codigo", tuberculo.Codigo);
                    comandoProducto.Parameters.AddWithValue("@nombre", tuberculo.Nombre);
                    comandoProducto.Parameters.AddWithValue("@descripcion", tuberculo.Descripcion);
                    comandoProducto.Parameters.AddWithValue("@precioCompra", tuberculo.PrecioCompra);
                    comandoProducto.Parameters.AddWithValue("@precioVenta", tuberculo.PrecioVenta);
                    comandoProducto.Parameters.AddWithValue("@stock", tuberculo.Stock);
                    comandoProducto.Parameters.AddWithValue("@fechaIngreso", tuberculo.FechaIngreso);
                    comandoProducto.Parameters.AddWithValue("@fechaVencimiento",
                        tuberculo.FechaVencimiento.HasValue
                        ? tuberculo.FechaVencimiento.Value
                        : DBNull.Value);
                    comandoProducto.Parameters.AddWithValue("@activo", tuberculo.Activo);
                    //Ejecuta el insert
                    comandoProducto.ExecuteNonQuery();

                    //Obtener el ID del producto registrado
                    int productoId = (int)comandoProducto.LastInsertedId;

                    //Registrar las características del tubérculo
                    string consultaTuberculo = @"INSERT INTO tuberculos
                        (producto_id, tipo, medida)
                        VALUES
                        (@productoId, @tipo, @medida)";

                    MySqlCommand comandoTuberculo =
                        new MySqlCommand(consultaTuberculo, conexion, transaccion);

                    comandoTuberculo.Parameters.AddWithValue("@productoId", productoId);
                    comandoTuberculo.Parameters.AddWithValue("@tipo", tuberculo.Tipo);
                    comandoTuberculo.Parameters.AddWithValue("@medida", tuberculo.Medida);

                    //Ejecuta el insert
                    comandoTuberculo.ExecuteNonQuery();

                    //Confirmar la transaccion de los dos insert.
                    transaccion.Commit();
                }
                catch (Exception ex)
                {
                    //Devuelve todas las transacciones.
                    transaccion.Rollback();
                    throw new Exception("No se pudo registrar el tubérculo: " + ex.Message);
                }
            }
        }

        //Metodo para registrar grano
        public void RegistrarGrano(Grano grano)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                MySqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    //Registrar los datos generales del producto
                    string consultaProducto = @"INSERT INTO productos
                        (codigo, nombre, descripcion, precio_compra,
                         precio_venta, stock, fecha_ingreso,
                         fecha_vencimiento, activo)
                        VALUES
                        (@codigo, @nombre, @descripcion, @precioCompra,
                         @precioVenta, @stock, @fechaIngreso,
                         @fechaVencimiento, @activo)";

                    MySqlCommand comandoProducto =
                        new MySqlCommand(consultaProducto, conexion, transaccion);

                    comandoProducto.Parameters.AddWithValue("@codigo", grano.Codigo);
                    comandoProducto.Parameters.AddWithValue("@nombre", grano.Nombre);
                    comandoProducto.Parameters.AddWithValue("@descripcion", grano.Descripcion);
                    comandoProducto.Parameters.AddWithValue("@precioCompra", grano.PrecioCompra);
                    comandoProducto.Parameters.AddWithValue("@precioVenta", grano.PrecioVenta);
                    comandoProducto.Parameters.AddWithValue("@stock", grano.Stock);
                    comandoProducto.Parameters.AddWithValue("@fechaIngreso", grano.FechaIngreso);
                    comandoProducto.Parameters.AddWithValue("@fechaVencimiento",
                        grano.FechaVencimiento.HasValue
                        ? grano.FechaVencimiento.Value
                        : DBNull.Value);
                    comandoProducto.Parameters.AddWithValue("@activo", grano.Activo);

                    //Ejecuta el insert
                    comandoProducto.ExecuteNonQuery();

                    //Obtener el ID del producto registrado
                    int productoId = (int)comandoProducto.LastInsertedId;

                    //Registrar las características del grano
                    string consultaGrano = @"INSERT INTO granos
                        (producto_id, tipo, medida)
                        VALUES
                        (@productoId, @tipo, @medida)";

                    MySqlCommand comandoGrano =
                        new MySqlCommand(consultaGrano, conexion, transaccion);

                    comandoGrano.Parameters.AddWithValue("@productoId", productoId);
                    comandoGrano.Parameters.AddWithValue("@tipo", grano.Tipo);
                    comandoGrano.Parameters.AddWithValue("@medida", grano.Medida);

                    //Ejecuta el insert
                    comandoGrano.ExecuteNonQuery();

                    //Confirmar la transaccion de los dos insert.
                    transaccion.Commit();
                }
                catch (Exception ex)
                {
                    //Devuelve todas las transacciones.
                    transaccion.Rollback();
                    throw new Exception("No se pudo registrar el grano: " + ex.Message);
                }
            }
        }

        // Metodo para listar todos los productos con sus características
        public List<Producto> ListarProductos()
        {
            List<Producto> listaProductos = new List<Producto>();

            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                //Llamo todos los productos de la BD
                string consulta = @"SELECT p.*,
                    f.tipo AS fruta_tipo,
                    f.madurez,
                    f.medida AS fruta_medida,
                    h.tipo AS hortaliza_tipo,
                    h.medida AS hortaliza_medida,
                    t.tipo AS tuberculo_tipo,
                    t.medida AS tuberculo_medida,
                    g.tipo AS grano_tipo,
                    g.medida AS grano_medida
                    FROM productos p
                    LEFT JOIN frutas f ON p.id = f.producto_id
                    LEFT JOIN hortalizas h ON p.id = h.producto_id
                    LEFT JOIN tuberculos t ON p.id = t.producto_id
                    LEFT JOIN granos g ON p.id = g.producto_id";

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        //Para hasta que read este vacio.
                        while (lector.Read())
                        {
                            int id = lector.GetInt32("id");
                            string codigo = lector.GetString("codigo");
                            string nombre = lector.GetString("nombre");
                            string descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion"))
                                ? ""
                                : lector.GetString("descripcion");
                            decimal precioCompra = lector.GetDecimal("precio_compra");
                            decimal precioVenta = lector.GetDecimal("precio_venta");
                            decimal stock = lector.GetDecimal("stock");
                            DateTime fechaIngreso = lector.GetDateTime("fecha_ingreso");
                            DateTime? fechaVencimiento =
                                lector.IsDBNull(lector.GetOrdinal("fecha_vencimiento"))
                                ? null
                                : lector.GetDateTime("fecha_vencimiento");
                            bool activo = lector.GetBoolean("activo");

                            Producto producto;
                            //Verifica que tipo de producto es y envia los paramentros especiales
                            if (!lector.IsDBNull(lector.GetOrdinal("fruta_tipo")))
                            {
                                producto = new Fruta(
                                    id, codigo, nombre, descripcion,
                                    precioCompra, precioVenta, stock,
                                    fechaIngreso, fechaVencimiento, activo,
                                    lector.GetString("fruta_tipo"),
                                    lector.GetString("madurez"),
                                    lector.GetString("fruta_medida"));
                            }
                            else if (!lector.IsDBNull(lector.GetOrdinal("hortaliza_tipo")))
                            {
                                producto = new Hortaliza(
                                    id, codigo, nombre, descripcion,
                                    precioCompra, precioVenta, stock,
                                    fechaIngreso, fechaVencimiento, activo,
                                    lector.GetString("hortaliza_tipo"),
                                    lector.GetString("hortaliza_medida"));
                            }
                            else if (!lector.IsDBNull(lector.GetOrdinal("tuberculo_tipo")))
                            {
                                producto = new Tuberculo(
                                    id, codigo, nombre, descripcion,
                                    precioCompra, precioVenta, stock,
                                    fechaIngreso, fechaVencimiento, activo,
                                    lector.GetString("tuberculo_tipo"),
                                    lector.GetString("tuberculo_medida"));
                            }
                            else if (!lector.IsDBNull(lector.GetOrdinal("grano_tipo")))
                            {
                                producto = new Grano(
                                    id, codigo, nombre, descripcion,
                                    precioCompra, precioVenta, stock,
                                    fechaIngreso, fechaVencimiento, activo,
                                    lector.GetString("grano_tipo"),
                                    lector.GetString("grano_medida"));
                            }
                            else
                            {
                                producto = new Producto(
                                    id, codigo, nombre, descripcion,
                                    precioCompra, precioVenta, stock,
                                    fechaIngreso, fechaVencimiento, activo);
                            }
                            //Llena la lista de productos
                            listaProductos.Add(producto);
                        }
                    }
                }
            }
            //Retorna la lista de productos.
            return listaProductos;
        }

        //Metodo para actualizar un producto y sus características
        public void ActualizarProducto(Producto producto)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                MySqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    // Actualizar los datos generales
                    string consulta = @"UPDATE productos SET
                        codigo = @codigo,
                        nombre = @nombre,
                        descripcion = @descripcion,
                        precio_compra = @precioCompra,
                        precio_venta = @precioVenta,
                        stock = @stock,
                        fecha_ingreso = @fechaIngreso,
                        fecha_vencimiento = @fechaVencimiento,
                        activo = @activo
                        WHERE id = @id";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion, transaccion))
                    {
                        comando.Parameters.AddWithValue("@id", producto.Id);
                        comando.Parameters.AddWithValue("@codigo", producto.Codigo);
                        comando.Parameters.AddWithValue("@nombre", producto.Nombre);
                        comando.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                        comando.Parameters.AddWithValue("@precioCompra", producto.PrecioCompra);
                        comando.Parameters.AddWithValue("@precioVenta", producto.PrecioVenta);
                        comando.Parameters.AddWithValue("@stock", producto.Stock);
                        comando.Parameters.AddWithValue("@fechaIngreso", producto.FechaIngreso);

                        comando.Parameters.AddWithValue("@fechaVencimiento",
                            producto.FechaVencimiento.HasValue
                            ? producto.FechaVencimiento.Value
                            : DBNull.Value);

                        comando.Parameters.AddWithValue("@activo", producto.Activo);

                        comando.ExecuteNonQuery();
                    }

                    // Actualizar las características de la fruta
                    if (producto is Fruta fruta)
                    {
                        string consultaFruta = @"UPDATE frutas SET
                            tipo = @tipo,
                            madurez = @madurez,
                            medida = @medida
                            WHERE producto_id = @id";

                        using (MySqlCommand comando = new MySqlCommand(consultaFruta, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue("@id", fruta.Id);
                            comando.Parameters.AddWithValue("@tipo", fruta.Tipo);
                            comando.Parameters.AddWithValue("@madurez", fruta.Madurez);
                            comando.Parameters.AddWithValue("@medida", fruta.Medida);

                            comando.ExecuteNonQuery();
                        }
                    }
                    // Actualizar las características de la hortaliza
                    else if (producto is Hortaliza hortaliza)
                    {
                        string consultaHortaliza = @"UPDATE hortalizas SET
                            tipo = @tipo,
                            medida = @medida
                            WHERE producto_id = @id";

                        using (MySqlCommand comando = new MySqlCommand(consultaHortaliza, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue("@id", hortaliza.Id);
                            comando.Parameters.AddWithValue("@tipo", hortaliza.Tipo);
                            comando.Parameters.AddWithValue("@medida", hortaliza.Medida);

                            comando.ExecuteNonQuery();
                        }
                    }
                    // Actualizar las características del tubérculo
                    else if (producto is Tuberculo tuberculo)
                    {
                        string consultaTuberculo = @"UPDATE tuberculos SET
                            tipo = @tipo,
                            medida = @medida
                            WHERE producto_id = @id";

                        using (MySqlCommand comando = new MySqlCommand(consultaTuberculo, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue("@id", tuberculo.Id);
                            comando.Parameters.AddWithValue("@tipo", tuberculo.Tipo);
                            comando.Parameters.AddWithValue("@medida", tuberculo.Medida);

                            comando.ExecuteNonQuery();
                        }
                    }
                    // Actualizar las características del grano
                    else if (producto is Grano grano)
                    {
                        string consultaGrano = @"UPDATE granos SET
                            tipo = @tipo,
                            medida = @medida
                            WHERE producto_id = @id";

                        using (MySqlCommand comando = new MySqlCommand(consultaGrano, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue("@id", grano.Id);
                            comando.Parameters.AddWithValue("@tipo", grano.Tipo);
                            comando.Parameters.AddWithValue("@medida", grano.Medida);

                            comando.ExecuteNonQuery();
                        }
                    }

                    //Confirmar todos los cambios
                    transaccion.Commit();
                }
                catch (Exception ex)
                {
                    //Devuelve todas las transacciones y envia mensaje de error.
                    transaccion.Rollback();
                    throw new Exception("No se pudo actualizar el producto: " + ex.Message);
                }
            }
        }

        // Metodo para desactivar un producto
        public void DesactivarProducto(int id)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                //Actualizo en tabla productos el parametro activo a 0.
                string consulta = @"UPDATE productos
                                    SET activo = 0
                                    WHERE id = @id";

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    //Ejecuto el update
                    comando.ExecuteNonQuery();
                }
            }
        }

        //Metodo para buscar productos por codigo, nombre, tipo, estado y categoria.
        public List<Producto> BuscarProducto(string busqueda, bool? estado, string? categoria)
        {
            List<Producto> listaProductos = new List<Producto>();

            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                // Consulta de productos y características de las clases hijas.
                string consulta = @"SELECT p.*,
                    f.tipo AS fruta_tipo,
                    f.madurez,
                    f.medida AS fruta_medida,
                    h.tipo AS hortaliza_tipo,
                    h.medida AS hortaliza_medida,
                    t.tipo AS tuberculo_tipo,
                    t.medida AS tuberculo_medida,
                    g.tipo AS grano_tipo,
                    g.medida AS grano_medida
                    FROM productos p
                    LEFT JOIN frutas f ON p.id = f.producto_id
                    LEFT JOIN hortalizas h ON p.id = h.producto_id
                    LEFT JOIN tuberculos t ON p.id = t.producto_id
                    LEFT JOIN granos g ON p.id = g.producto_id
                    WHERE (
                    p.codigo LIKE @busqueda
                    OR p.nombre LIKE @busqueda
                    OR p.descripcion LIKE @busqueda
                    OR f.tipo LIKE @busqueda
                    OR h.tipo LIKE @busqueda
                    OR t.tipo LIKE @busqueda
                    OR g.tipo LIKE @busqueda
                    )
                    AND (@estado IS NULL OR p.activo = @estado)
                    AND (
                    @categoria IS NULL
                    OR (@categoria = 'Fruta' AND f.producto_id IS NOT NULL)
                    OR (@categoria = 'Hortaliza' AND h.producto_id IS NOT NULL)
                    OR (@categoria = 'Tuberculo' AND t.producto_id IS NOT NULL)
                    OR (@categoria = 'Grano' AND g.producto_id IS NOT NULL)
                )";

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");

                    comando.Parameters.AddWithValue("@estado",
                        estado.HasValue ? (object)estado.Value : DBNull.Value);

                    comando.Parameters.AddWithValue("@categoria",
                        string.IsNullOrWhiteSpace(categoria)
                        ? (object)DBNull.Value
                        : categoria);

                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            int id = lector.GetInt32("id");
                            string codigo = lector.GetString("codigo");
                            string nombre = lector.GetString("nombre");

                            string descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion"))
                                ? ""
                                : lector.GetString("descripcion");

                            decimal precioCompra = lector.GetDecimal("precio_compra");
                            decimal precioVenta = lector.GetDecimal("precio_venta");
                            decimal stock = lector.GetDecimal("stock");

                            DateTime fechaIngreso = lector.GetDateTime("fecha_ingreso");

                            DateTime? fechaVencimiento =
                                lector.IsDBNull(lector.GetOrdinal("fecha_vencimiento"))
                                ? null
                                : lector.GetDateTime("fecha_vencimiento");

                            bool activo = lector.GetBoolean("activo");

                            //Identifica la categoria y crear el objeto correspondiente.
                            Producto producto;

                            if (!lector.IsDBNull(lector.GetOrdinal("fruta_tipo")))
                            {
                                producto = new Fruta(
                                    id, codigo, nombre, descripcion,
                                    precioCompra, precioVenta, stock,
                                    fechaIngreso, fechaVencimiento, activo,
                                    lector.GetString("fruta_tipo"),
                                    lector.GetString("madurez"),
                                    lector.GetString("fruta_medida"));
                            }
                            else if (!lector.IsDBNull(lector.GetOrdinal("hortaliza_tipo")))
                            {
                                producto = new Hortaliza(
                                    id, codigo, nombre, descripcion,
                                    precioCompra, precioVenta, stock,
                                    fechaIngreso, fechaVencimiento, activo,
                                    lector.GetString("hortaliza_tipo"),
                                    lector.GetString("hortaliza_medida"));
                            }
                            else if (!lector.IsDBNull(lector.GetOrdinal("tuberculo_tipo")))
                            {
                                producto = new Tuberculo(
                                    id, codigo, nombre, descripcion,
                                    precioCompra, precioVenta, stock,
                                    fechaIngreso, fechaVencimiento, activo,
                                    lector.GetString("tuberculo_tipo"),
                                    lector.GetString("tuberculo_medida"));
                            }
                            else if (!lector.IsDBNull(lector.GetOrdinal("grano_tipo")))
                            {
                                producto = new Grano(
                                    id, codigo, nombre, descripcion,
                                    precioCompra, precioVenta, stock,
                                    fechaIngreso, fechaVencimiento, activo,
                                    lector.GetString("grano_tipo"),
                                    lector.GetString("grano_medida"));
                            }
                            else
                            {
                                producto = new Producto(
                                    id, codigo, nombre, descripcion,
                                    precioCompra, precioVenta, stock,
                                    fechaIngreso, fechaVencimiento, activo);
                            }   
                            //Agregar producto a la lista.
                            listaProductos.Add(producto);
                        }
                    }
                }
            }
            return listaProductos;
        }

    }
}
