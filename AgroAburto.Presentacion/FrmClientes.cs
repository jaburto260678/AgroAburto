using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroAburto.Negocio.Servicios;
using AgroAburto.Entidades;


namespace AgroAburto.Presentacion
{
    public partial class FrmClientes : Form
    {
        //Crear instancia del servicio de clientes
        private readonly ClienteServicio clienteServicio = new ClienteServicio();
        //Variable para guardar el ID del cliente seleccionado.
        private int idClienteSeleccionado = 0;

        //Constructor
        public FrmClientes()
        {
            InitializeComponent();

            //Conecta selección de clientes.
            dgvClientes.CellClick += dgvClientes_CellClick;

            //Carga clientes al abrir.
            this.Load += FrmClientes_Load;

            // Leer textbox de búsqueda.
            Utilidades.ConfigurarBusqueda(txtBuscar, texto => BuscarClientes(texto));

            // Configuración del DataGridView.
            Utilidades.ConfigurarDataGridView(dgvClientes, this);

            // Características de búsqueda.
            Utilidades.ConfigurarBusqueda(btnBuscar, txtBuscar, this);

            // Aplicar centrado del DataGridView.
            this.Resize += (s, e) =>
            {
                Utilidades.ConfigurarDataGridView(dgvClientes, this);
            };

            // Centrar título.
            pnlEncabezado.Resize += (s, e) =>
            Utilidades.CentrarTitulo(lblTitulo, pnlEncabezado);

            Utilidades.CentrarTitulo(lblTitulo, pnlEncabezado);

            // Centrar GroupBox.
            this.Resize += (s, e) =>
            {
                Utilidades.CentrarGroupBox(gbCliente, this);
                Utilidades.ConfigurarBusqueda(btnBuscar, txtBuscar, this);
            };

            // Configurar botones.
            this.Resize += (s, e) =>
            {
                Utilidades.ConfigurarBotones(this,
                    btnGuardar,
                    btnModificar,
                    btnEliminar,
                    btnLimpiar,
                    btnVolver);
            };

            // Configurar GroupBox al iniciar.
            Utilidades.CentrarGroupBox(gbCliente, this);

            // Configurar botones al iniciar.
            Utilidades.ConfigurarBotones(this,
                btnGuardar,
                btnModificar,
                btnEliminar,
                btnLimpiar,
                btnVolver);

            // Opciones del tipo de cliente.
            cmbTipo.Items.Add("Persona Física");
            cmbTipo.Items.Add("Persona Jurídica");
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;

            // Configurar filtro de clientes activos e inactivos.
            Utilidades.ConfigurarFiltroEstado(chkEstado,
                mostrarInactivos => BuscarClientes(txtBuscar.Text.Trim(), mostrarInactivos));

            // Posición del filtro.
            Utilidades.AlinearControlDerechaEnLinea(chkEstado, txtBuscar, 240);
        }

        //Metodo cargar clientes en la lista.
        private void CargarClientes()
        {
            try
            {
                dgvClientes.DataSource = null;

                var clientes = clienteServicio.ListarClientes();

                var lista = clientes.Select(c => new
                {
                    c.Id,
                    c.Nombre,
                    c.Apellidos,
                    c.Telefono,
                    c.Correo,
                    c.Direccion,
                    c.Tipo,
                    c.Cedula,
                    c.FechaIngreso,
                    c.Activo
                }).ToList();

                // Generar columnas automáticamente.
                dgvClientes.AutoGenerateColumns = true;

                // Cargar lista de clientes.
                dgvClientes.DataSource = lista;

                // Configurar encabezados y columnas.
                Utilidades.ConfigurarDataGridView(dgvClientes, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los clientes: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //Metodo para buscar clientes.
        private void BuscarClientes(string texto, bool mostrarInactivos = false)
        {
            try
            {
                var clientes = clienteServicio.ListarClientes();

                var filtrados = clientes
                    .Where(c => !mostrarInactivos || !c.Activo)
                    .Where(c =>
                        string.IsNullOrWhiteSpace(texto) ||
                        c.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                        c.Apellidos.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                        c.Telefono.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                        c.Cedula.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                        (c.Correo ?? "").Contains(texto, StringComparison.OrdinalIgnoreCase)
                    )
                    .ToList();

                var lista = filtrados.Select(c => new
                {
                    c.Id,
                    c.Nombre,
                    c.Apellidos,
                    c.Telefono,
                    c.Correo,
                    c.Direccion,
                    c.Tipo,
                    c.Cedula,
                    c.FechaIngreso,
                    c.Activo
                }).ToList();

                // Limpiar origen anterior.
                dgvClientes.DataSource = null;

                // Cargar resultados.
                dgvClientes.DataSource = lista;

                // Configurar columnas.
                Utilidades.ConfigurarDataGridView(dgvClientes, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar clientes: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //Metodo para validar los campos.
        private bool ValidarCampos()
        {
            // Validar campos de texto obligatorios.
            if (!Utilidades.ValidarCampoTexto(txtNombre, "Ingrese el nombre del cliente"))
                return false;

            if (!Utilidades.ValidarCampoTexto(txtApellidos, "Ingrese los apellidos del cliente"))
                return false;

            if (!Utilidades.ValidarCampoTexto(txtTelefono, "Ingrese el teléfono del cliente"))
                return false;

            if (!Utilidades.ValidarCampoTexto(txtCedula, "Ingrese la cédula del cliente"))
                return false;

            // Validar selección del tipo de cliente.
            if (!Utilidades.ValidarComboBox(cmbTipo, "Seleccione el tipo de cliente"))
                return false;

            return true;
        }

        //Metodo para crear cliente
        private Cliente CrearCliente()
        {
            return new Cliente(
                0,
                txtNombre.Text.Trim(),
                txtApellidos.Text.Trim(),
                txtTelefono.Text.Trim(),
                txtCorreo.Text.Trim(),
                txtDireccion.Text.Trim(),
                DateTime.Now,
                true,
                cmbTipo.Text,
                txtCedula.Text.Trim()
            );
        }

        //Metodo para guardar cliente.
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar los campos antes de guardar.
                if (!ValidarCampos())
                    return;

                // Crear objeto cliente.
                Cliente cliente = CrearCliente();

                // Registrar cliente.
                clienteServicio.RegistrarCliente(cliente);

                // Actualizar la lista de clientes.
                CargarClientes();

                // Mensaje de registro exitoso.
                MessageBox.Show(
                    "Cliente registrado correctamente.",
                    "AgroAburto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Limpiar después de guardar.
                btnLimpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al registrar el cliente: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //Metodo para seleccionar cliente de la lista.
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se seleccionó una fila.
            if (e.RowIndex < 0)
                return;

            // Obtener el ID del cliente.
            int id = Convert.ToInt32(
                dgvClientes.Rows[e.RowIndex].Cells["Id"].Value
            );

            // Traer el cliente original.
            Cliente? cliente = clienteServicio.ListarClientes()
                .FirstOrDefault(c => c.Id == id);

            // Comprobar que se encontró el cliente.
            if (cliente == null)
                return;

            // Guardar el ID seleccionado.
            idClienteSeleccionado = cliente.Id;

            // Cargar datos generales.
            txtNombre.Text = cliente.Nombre;
            txtApellidos.Text = cliente.Apellidos;
            txtTelefono.Text = cliente.Telefono;
            txtCorreo.Text = cliente.Correo;
            txtDireccion.Text = cliente.Direccion;

            // Cargar datos específicos.
            cmbTipo.SelectedItem = cliente.Tipo;
            txtCedula.Text = cliente.Cedula;
        }

        //Metodo modificar cliente.
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Verificar que exista un cliente seleccionado.
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente de la lista para modificar.");
                return;
            }

            // Validar los campos antes de modificar.
            if (!ValidarCampos())
                return;

            try
            {
                // Crear objeto con los datos del formulario.
                Cliente cliente = CrearCliente();

                // Asignar el ID del cliente seleccionado.
                cliente.Id = idClienteSeleccionado;

                // Actualizar cliente.
                clienteServicio.ActualizarCliente(cliente);

                // Actualizar la lista de clientes.
                CargarClientes();

                // Mensaje de modificación exitosa.
                MessageBox.Show("Cliente modificado correctamente.");

                // Limpiar los controles.
                btnLimpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al modificar el cliente: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //Metodo para eliminar cliente lógicamente.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar que exista un cliente seleccionado.
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente de la lista para eliminar.");
                return;
            }

            // Solicitar confirmación.
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea eliminar este cliente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta == DialogResult.No)
                return;

            try
            {
                // Desactivar cliente sin eliminarlo de la base de datos.
                clienteServicio.DesactivarCliente(idClienteSeleccionado);

                // Actualizar la lista.
                CargarClientes();

                // Mensaje de operación exitosa.
                MessageBox.Show("Cliente eliminado correctamente.");

                // Limpiar controles.
                btnLimpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el cliente: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //Metodo para limpiar los campos del formulario.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los controles del GroupBox.
            Utilidades.LimpiarControles(gbCliente);

            // Reiniciar el cliente seleccionado.
            idClienteSeleccionado = 0;

            // Quitar selección del DataGridView.
            dgvClientes.ClearSelection();
        }

        //Metodo para volver al menu principal.
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Utilidades.VolverAlMenu(this);
        }

        //Evento que se ejecuta al cargar el formulario.
        //Se utiliza para inicializar controles, cargar información
        //y preparar la pantalla antes de que el usuario la utilice.
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }


    }
}
