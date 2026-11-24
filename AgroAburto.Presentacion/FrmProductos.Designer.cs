namespace AgroAburto.Presentacion
{
    partial class FrmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            gbProducto = new GroupBox();
            chkTieneVencimiento = new CheckBox();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            lblFechaVencimiento = new Label();
            dtpFechaVencimiento = new DateTimePicker();
            dtpFechaIngreso = new DateTimePicker();
            lblFechaIngreso = new Label();
            txtStock = new TextBox();
            lblStock = new Label();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            txtPrecioCompra = new TextBox();
            txtPrecioVenta = new TextBox();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            lblPrecioVenta = new Label();
            lblPrecioCompra = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            btnVolver = new Button();
            gbCaracteristicas = new GroupBox();
            cmbMedida = new ComboBox();
            cmbMadurez = new ComboBox();
            txtTipo = new TextBox();
            lblMadurez = new Label();
            lblMedida = new Label();
            lblTipo = new Label();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnModificar = new Button();
            dgvProductos = new DataGridView();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            chkEstado = new CheckBox();
            pnlEncabezado.SuspendLayout();
            gbProducto.SuspendLayout();
            gbCaracteristicas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.DarkGreen;
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1161, 65);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(455, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(382, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE PRODUCTOS";
            // 
            // gbProducto
            // 
            gbProducto.Anchor = AnchorStyles.Top;
            gbProducto.BackColor = Color.LightSteelBlue;
            gbProducto.Controls.Add(chkTieneVencimiento);
            gbProducto.Controls.Add(txtDescripcion);
            gbProducto.Controls.Add(lblDescripcion);
            gbProducto.Controls.Add(lblFechaVencimiento);
            gbProducto.Controls.Add(dtpFechaVencimiento);
            gbProducto.Controls.Add(dtpFechaIngreso);
            gbProducto.Controls.Add(lblFechaIngreso);
            gbProducto.Controls.Add(txtStock);
            gbProducto.Controls.Add(lblStock);
            gbProducto.Controls.Add(lblCategoria);
            gbProducto.Controls.Add(cmbCategoria);
            gbProducto.Controls.Add(txtPrecioCompra);
            gbProducto.Controls.Add(txtPrecioVenta);
            gbProducto.Controls.Add(txtCodigo);
            gbProducto.Controls.Add(txtNombre);
            gbProducto.Controls.Add(lblPrecioVenta);
            gbProducto.Controls.Add(lblPrecioCompra);
            gbProducto.Controls.Add(lblNombre);
            gbProducto.Controls.Add(lblCodigo);
            gbProducto.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbProducto.Location = new Point(-127, 87);
            gbProducto.Name = "gbProducto";
            gbProducto.Size = new Size(1100, 380);
            gbProducto.TabIndex = 1;
            gbProducto.TabStop = false;
            gbProducto.Text = "Datos del producto";
            // 
            // chkTieneVencimiento
            // 
            chkTieneVencimiento.AutoSize = true;
            chkTieneVencimiento.Location = new Point(417, 225);
            chkTieneVencimiento.Name = "chkTieneVencimiento";
            chkTieneVencimiento.Size = new Size(265, 27);
            chkTieneVencimiento.TabIndex = 21;
            chkTieneVencimiento.Text = "¿Tiene fecha de vencimiento?";
            chkTieneVencimiento.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(42, 303);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(625, 60);
            txtDescripcion.TabIndex = 20;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(42, 277);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(108, 23);
            lblDescripcion.TabIndex = 19;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Location = new Point(807, 199);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(188, 23);
            lblFechaVencimiento.TabIndex = 18;
            lblFechaVencimiento.Text = "Fecha de vencimiento:";
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(807, 225);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(250, 30);
            dtpFechaVencimiento.TabIndex = 17;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(42, 225);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(250, 30);
            dtpFechaIngreso.TabIndex = 16;
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(42, 199);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(149, 23);
            lblFechaIngreso.TabIndex = 15;
            lblFechaIngreso.Text = "Fecha de ingreso:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(807, 148);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(250, 30);
            txtStock.TabIndex = 14;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(807, 122);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(174, 23);
            lblStock.TabIndex = 13;
            lblStock.Text = "Cantidad inventario:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.ForeColor = Color.Black;
            lblCategoria.Location = new Point(807, 44);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(93, 23);
            lblCategoria.TabIndex = 12;
            lblCategoria.Text = "Categoría:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(807, 70);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(250, 31);
            cmbCategoria.TabIndex = 11;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(417, 148);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(250, 30);
            txtPrecioCompra.TabIndex = 10;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(42, 148);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(250, 30);
            txtPrecioVenta.TabIndex = 9;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(42, 70);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(250, 30);
            txtCodigo.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(417, 71);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 30);
            txtNombre.TabIndex = 6;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.ForeColor = Color.Black;
            lblPrecioVenta.Location = new Point(42, 122);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(133, 23);
            lblPrecioVenta.TabIndex = 3;
            lblPrecioVenta.Text = "Precio de venta";
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.AutoSize = true;
            lblPrecioCompra.ForeColor = Color.Black;
            lblPrecioCompra.Location = new Point(417, 122);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(155, 23);
            lblPrecioCompra.TabIndex = 2;
            lblPrecioCompra.Text = "Precio de compra:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(417, 44);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 23);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.LightSteelBlue;
            lblCodigo.ForeColor = Color.Black;
            lblCodigo.Location = new Point(42, 44);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(73, 23);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código:";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(121, 85, 72);
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(604, 658);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(120, 42);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // gbCaracteristicas
            // 
            gbCaracteristicas.Anchor = AnchorStyles.Top;
            gbCaracteristicas.BackColor = Color.LightSteelBlue;
            gbCaracteristicas.Controls.Add(cmbMedida);
            gbCaracteristicas.Controls.Add(cmbMadurez);
            gbCaracteristicas.Controls.Add(txtTipo);
            gbCaracteristicas.Controls.Add(lblMadurez);
            gbCaracteristicas.Controls.Add(lblMedida);
            gbCaracteristicas.Controls.Add(lblTipo);
            gbCaracteristicas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbCaracteristicas.Location = new Point(-127, 486);
            gbCaracteristicas.Name = "gbCaracteristicas";
            gbCaracteristicas.Size = new Size(1100, 150);
            gbCaracteristicas.TabIndex = 7;
            gbCaracteristicas.TabStop = false;
            gbCaracteristicas.Text = "Características adicionales";
            // 
            // cmbMedida
            // 
            cmbMedida.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedida.FormattingEnabled = true;
            cmbMedida.Location = new Point(417, 61);
            cmbMedida.Name = "cmbMedida";
            cmbMedida.Size = new Size(250, 31);
            cmbMedida.TabIndex = 6;
            // 
            // cmbMadurez
            // 
            cmbMadurez.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMadurez.FormattingEnabled = true;
            cmbMadurez.Location = new Point(807, 62);
            cmbMadurez.Name = "cmbMadurez";
            cmbMadurez.Size = new Size(250, 31);
            cmbMadurez.TabIndex = 5;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(40, 62);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(250, 30);
            txtTipo.TabIndex = 3;
            // 
            // lblMadurez
            // 
            lblMadurez.AutoSize = true;
            lblMadurez.Location = new Point(807, 36);
            lblMadurez.Name = "lblMadurez";
            lblMadurez.Size = new Size(85, 23);
            lblMadurez.TabIndex = 2;
            lblMadurez.Text = "Madurez:";
            // 
            // lblMedida
            // 
            lblMedida.AutoSize = true;
            lblMedida.Location = new Point(415, 36);
            lblMedida.Name = "lblMedida";
            lblMedida.Size = new Size(76, 23);
            lblMedida.TabIndex = 1;
            lblMedida.Text = "Medida:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(40, 36);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(51, 23);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(108, 117, 125);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(478, 658);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 42);
            btnLimpiar.TabIndex = 5;
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
            btnEliminar.Location = new Point(352, 658);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 42);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(25, 135, 84);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(100, 658);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 42);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(13, 110, 253);
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(226, 658);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 42);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.Location = new Point(-83, 784);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(1100, 325);
            dgvProductos.TabIndex = 8;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(121, 82, 160);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(171, 718);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 47);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar:";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(311, 718);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(372, 38);
            txtBuscar.TabIndex = 10;
            // 
            // chkEstado
            // 
            chkEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkEstado.AutoSize = true;
            chkEstado.BackColor = SystemColors.ControlLight;
            chkEstado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEstado.Location = new Point(808, 724);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(125, 32);
            chkEstado.TabIndex = 11;
            chkEstado.Text = "Inactivos ";
            chkEstado.UseVisualStyleBackColor = false;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(18F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(0, 1200);
            ClientSize = new Size(1182, 1153);
            Controls.Add(chkEstado);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(dgvProductos);
            Controls.Add(gbCaracteristicas);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(gbProducto);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Margin = new Padding(7, 6, 7, 6);
            Name = "FrmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de productos";
            Load += FrmProductos_Load;
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            gbProducto.ResumeLayout(false);
            gbProducto.PerformLayout();
            gbCaracteristicas.ResumeLayout(false);
            gbCaracteristicas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private Label lblCodigo;
        private Label lblPrecioVenta;
        private Label lblPrecioCompra;
        private Label lblNombre;
        private ComboBox cmbCategoria;
        private TextBox txtPrecioCompra;
        private TextBox txtPrecioVenta;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtStock;
        private Label lblStock;
        private Label lblCategoria;
        public GroupBox gbProducto;
        private DateTimePicker dtpFechaIngreso;
        private Label lblFechaIngreso;
        private Label lblFechaVencimiento;
        private DateTimePicker dtpFechaVencimiento;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Button btnVolver;
        private GroupBox gbCaracteristicas;
        private TextBox txtTipo;
        private Label lblMadurez;
        private Label lblMedida;
        private Label lblTipo;
        private ComboBox cmbMadurez;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnModificar;
        private ComboBox cmbMedida;
        private CheckBox chkTieneVencimiento;
        private DataGridView dgvProductos;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private CheckBox chkEstado;
    }
}