using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CafeDorado
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int incremento = 1;

            if (pbr.Value < 100)
            {
                pbr.Value += incremento;
                porcentaje.Text = pbr.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                this.Hide();
                frmMenu FormMenu = new frmMenu();
                FormMenu.Show();
            }
        }
    }
}
