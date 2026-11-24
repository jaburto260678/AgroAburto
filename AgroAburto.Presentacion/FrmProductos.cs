using AgroAburto.Entidades;
using AgroAburto.Negocio.Servicios;
using System;
using System.Linq;
using System.Windows.Forms;


namespace AgroAburto.Presentacion
{
    public partial class FrmProductos : Form
    {
        //Crear instancia del servicio de productos
        private ProductoServicio productoServicio = new ProductoServicio();
        //Variable para guardar el ID del producto seleccionado para modificar o eliminar
        private int idProductoSeleccionado = 0;
        //Constructor
        public FrmProductos()
        {
            InitializeComponent();

            //Leer textbox de busqueda
            Utilidades.ConfigurarBusqueda(txtBuscar, texto => BuscarProductos(texto));

            //Configuracion de diseño y centrar DataGridView
            Utilidades.ConfigurarDataGridView(dgvProductos, this);

            //Caracteristicas de buscar
            Utilidades.ConfigurarBusqueda(btnBuscar, txtBuscar, this);

            //Aplicar centrado a DataGrid
            this.Resize += (s, e) =>
            {
                Utilidades.ConfigurarDataGridView(dgvProductos, this);
            };

            //Aplicar centrado de titulo
            pnlEncabezado.Resize += (s, e) => Utilidades.CentrarTitulo(lblTitulo, pnlEncabezado);
            Utilidades.CentrarTitulo(lblTitulo, pnlEncabezado);

            //Aplicar centrado a GroupBox al cambiar de tamaño
            this.Resize += (s, e) =>
            {
                Utilidades.CentrarGroupBox(gbProducto, this);
                Utilidades.CentrarGroupBox(gbCaracteristicas, this);
                Utilidades.ConfigurarBusqueda(btnBuscar, txtBuscar, this);
            };

            //Aplicar caracterisiticas a los botones al cambiar de tamaño 
            this.Resize += (s, e) =>
            {
                Utilidades.ConfigurarBotones(this,
                    btnGuardar,
                    btnModificar,
                    btnEliminar,
                    btnLimpiar,
                    btnVolver
                    );
            };

            //Aplicar centrar a GroupBox al iniciar
            Utilidades.CentrarGroupBox(gbProducto, this);
            Utilidades.CentrarGroupBox(gbCaracteristicas, this);

            //Aplicar caracterisiticas a los botones al iniciar
            Utilidades.ConfigurarBotones(this,
                btnGuardar,
                btnModificar,
                btnEliminar,
                btnLimpiar,
                btnVolver);

            //Opciones carateristicas al cmbcategoria
            cmbCategoria.Items.Add("Fruta");
            cmbCategoria.Items.Add("Hortaliza");
            cmbCategoria.Items.Add("Tuberculo");
            cmbCategoria.Items.Add("Grano");
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;

            //Opciones de madurez
            cmbMadurez.Items.Add("Verde");
            cmbMadurez.Items.Add("Medio");
            cmbMadurez.Items.Add("Maduro");
            cmbMadurez.DropDownStyle = ComboBoxStyle.DropDownList;

            //cmb de medidas 
            //Carga características de la categoria al iniciar
            cmbMedida.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            cmbCategoria_SelectedIndexChanged(null, EventArgs.Empty);

            //Fecha de vencimiento opcional
            dtpFechaVencimiento.Visible = false;
            chkTieneVencimiento.CheckedChanged += chkTieneVencimiento_CheckedChanged;

            //Evitar fechas de ingreso posteriores al día actual
            dtpFechaIngreso.MaxDate = DateTime.Today;
            dtpFechaIngreso.ValueChanged += dtpFechaIngreso_ValueChanged;

            // Configurar filtro de productos activos e inactivos.
            Utilidades.ConfigurarFiltroEstado(chkEstado,
                mostrarInactivos => BuscarProductos(txtBuscar.Text.Trim(), mostrarInactivos));

            //Posicion de boton check
            Utilidades.AlinearControlDerechaEnLinea(chkEstado, txtBuscar, 240);
        }

        //Accion de ocultar o mostrar las caracteristicas unicas de las hijas.
        private void cmbCategoria_SelectedIndexChanged(object? sender, EventArgs e)
        {
            bool esFruta = cmbCategoria.Text == "Fruta";

            Utilidades.MostrarControl(lblMadurez, esFruta);
            Utilidades.MostrarControl(cmbMadurez, esFruta);
            cmbMedida.Items.Clear();

            switch (cmbCategoria.Text)
            {
                case "Fruta":
                    cmbMedida.Items.AddRange(new object[]
                    {
                "Kilogramo", "Unidad", "Caja"
                    });
                    break;

                case "Hortaliza":
                    cmbMedida.Items.AddRange(new object[]
                    {
                "Kilogramo", "Ramo"
                    });
                    break;

                case "Tuberculo":
                    cmbMedida.Items.AddRange(new object[]
                    {
                "Kilogramo", "Caja", "Saco"
                    });
                    break;

                case "Grano":
                    cmbMedida.Items.AddRange(new object[]
                    {
                "Kilogramo", "Saco"
                    });
                    break;
            }
            cmbMedida.SelectedIndex = -1;
        }

        //Mostrar u ocultar fecha de vencimiento
        private void chkTieneVencimiento_CheckedChanged(object? sender, EventArgs e)
        {
            dtpFechaVencimiento.Visible = chkTieneVencimiento.Checked;

            if (chkTieneVencimiento.Checked)
            {
                dtpFechaVencimiento.MinDate = dtpFechaIngreso.Value.Date;

                if (dtpFechaVencimiento.Value.Date < dtpFechaIngreso.Value.Date)
                {
                    dtpFechaVencimiento.Value = dtpFechaIngreso.Value.Date;
                }
            }
        }

        // Actualizacion fecha mínima de vencimiento cuando se da check en vencimiento
        private void dtpFechaIngreso_ValueChanged(object? sender, EventArgs e)
        {
            if (dtpFechaIngreso.Value.Date <= dtpFechaVencimiento.MaxDate.Date)
            {
                dtpFechaVencimiento.MinDate = dtpFechaIngreso.Value.Date;
            }
        }

        //Acciones de botones
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Utilidades.VolverAlMenu(this);
        }

        //Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos
            Utilidades.LimpiarControles(gbProducto);
            Utilidades.LimpiarControles(gbCaracteristicas);

            // Desmarcar fecha de vencimiento
            chkTieneVencimiento.Checked = false;
            dtpFechaVencimiento.Value = DateTime.Today;

            // Ocultar fecha de vencimiento
            dtpFechaVencimiento.Visible = false;

            //Actualizar las características
            cmbCategoria_SelectedIndexChanged(null, EventArgs.Empty);
        }

        //Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                Producto producto = CrearProductoBase();

                //Constructor de fruta
                if (cmbCategoria.Text == "Fruta")
                {
                    Fruta fruta = new Fruta(
                        producto.Id,
                        producto.Codigo,
                        producto.Nombre,
                        producto.Descripcion,
                        producto.PrecioCompra,
                        producto.PrecioVenta,
                        producto.Stock,
                        producto.FechaIngreso,
                        producto.FechaVencimiento,
                        producto.Activo,
                        txtTipo.Text.Trim(),
                        cmbMadurez.Text,
                        cmbMedida.Text
                    );
                    //Registo de fruta
                    productoServicio.RegistrarFruta(fruta);
                }
                //Constructor de hortaliza
                else if (cmbCategoria.Text == "Hortaliza")
                {
                    Hortaliza hortaliza = new Hortaliza(
                        producto.Id,
                        producto.Codigo,
                        producto.Nombre,
                        producto.Descripcion,
                        producto.PrecioCompra,
                        producto.PrecioVenta,
                        producto.Stock,
                        producto.FechaIngreso,
                        producto.FechaVencimiento,
                        producto.Activo,
                        txtTipo.Text.Trim(),
                        cmbMedida.Text
                    );
                    //Registro de Hortaliza
                    productoServicio.RegistrarHortaliza(hortaliza);
                }

                //Constructor de tuberculo
                else if (cmbCategoria.Text == "Tuberculo")
                {
                    Tuberculo tuberculo = new Tuberculo(
                        producto.Id,
                        producto.Codigo,
                        producto.Nombre,
                        producto.Descripcion,
                        producto.PrecioCompra,
                        producto.PrecioVenta,
                        producto.Stock,
                        producto.FechaIngreso,
                        producto.FechaVencimiento,
                        producto.Activo,
                        txtTipo.Text.Trim(),
                        cmbMedida.Text
                    );
                    //Registro de Tuberculo
                    productoServicio.RegistrarTuberculo(tuberculo);
                }

                //Constructor de grano
                else if (cmbCategoria.Text == "Grano")
                {
                    Grano grano = new Grano(
                        producto.Id,
                        producto.Codigo,
                        producto.Nombre,
                        producto.Descripcion,
                        producto.PrecioCompra,
                        producto.PrecioVenta,
                        producto.Stock,
                        producto.FechaIngreso,
                        producto.FechaVencimiento,
                        producto.Activo,
                        txtTipo.Text.Trim(),
                        cmbMedida.Text
                    );
                    //Registo de Grano
                    productoServicio.RegistrarGrano(grano);
                }
                //Carga los productos en el formulario
                CargarProductos();

                //Mensaje que producto fue registrado
                MessageBox.Show(
                    "Producto registrado correctamente.",
                    "AgroAburto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                //Limpiar despues de guardar
                btnLimpiar_Click(sender, e);
            }
            //Error de registro de producto
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al registrar  producto: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //Seleccionar producto de la lista
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verifica que se selecciono una fija.
            if (e.RowIndex < 0)
                return;
            //Obtiene el id del producto
            int id = Convert.ToInt32(
                dgvProductos.Rows[e.RowIndex].Cells["Id"].Value
                );
            //Traer el producto original
            Producto? producto = productoServicio.ListarProductos()
                .FirstOrDefault(p => p.Id == id);
            //Comprobacion que se encontro el producto.
            if (producto == null)
                return;
            //Guardar el ID seleccionado
            idProductoSeleccionado = producto.Id;
            //Cargar datos generales
            txtCodigo.Text = producto.Codigo;
            txtNombre.Text = producto.Nombre;
            txtDescripcion.Text = producto.Descripcion;
            txtPrecioCompra.Text = producto.PrecioCompra.ToString();
            txtPrecioVenta.Text = producto.PrecioVenta.ToString();
            txtStock.Text = producto.Stock.ToString();
            dtpFechaIngreso.Value = producto.FechaIngreso;

            //Cargar fecha de vencimiento
            chkTieneVencimiento.Checked = producto.FechaVencimiento.HasValue;

            if (producto.FechaVencimiento.HasValue)
            {
                dtpFechaVencimiento.MinDate = producto.FechaIngreso.Date;
                dtpFechaVencimiento.Value = producto.FechaVencimiento.Value;
            }

            //Cargar características especiales segun la categoria
            if (producto is Fruta fruta)
            {
                cmbCategoria.SelectedItem = "Fruta";
                txtTipo.Text = fruta.Tipo;
                cmbMadurez.SelectedItem = fruta.Madurez;
                cmbMedida.SelectedItem = fruta.Medida;
            }
            else if (producto is Hortaliza hortaliza)
            {
                cmbCategoria.SelectedItem = "Hortaliza";
                txtTipo.Text = hortaliza.Tipo;
                cmbMedida.SelectedItem = hortaliza.Medida;
            }
            else if (producto is Tuberculo tuberculo)
            {
                cmbCategoria.SelectedItem = "Tuberculo";
                txtTipo.Text = tuberculo.Tipo;
                cmbMedida.SelectedItem = tuberculo.Medida;
            }
            else if (producto is Grano grano)
            {
                cmbCategoria.SelectedItem = "Grano";
                txtTipo.Text = grano.Tipo;
                cmbMedida.SelectedItem = grano.Medida;
            }
        }

        //Modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Evita que se le de al boton modificar sin tener un producto seleccionado.
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista para modificar.");
                return;
            }

            //Verifica los campos antes de modificar que tengan datos
            if (!ValidarCampos())
                return;

            try
            {
                //Creacion del objeto base con los datos del formulario.
                Producto producto = CrearProductoBase();

                //Asignacion el ID del producto seleccionado para actualizarlo.
                producto.Id = idProductoSeleccionado;

                //Actualizacion el producto segun su categoria.
                switch (cmbCategoria.Text)
                {
                    case "Fruta":
                        producto = new Fruta(
                            producto.Id,
                            producto.Codigo,
                            producto.Nombre,
                            producto.Descripcion,
                            producto.PrecioCompra,
                            producto.PrecioVenta,
                            producto.Stock,
                            producto.FechaIngreso,
                            producto.FechaVencimiento,
                            producto.Activo,
                            txtTipo.Text.Trim(),
                            cmbMadurez.Text,
                            cmbMedida.Text
                        );
                        break;

                    case "Hortaliza":
                        producto = new Hortaliza(
                            producto.Id,
                            producto.Codigo,
                            producto.Nombre,
                            producto.Descripcion,
                            producto.PrecioCompra,
                            producto.PrecioVenta,
                            producto.Stock,
                            producto.FechaIngreso,
                            producto.FechaVencimiento,
                            producto.Activo,
                            txtTipo.Text.Trim(),
                            cmbMedida.Text
                        );
                        break;

                    case "Tuberculo":
                        producto = new Tuberculo(
                            producto.Id,
                            producto.Codigo,
                            producto.Nombre,
                            producto.Descripcion,
                            producto.PrecioCompra,
                            producto.PrecioVenta,
                            producto.Stock,
                            producto.FechaIngreso,
                            producto.FechaVencimiento,
                            producto.Activo,
                            txtTipo.Text.Trim(),
                            cmbMedida.Text
                        );
                        break;

                    case "Grano":
                        producto = new Grano(
                            producto.Id,
                            producto.Codigo,
                            producto.Nombre,
                            producto.Descripcion,
                            producto.PrecioCompra,
                            producto.PrecioVenta,
                            producto.Stock,
                            producto.FechaIngreso,
                            producto.FechaVencimiento,
                            producto.Activo,
                            txtTipo.Text.Trim(),
                            cmbMedida.Text
                        );
                        break;
                }

                //Envia el producto al servicio para actualizarlo en la base de datos.
                productoServicio.ActualizarProducto(producto);

                //Actualiza la lista de productos.
                CargarProductos();

                //Mensaje que la modificación fue exitosa.
                MessageBox.Show("Producto modificado correctamente.");

                //Limpia los controles del formulario.
                btnLimpiar_Click(sender, e);
            }

            //Mensaje de error sino se pudo modificar
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto: " + ex.Message);
            }

        }

        //Eliminar producto logicamente no de base, en base queda inactivo
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Verificacion que exista un producto seleccionado.
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista para eliminar.");
                return;
            }

            //Solicita confirmación antes de desactivar el producto.
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta == DialogResult.No)
                return;

            try
            {
                //Desactivacion de producto sin eliminarlo de la base de datos.
                productoServicio.DesactivarProducto(idProductoSeleccionado);

                //Actualizacion la lista de productos.
                CargarProductos();

                //Informa que la operación fue exitosa.
                MessageBox.Show("Producto eliminado correctamente.");

                //Limpia los controles del formulario.
                btnLimpiar_Click(sender, e);
            }
            //Mensaje si hay error al desactivar producto
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
        }

        //Evento que se ejecuta al cargar el formulario.
        //Se utiliza para inicializar controles, cargar información
        //y preparar la pantalla antes de que el usuario la utilice.
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        //Leer los datos de producto
        private Producto CrearProductoBase()
        {
            return new Producto(
                0,
                txtCodigo.Text.Trim(),
                txtNombre.Text.Trim(),
                txtDescripcion.Text.Trim(),
                Convert.ToDecimal(txtPrecioCompra.Text),
                Convert.ToDecimal(txtPrecioVenta.Text),
                Convert.ToDecimal(txtStock.Text),
                dtpFechaIngreso.Value,
                chkTieneVencimiento.Checked
                    ? dtpFechaVencimiento.Value
                    : null,
                true
            );
        }

        //Cargar productos en la lista
        private void CargarProductos()
        {
            try
            {
                dgvProductos.DataSource = null;

                var productos = productoServicio.ListarProductos();

                var lista = productos.Select(p => new
                {
                    p.Id,
                    p.Codigo,
                    p.Nombre,
                    Tipo = p switch
                    {
                        Fruta f => f.Tipo,
                        Hortaliza h => h.Tipo,
                        Tuberculo t => t.Tipo,
                        Grano g => g.Tipo,
                        _ => ""
                    },
                    p.Descripcion,
                    p.PrecioCompra,
                    p.PrecioVenta,
                    p.Stock,
                    p.FechaIngreso,
                    p.FechaVencimiento,
                    p.Activo
                }).ToList();

                //Cargar lista de productos.
                dgvProductos.DataSource = lista;

                //Configurar encabezados, formatos y columnas.
                Utilidades.ConfigurarColumnasProductos(dgvProductos);
            }
            //Mensaje si no se cargan los productos
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los productos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //Validar los campos en gestion de productos
        private bool ValidarCampos()
        {
            //Validacion los campos de texto no esten vacidos.
            if (!Utilidades.ValidarCampoTexto(txtCodigo, "Ingrese el código del producto"))
                return false;
            if (!Utilidades.ValidarCampoTexto(txtNombre, "Ingrese el nombre del producto"))
                return false;
            if (!Utilidades.ValidarCampoTexto(txtPrecioCompra, "Ingrese el precio de compra"))
                return false;
            if (!Utilidades.ValidarCampoTexto(txtPrecioVenta, "Ingrese el precio de venta"))
                return false;
            if (!Utilidades.ValidarCampoTexto(txtStock, "Ingrese el stock del producto"))
                return false;
            if (!Utilidades.ValidarCampoTexto(txtTipo, "Ingrese el tipo de producto"))
                return false;

            //Validacion escoger una categoria
            if (!Utilidades.ValidarComboBox(cmbCategoria, "Seleccione una categoría"))
                return false;

            //Validacion escoger una medida
            if (!Utilidades.ValidarComboBox(cmbMedida, "Seleccione una medida"))
                return false;

            //Validacion escoger una madurez
            if (cmbCategoria.Text == "Fruta")
            {
                if (!Utilidades.ValidarComboBox(cmbMadurez, "Seleccione la madurez"))
                    return false;
            }

            //Validacion precio de compra
            if (!Utilidades.ValidarNumeroPositivo(txtPrecioCompra, "El precio de compra debe ser un número mayor que cero"))
                return false;

            //Validacion precio de venta
            if (!Utilidades.ValidarNumeroPositivo(txtPrecioVenta, "El precio de venta debe ser un número mayor que cero"))
                return false;

            //Validacion del stock
            if (!Utilidades.ValidarNumeroNoNegativo(txtStock, "La cantidad debe ser un número igual o mayor que cero"))
                return false;

            //Validacion fecha de vencimiento si el CheckBox está marcado
            if (chkTieneVencimiento.Checked)
            {
                if (!Utilidades.ValidarFechas(dtpFechaIngreso, dtpFechaVencimiento))
                    return false;
            }

            return true;
        }

        //Metodo para buscar productos.
        private void BuscarProductos(string texto, bool mostrarInactivos = false)
        {
            try
            {
                var productos = productoServicio.BuscarProducto(
                    texto,
                    mostrarInactivos ? false : true,
                    null
                );

                //Preparar los datos incluyendo el tipo de cada producto.
                var lista = productos.Select(p => new
                {
                    p.Id,
                    p.Codigo,
                    p.Nombre,
                    Tipo = p switch
                    {
                        Fruta f => f.Tipo,
                        Hortaliza h => h.Tipo,
                        Tuberculo t => t.Tipo,
                        Grano g => g.Tipo,
                        _ => ""
                    },
                    p.Descripcion,
                    p.PrecioCompra,
                    p.PrecioVenta,
                    p.Stock,
                    p.FechaIngreso,
                    p.FechaVencimiento,
                    p.Activo
                }).ToList();

                //Limpiar el origen anterior.
                dgvProductos.DataSource = null;

                //Cargar los resultados.
                dgvProductos.AutoGenerateColumns = true;
                dgvProductos.DataSource = lista;

                //Configurar encabezados, formatos y columnas.
                Utilidades.ConfigurarColumnasProductos(dgvProductos);
            }
            catch (Exception ex)
            {
                //Mensaje si fallo la busqueda
                MessageBox.Show(
                    "Error al buscar productos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

    }
}
