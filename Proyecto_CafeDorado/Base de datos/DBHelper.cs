using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CafeDorado
{
    internal class DBHelper
    {
        public static string cadenaConexion = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=CAFEDORADO; Integrated Security=True";

        public bool ProbarConexionSilenciosa()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falla de conexión con la base de datos de Café Dorado:\n\n" + ex.Message,
                                "Error Crítico",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable MostrarDatos(string consultaSQL)
        {
            DataTable tablaVirtual = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(consultaSQL, conexion))
                {
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
                    {
                        adaptador.Fill(tablaVirtual);
                    }
                }
            }
            return tablaVirtual;
        }

        public bool EjecutarComandoSeguro(string consultaSQL, Dictionary<string, object> parametros)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(consultaSQL, conexion))
                {
                    if (parametros != null)
                    {
                        foreach (var parametro in parametros)
                        {
                            cmd.Parameters.AddWithValue(parametro.Key, parametro.Value);
                        }
                    }

                    try
                    {
                        conexion.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al realizar operación: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
        public DataTable MostrarDatosComando(SqlCommand comandoVieneDeAfuera)
        {
            DataTable tablaVirtual = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    comandoVieneDeAfuera.Connection = conexion;

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comandoVieneDeAfuera))
                    {
                        adaptador.Fill(tablaVirtual);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tablaVirtual;
        }
    }
}
