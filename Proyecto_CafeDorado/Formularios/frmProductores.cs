using Proyecto_CafeDorado.Base_de_datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CafeDorado.Formularios
{
    public partial class frmProductores : Form
    {
        public frmProductores()
        {
            InitializeComponent();
            guna2VScrollBar1.BindingContainer = guna2Panel1;
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void Actualizartabla()
        {
            DBHelper dBHelper = new DBHelper();
            dgvProductores.DataSource = dBHelper.MostrarDatos("SELECT * FROM PRODUCTORES");
        }

        private void frmProductores_Load(object sender, EventArgs e)
        {
            Actualizartabla();
            if (SesionActiva.Rol == "Administrador")
            {
                btnAgregar.Visible = true;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }
    }
}
