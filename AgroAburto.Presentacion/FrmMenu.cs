using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroAburto.Presentacion
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            pnlMenu.BackColor = Utilidades.VerdePrincipal;
            this.BackColor = Utilidades.FondoPrincipal;


            Utilidades.ConfigurarBotonesMenu(
                flpOpciones,
                btnInicio,
                btnProductos,
                btnClientes,
                btnProveedores,
                btnUsuarios,
                btnVentas,
                btnReportes
            );

            //Configuracion del contenedor de opciones.
            flpOpciones.AutoSize = false;
            flpOpciones.AutoScroll = true;
            flpOpciones.WrapContents = false;
            flpOpciones.FlowDirection = FlowDirection.TopDown;

            //Ajustar el contenedor al espacio disponible.
            flpOpciones.Width = pnlMenu.ClientSize.Width;
            flpOpciones.Height = pnlMenu.ClientSize.Height - flpOpciones.Top;

            //Adaptar el contenedor al cambiar el tamaño de la ventana.
            pnlMenu.Resize += (s, e) =>
            {
                flpOpciones.Width = pnlMenu.ClientSize.Width;
                flpOpciones.Height = pnlMenu.ClientSize.Height - flpOpciones.Top;
            };
        }
        //Accion boton productos
        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (FrmProductos formulario = new FrmProductos())
            {
                formulario.ShowDialog();
            }

            this.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (FrmClientes formulario = new FrmClientes())
            {
                formulario.ShowDialog();
            }

            this.Show();
        }
    }
}
