
using System.Drawing;
using System.Windows.Forms;

namespace AgroAburto.Presentacion
{
    partial class FrmClientes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            gbCliente = new GroupBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellidos = new Label();
            txtApellidos = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            lblCedula = new Label();
            txtCedula = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            chkEstado = new CheckBox();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            dgvClientes = new DataGridView();
            btnVolver = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            pnlEncabezado.SuspendLayout();
            gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.DarkGreen;
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1182, 65);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(455, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(336, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE CLIENTES";
            // 
            // gbCliente
            // 
            gbCliente.Anchor = AnchorStyles.Top;
            gbCliente.BackColor = Color.LightSteelBlue;
            gbCliente.Controls.Add(lblNombre);
            gbCliente.Controls.Add(txtNombre);
            gbCliente.Controls.Add(lblApellidos);
            gbCliente.Controls.Add(txtApellidos);
            gbCliente.Controls.Add(lblTelefono);
            gbCliente.Controls.Add(txtTelefono);
            gbCliente.Controls.Add(lblCorreo);
            gbCliente.Controls.Add(txtCorreo);
            gbCliente.Controls.Add(lblTipo);
            gbCliente.Controls.Add(cmbTipo);
            gbCliente.Controls.Add(lblCedula);
            gbCliente.Controls.Add(txtCedula);
            gbCliente.Controls.Add(lblDireccion);
            gbCliente.Controls.Add(txtDireccion);
            gbCliente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            gbCliente.Location = new Point(57, 113);
            gbCliente.Name = "gbCliente";
            gbCliente.Size = new Size(1100, 350);
            gbCliente.TabIndex = 1;
            gbCliente.TabStop = false;
            gbCliente.Text = "Datos del cliente";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(42, 44);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(42, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 30);
            txtNombre.TabIndex = 0;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(417, 44);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(90, 23);
            lblApellidos.TabIndex = 1;
            lblApellidos.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(417, 71);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(250, 30);
            txtApellidos.TabIndex = 1;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(807, 44);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(83, 23);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(807, 70);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(250, 30);
            txtTelefono.TabIndex = 2;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(42, 122);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(162, 23);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo electrónico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(42, 148);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(250, 30);
            txtCorreo.TabIndex = 3;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(417, 122);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(51, 23);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(417, 147);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(250, 31);
            cmbTipo.TabIndex = 4;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(807, 122);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(70, 23);
            lblCedula.TabIndex = 5;
            lblCedula.Text = "Cédula:";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(807, 148);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(250, 30);
            txtCedula.TabIndex = 5;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(42, 201);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(90, 23);
            lblDireccion.TabIndex = 6;
            lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(42, 227);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(625, 88);
            txtDireccion.TabIndex = 6;
            // 
            // chkEstado
            // 
            chkEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkEstado.AutoSize = true;
            chkEstado.BackColor = SystemColors.ControlLight;
            chkEstado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEstado.Location = new Point(937, 558);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(125, 32);
            chkEstado.TabIndex = 20;
            chkEstado.Text = "Inactivos ";
            chkEstado.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(440, 552);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(372, 38);
            txtBuscar.TabIndex = 19;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(121, 82, 160);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(300, 552);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 47);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar:";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.Location = new Point(46, 618);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(1100, 325);
            dgvClientes.TabIndex = 17;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(121, 85, 72);
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(733, 492);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(120, 42);
            btnVolver.TabIndex = 16;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(108, 117, 125);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(607, 492);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 42);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(220, 53, 69);
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(481, 492);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 42);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(13, 110, 253);
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(355, 492);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 42);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(25, 135, 84);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(229, 492);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 42);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1182, 1153);
            Controls.Add(chkEstado);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(dgvClientes);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(gbCliente);
            Controls.Add(pnlEncabezado);
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgroAburto - Gestión de Clientes";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            gbCliente.ResumeLayout(false);
            gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private GroupBox gbCliente;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellidos;
        private TextBox txtApellidos;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblTipo;
        private ComboBox cmbTipo;
        private Label lblCedula;
        private TextBox txtCedula;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private CheckBox chkEstado;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private DataGridView dgvClientes;
        private Button btnVolver;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
    }
}
