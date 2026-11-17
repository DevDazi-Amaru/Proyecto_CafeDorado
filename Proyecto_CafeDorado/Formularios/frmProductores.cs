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
                btnAñadir.Visible = true;
            }
            txtAltitud.Items.Insert(0, "Todas las altitudes");
            txtCategoria.Items.Insert(0, "Todas las categorías");
            txtEstado.Items.Insert(0, "Activo/Inactivo");
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtroquery = "SELECT * FROM PRODUCTORES WHERE 1=1";


            if (!string.IsNullOrEmpty(txtFiltroTexto.Text))
            {
                filtroquery += " AND (Nombre_completo LIKE '%' + @filtrotexto + '%' OR Cedula LIKE '%' + @filtrotexto + '%' OR Nombre_Finca LIKE '%' + @filtrotexto + '%' OR Correo LIKE '%' + @filtrotexto + '%' OR Ubicacion LIKE '%' + @filtrotexto + '%')";
            }
            if (!string.IsNullOrEmpty(txtFiltroNumero.Text))
            {
                filtroquery += " AND Cedula LIKE '%' + @filtronumero + '%'";
            }
            if (txtAltitud.SelectedIndex > 0)
            {
                switch (txtAltitud.SelectedIndex)
                {
                    case 1:
                        filtroquery += " AND Altitud < 800";
                        break;
                    case 2:
                        filtroquery += " AND Altitud BETWEEN 800 AND 1200";
                        break;
                    case 3:
                        filtroquery += " AND Altitud BETWEEN 1201 AND 1500";
                        break;
                    case 4:
                        filtroquery += " AND Altitud > 1500";
                        break;
                }
            }
            if (txtCategoria.SelectedIndex > 0)
            {
                filtroquery += " AND Categoria = @filtrocategoria";
            }
            if (txtEstado.SelectedIndex > 0)
            {
                filtroquery += " AND Estado = @filtroestado";
            }

        }
    }
}
