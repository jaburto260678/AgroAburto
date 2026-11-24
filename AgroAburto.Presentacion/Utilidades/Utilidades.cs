using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace AgroAburto.Presentacion
{
    public static class Utilidades
    {
        //Metodo para volver al menu principal
        public static void VolverAlMenu(Form formulario)
        {
            formulario.Close();
        }
        //Metodo para limpiar opciones.
        public static void LimpiarControles(Control formulario)
        {
            foreach (Control control in formulario.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Today;
                }
                if (control.HasChildren)
                {
                    LimpiarControles(control);
                }
            }
        }
        //Metodo para centrar un titulo dentro de un panel
        public static void CentrarTitulo(Label titulo, Panel panel)
        {
            titulo.Left = (panel.Width - titulo.Width) / 2;
            titulo.Top = (panel.Height - titulo.Height) / 2;
        }

        //Metodo para centrar un GroupBox dentro del formulario
        public static void CentrarGroupBox(GroupBox grupo, Form formulario)
        {
            grupo.Left = (formulario.ClientSize.Width - grupo.Width) / 2;
        }

        //Metodo para caracteristicas de los botones
        public static void ConfigurarBotones(Control contenedor, params Button[] botones)
        {
            int espacio = 10;
            int ancho = 120;
            int alto = 47;

            for (int i = 0; i < botones.Length; i++)
            {
                botones[i].Size = new Size(ancho, alto);
                botones[i].ForeColor = Color.White;
                botones[i].Font = new Font("Segoe UI", 10, FontStyle.Bold);
                botones[i].FlatStyle = FlatStyle.Flat;
                botones[i].FlatAppearance.BorderSize = 0;
                botones[i].Cursor = Cursors.Hand;

                // Asignacion de colores según el botón
                switch (botones[i].Name)
                {
                    case "btnGuardar":
                        botones[i].BackColor = Color.FromArgb(25, 135, 84);
                        break;

                    case "btnModificar":
                        botones[i].BackColor = Color.FromArgb(13, 110, 253);
                        break;

                    case "btnEliminar":
                        botones[i].BackColor = Color.FromArgb(220, 53, 69);
                        break;

                    case "btnLimpiar":
                        botones[i].BackColor = Color.FromArgb(108, 117, 125);
                        break;

                    case "btnVolver":
                        botones[i].BackColor = Color.FromArgb(121, 85, 72);
                        break;
                }
            }
            int anchoTotal = botones.Sum(b => b.Width) + espacio * (botones.Length - 1);
            int inicio = (contenedor.ClientSize.Width - anchoTotal) / 2;
            foreach (Button boton in botones)
            {
                boton.Left = inicio;
                inicio += boton.Width + espacio;
            }
        }

        //Metodo para centrar el cuadro de búsqueda y boton
        public static void ConfigurarBusqueda(
            Button btnBuscar,
            TextBox txtBuscar,
            Form formulario,
            int anchoBoton = 120,
            int altoBoton = 42,
            int anchoTexto = 250,
            int altoTexto = 30)
        {
            int espacio = 10;

            //Configurar boton.
            btnBuscar.Size = new Size(anchoBoton, altoBoton);
            btnBuscar.BackColor = Color.FromArgb(121, 82, 160);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.Cursor = Cursors.Hand;

            //Configurar cuadro de busqueda.
            txtBuscar.Size = new Size(anchoTexto, altoTexto);

            //Calcular el ancho total.
            int anchoTotal = btnBuscar.Width + espacio + txtBuscar.Width;

            //Centrar ambos controles horizontalmente.
            int inicio = (formulario.ClientSize.Width - anchoTotal) / 2;

            btnBuscar.Left = inicio;
            txtBuscar.Left = btnBuscar.Right + espacio;

            //Centrar verticalmente el botón respecto al TextBox.
            btnBuscar.Top = txtBuscar.Top + (txtBuscar.Height - btnBuscar.Height) / 2;
        }

        //Metodo para mostrar u ocultar caracteristicas
        public static void MostrarControl(Control control, bool mostrar)
        {
            control.Visible = mostrar;
        }

        // Validar que un campo de texto no esté vacío
        public static bool ValidarCampoTexto(TextBox campo, string mensaje)
        {
            if (string.IsNullOrWhiteSpace(campo.Text))
            {
                MessageBox.Show(mensaje);
                campo.Focus();
                return false;
            }
            return true;
        }

        // Validar que ComboBox tenga una opción seleccionada
        public static bool ValidarComboBox(ComboBox combo, string mensaje)
        {
            if (combo.SelectedIndex == -1)
            {
                MessageBox.Show(mensaje);
                combo.Focus();
                return false;
            }
            return true;
        }

        //Validacion número decimal positivo, letras, caracteres incorrectos.
        public static bool ValidarNumeroPositivo(TextBox campo, string mensaje)
        {
            decimal valor;

            if (!decimal.TryParse(campo.Text, out valor) || valor <= 0)
            {
                MessageBox.Show(mensaje);
                campo.Focus();
                return false;
            }
            return true;
        }

        //Validacion que numero sea igual o mayor que cero
        public static bool ValidarNumeroNoNegativo(TextBox campo, string mensaje)
        {
            decimal valor;

            if (!decimal.TryParse(campo.Text, out valor) || valor < 0)
            {
                MessageBox.Show(mensaje);
                campo.Focus();
                return false;
            }
            return true;
        }

        //Validacion que la fecha de vencimiento no sea anterior a la fecha de ingreso
        public static bool ValidarFechas(DateTimePicker fechaIngreso, DateTimePicker fechaVencimiento)
        {
            if (fechaVencimiento.Value.Date < fechaIngreso.Value.Date)
            {
                MessageBox.Show("La fecha de vencimiento debe ser mayor o igual a la fecha de ingreso.");
                fechaVencimiento.Focus();
                return false;
            }
            return true;
        }

        //Configuracion de diseño y centrar DataGridView
        public static void ConfigurarDataGridView(DataGridView tabla, Form formulario)
        {
            //Configuracion general
            tabla.ReadOnly = true;
            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToDeleteRows = false;
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla.MultiSelect = false;
            tabla.RowHeadersVisible = false;

            //Barra de desplazamiento vertical y mostrar la horizontal.
            tabla.ScrollBars = ScrollBars.Both;

            //Ajustar cada columna según el contenido más largo.
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Ocultar la columna ID.
            if (tabla.Columns.Contains("Id"))
                tabla.Columns["Id"].Visible = false;

            // Centrar horizontalmente el DataGridView.
            tabla.Left = (formulario.ClientSize.Width - tabla.Width) / 2;
        }

        //Metodo para búsqueda mientras se escribe.
        public static void ConfigurarBusqueda(TextBox txtBuscar,Action<string> buscar)
        {
            txtBuscar.TextChanged += (sender, e) =>
            {
                buscar(txtBuscar.Text.Trim());
            };
        }

        //Metodo reutilizable para configurar las columnas del DataGridView.
        public static void ConfigurarColumnasProductos(DataGridView tabla)
        {
            // Ocultar columna ID.
            tabla.Columns["Id"].Visible = false;

            // Configurar encabezados.
            tabla.Columns["Codigo"].HeaderText = "Código";
            tabla.Columns["Nombre"].HeaderText = "Producto";
            tabla.Columns["Tipo"].HeaderText = "Tipo";
            tabla.Columns["Descripcion"].HeaderText = "Descripción";
            tabla.Columns["PrecioCompra"].HeaderText = "Precio compra";
            tabla.Columns["PrecioVenta"].HeaderText = "Precio venta";
            tabla.Columns["Stock"].HeaderText = "Inventario";
            tabla.Columns["FechaIngreso"].HeaderText = "Fecha ingreso";
            tabla.Columns["FechaVencimiento"].HeaderText = "Fecha vencimiento";
            tabla.Columns["Activo"].HeaderText = "Activo";

            // Formato de precios en colones.
            tabla.Columns["PrecioCompra"].DefaultCellStyle.Format = "C2";
            tabla.Columns["PrecioVenta"].DefaultCellStyle.Format = "C2";

            // Formato de inventario.
            tabla.Columns["Stock"].DefaultCellStyle.Format = "N0";

            // Formato de fechas.
            tabla.Columns["FechaIngreso"].DefaultCellStyle.Format = "dd/MM/yyyy";
            tabla.Columns["FechaVencimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";

        }

        //Metodo check de productos activos e inactivos.
        public static void ConfigurarFiltroEstado(CheckBox checkBox,Action<bool> filtrar)
        {
            checkBox.CheckedChanged += (sender, e) =>
            {
                filtrar(checkBox.Checked);
            };
        }

        //Colores generales del sistema.
        public static Color VerdePrincipal => Color.FromArgb(23, 77, 53);

        public static Color VerdeSecundario => Color.FromArgb(25, 135, 84);

        public static Color FondoPrincipal => Color.WhiteSmoke;

        public static Color TextoPrincipal => Color.FromArgb(45, 45, 45);

        public static Color Blanco => Color.White;

        //Configuracion botones del menu principal.
        public static void ConfigurarBotonesMenu(
            FlowLayoutPanel contenedor,
            params Button[] botones)
        {
            foreach (Button boton in botones)
            {
                boton.Width = contenedor.ClientSize.Width
                - contenedor.Padding.Horizontal
                - 6;
                boton.Height = 45;
                boton.BackColor = VerdeSecundario;
                boton.ForeColor = Blanco;
                boton.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                boton.FlatStyle = FlatStyle.Flat;
                boton.FlatAppearance.BorderSize = 0;
                boton.Cursor = Cursors.Hand;
                boton.Margin = new Padding(3, 5, 3, 5);
            }
        }

        //Mantener un check alineado a la derecha.
        public static void AlinearControlDerechaEnLinea(
            Control control,
            Control referencia,
            int margenDerecho = 0)
        {
            Action ajustar = () =>
            {
                control.Left = referencia.Right + margenDerecho;
                control.Top = referencia.Top;
            };

            ajustar();

            referencia.LocationChanged += (s, e) => ajustar();
            referencia.SizeChanged += (s, e) => ajustar();
        }

    }
}