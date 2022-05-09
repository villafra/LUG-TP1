using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspecto;
using Conexión;

namespace LUG_TP1
{
    public partial class frmLogin : Form
    {
        Conectar conexión = new Conectar();
        Login login;
        public frmLogin()
        {
            InitializeComponent();
            Formatear.FormatearLogin(this, grpLogin, this.Width, this.Height);
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                QueryPass();
                if (login != null)
                {
                    string resultado = login.ValidarIngreso(txtUsuario.Text, txtPass.Text);
                    MessageBox.Show(resultado, "Acceso al Sistema", MessageBoxButtons.OK);

                    if (resultado == "Acceso Concedido")
                    {
                        this.Close();
                    }

                }
                else
                {
                    Calculos.MsgBox("El usuario ingresado\nno está registrado.");
                }
            }
            catch(SqlException sql)
            {
                Calculos.MsgBox(sql.Message);
            }
            catch (Exception ex)
            {
                Calculos.MsgBox(ex.Message);
            }

        }
        private void QueryPass()
        {
            string query = @"select * from Usuarios where Usuario = '" + txtUsuario.Text + "'";

            foreach (DataRow row in conexión.DevolverListado(query).Rows)
            {
                login  = new Login(Convert.ToInt32(row[0].ToString()), row[1].ToString(), row[2].ToString());
            }
         }
    }
}
