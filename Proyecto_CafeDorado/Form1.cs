using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using Proyecto_CafeDorado.Base_de_datos;
using System.Reflection;

namespace Proyecto_CafeDorado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string ValidarCredenciales(string usuario, string contrasena)
        {
            string rolUsuario = "";

            string query = "SELECT Rol FROM EMPLEADOS WHERE Codigo = @usuario AND Contraseña = @contrasena";

            using (SqlConnection conexion = new SqlConnection(DBHelper.cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null)
                        {
                            rolUsuario = resultado.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al validar credenciales: " + ex.Message);
                }
            }

            return rolUsuario;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBHelper Helpi = new DBHelper();
            bool conexionExitosa = Helpi.ProbarConexionSilenciosa();
            if (!conexionExitosa)
            {
                MessageBox.Show("No se pudo establecer conexión con la base de datos. La aplicación se cerrará.",
                                "Error Crítico",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                Application.Exit();
            }

            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // validar si el usuario realmente quiere salir
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            // minimizar la ventana
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            // validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(TxtUsuario.Text) || string.IsNullOrWhiteSpace(TxtContraseña.Text))
            {
                errorProvider1.SetError(TxtUsuario, "Ingrese su usuario");
                ProviderUsu.Text = "¡Casilla vacia! Ingrese su usuario";
                ProviderUsu.Visible = true;
                errorProvider1.SetError(TxtContraseña, "Ingrese su contraseña");
                ProviderContra.Text = "¡Casilla vacia! Ingrese su contraseña";
                ProviderContra.Visible = true;
                TxtUsuario.Clear();
                TxtContraseña.Clear();
                TxtUsuario.Focus();
                return;
            }
            // validar que la contraseña contenga al menos 8 caracteres, 1 letra mayuscula, 1 numero y 1 caracter especial
            if (TxtContraseña.Text.Length < 8 || !TxtContraseña.Text.Any(char.IsUpper) || !TxtContraseña.Text.Any(char.IsDigit) || !TxtContraseña.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                errorProvider1.SetError(TxtContraseña, "La contraseña debe contener al menos 8 caracteres, 1 letra mayúscula, 1 número y 1 carácter especial.");
                ProviderContra.Text = "La contraseña debe contener al menos 8 caracteres, 1 letra mayúscula, 1 número y 1 carácter especial.";
                ProviderContra.Visible = true;
                TxtUsuario.Clear();
                TxtContraseña.Clear();
                return;
            }

            if (!string.IsNullOrWhiteSpace(TxtUsuario.Text) && !string.IsNullOrWhiteSpace(TxtContraseña.Text))
            {
                string usuario = TxtUsuario.Text;
                string contraseña = TxtContraseña.Text;

                string rol = ValidarCredenciales(usuario, contraseña);
                if (!string.IsNullOrEmpty(rol))
                {
                    // El usuario y la contraseña son correctos, redirigir a la ventana principal
                    SesionActiva.Codigo = usuario;
                    SesionActiva.Rol = rol;
                    frmLoading loadingForm = new frmLoading();
                    loadingForm.Show(); 
                    this.Hide();

                }
                else
                {
                    errorProvider1.SetError(TxtUsuario, "Usuario o contraseña incorrectos");
                    ProviderUsu.Text = "Usuario o contraseña incorrectos";
                    ProviderUsu.Visible = true;
                    errorProvider1.SetError(TxtContraseña, "Usuario o contraseña incorrectos");
                    ProviderContra.Text = "Usuario o contraseña incorrectos";
                    ProviderContra.Visible = true;
                    TxtUsuario.Clear();
                    TxtContraseña.Clear();
                    TxtUsuario.Focus();
                }
            }
        }

        private void TxtUsuario_Click(object sender, EventArgs e)
        {
            TxtUsuario.Clear();
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (TxtUsuario.Text != UsuActual)
            { 
                errorProvider1.SetError(TxtUsuario, "");
                ProviderUsu.Visible = false;
            }
        }

        private string UsuActual = "";

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            UsuActual = TxtUsuario.Text;
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {            
        }

        private void TxtContraseña_Click(object sender, EventArgs e)
        {
            if (clickIcono)
            {
                clickIcono = false;
                return;
            }

            TxtContraseña.Clear();
        }

        private string ContraActual = "";

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            ContraActual = TxtContraseña.Text;
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (TxtContraseña.Text != ContraActual)
            {
                errorProvider1.SetError(TxtContraseña, "");
                ProviderContra.Visible = false;
            }
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // hacer que si el usuario presiona enter, se mueva al siguiente campo
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; 
                TxtContraseña.Focus();
                TxtContraseña.Clear();
            }
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnInicio.PerformClick();
            }
        }

        private bool clickIcono = false;

        private void TxtContraseña_IconRightClick(object sender, EventArgs e)
        {
            clickIcono = true;
            if (TxtContraseña.UseSystemPasswordChar)
            {
                TxtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                TxtContraseña.UseSystemPasswordChar = true;
            }
        }
    }
}
