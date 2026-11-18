using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroAburto.Datos;

namespace AgroAburto.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        //Constructor frmprincipal
        public FrmPrincipal()
        {
            InitializeComponent();

            try
            {
                using (var conexion = ConexionBD.ObtenerConexion())
                {
                    MessageBox.Show(
                        "Conexión exitosa con la base de datos AgroAburto.",
                        "Conexión MySQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
