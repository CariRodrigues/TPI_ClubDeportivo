using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_ClubDeportivo.Datos.Infrastructure;

namespace TPI_ClubDeportivo.Presentacion.Formularios
{
    public partial class frmCarnet : Form
    {
        private string numeroCliente;
        public frmCarnet()
        {
            InitializeComponent();

        }

        private void frmCarnet_Load(object sender, EventArgs e)
        {


        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = ConexionDB.getInstancia().CrearConexion();
                query = "select * from cliente WHERE (TDocC = @TipoDocumento AND DocC = @DNI)";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                comando.Parameters.AddWithValue("@TipoDocumento", cboTipoDoc.SelectedItem.ToString());
                comando.Parameters.AddWithValue("@DNI", txtDni.Text);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtNombreCarnet.Text = reader["NombreC"].ToString();
                    txtApellidoCarnet.Text = reader["ApellidoC"].ToString();
                    txtCategoria.Text = (reader["EsSocio"].ToString() == "1") ? "Socio" : "No Socio";
                    if (reader["AptoFisico"].ToString() == "1")
                    {
                        txtAptoFisico.Text = "Entregado";
                    }
                    else 
                    {
                        txtAptoFisico.Text = "Adeuda";
                    }
                    txtFechaAlta.Text = Convert.ToDateTime(reader["FechaRegistro"]).ToString("dd/MM/yyy");
                    DateTime fechaAlta = Convert.ToDateTime(txtFechaAlta.Text);
                    DateTime fechaVencimiento = fechaAlta.AddMonths(6);
                    txtVencimiento.Text = fechaVencimiento.ToString("dd/MM/yyyy");
                }
                else
                {
                    MessageBox.Show("No se encontraron los datos del Cliente");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
