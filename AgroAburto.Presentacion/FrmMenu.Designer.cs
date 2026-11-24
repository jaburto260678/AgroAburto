namespace AgroAburto.Presentacion
{
    partial class FrmMenu
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
            pnlMenu = new Panel();
            flpOpciones = new FlowLayoutPanel();
            btnInicio = new Button();
            btnProductos = new Button();
            btnClientes = new Button();
            btnProveedores = new Button();
            btnUsuarios = new Button();
            btnVentas = new Button();
            btnReportes = new Button();
            lblSubtitulo = new Label();
            lblNombreSistema = new Label();
            pnlContenido = new Panel();
            pnlMenu.SuspendLayout();
            flpOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(23, 77, 53);
            pnlMenu.Controls.Add(flpOpciones);
            pnlMenu.Controls.Add(lblSubtitulo);
            pnlMenu.Controls.Add(lblNombreSistema);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(230, 603);
            pnlMenu.TabIndex = 0;
            // 
            // flpOpciones
            // 
            flpOpciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpOpciones.BackColor = Color.Transparent;
            flpOpciones.Controls.Add(btnInicio);
            flpOpciones.Controls.Add(btnProductos);
            flpOpciones.Controls.Add(btnClientes);
            flpOpciones.Controls.Add(btnProveedores);
            flpOpciones.Controls.Add(btnUsuarios);
            flpOpciones.Controls.Add(btnVentas);
            flpOpciones.Controls.Add(btnReportes);
            flpOpciones.FlowDirection = FlowDirection.TopDown;
            flpOpciones.Location = new Point(0, 155);
            flpOpciones.Margin = new Padding(5);
            flpOpciones.Name = "flpOpciones";
            flpOpciones.Padding = new Padding(10);
            flpOpciones.Size = new Size(230, 480);
            flpOpciones.TabIndex = 2;
            flpOpciones.WrapContents = false;
            // 
            // btnInicio
            // 
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.Black;
            btnInicio.Location = new Point(13, 15);
            btnInicio.Margin = new Padding(3, 5, 3, 5);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(190, 45);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.Black;
            btnProductos.Location = new Point(13, 70);
            btnProductos.Margin = new Padding(3, 5, 3, 5);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(190, 45);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnClientes
            // 
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.Black;
            btnClientes.Location = new Point(13, 125);
            btnClientes.Margin = new Padding(3, 5, 3, 5);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(190, 45);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Cursor = Cursors.Hand;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProveedores.ForeColor = Color.Black;
            btnProveedores.Location = new Point(13, 180);
            btnProveedores.Margin = new Padding(3, 5, 3, 5);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(190, 45);
            btnProveedores.TabIndex = 3;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.ForeColor = Color.Black;
            btnUsuarios.Location = new Point(13, 235);
            btnUsuarios.Margin = new Padding(3, 5, 3, 5);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(190, 45);
            btnUsuarios.TabIndex = 4;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = Color.Black;
            btnVentas.Location = new Point(13, 290);
            btnVentas.Margin = new Padding(3, 5, 3, 5);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(190, 45);
            btnVentas.TabIndex = 5;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Cursor = Cursors.Hand;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.Black;
            btnReportes.Location = new Point(13, 345);
            btnReportes.Margin = new Padding(3, 5, 3, 5);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(190, 45);
            btnReportes.TabIndex = 6;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(55, 63);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(117, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gestión agrícola";
            // 
            // lblNombreSistema
            // 
            lblNombreSistema.AutoSize = true;
            lblNombreSistema.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreSistema.ForeColor = Color.White;
            lblNombreSistema.Location = new Point(3, 0);
            lblNombreSistema.Name = "lblNombreSistema";
            lblNombreSistema.Size = new Size(224, 41);
            lblNombreSistema.TabIndex = 0;
            lblNombreSistema.Text = "AGROABURTO";
            // 
            // pnlContenido
            // 
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(230, 0);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(752, 603);
            pnlContenido.TabIndex = 1;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 603);
            Controls.Add(pnlContenido);
            Controls.Add(pnlMenu);
            Location = new Point(20, 25);
            MinimumSize = new Size(1000, 650);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgroAburto - Menú Principal";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            flpOpciones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Label lblNombreSistema;
        private FlowLayoutPanel flpOpciones;
        private Label lblSubtitulo;
        private Button btnInicio;
        private Button btnProductos;
        private Button btnClientes;
        private Button btnProveedores;
        private Button btnUsuarios;
        private Button btnVentas;
        private Button btnReportes;
        private Panel pnlContenido;
    }
}