using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Conexión
{
    public class Conectar
    {
        private SqlConnection conexion;

        public void AbrirConexion()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=(localdb)\server;Initial Catalog=TPN1-LUG;Integrated Security=True";
            conexion.Open();
        }

        public void CerrarConexion()
        {
            conexion.Close();
            conexion.Dispose();
            conexion = null;
            GC.Collect();
        }

        public DataTable DevolverListado(string query)
        {
            AbrirConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Connection = conexion;
            SqlDataAdapter DataAdapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            DataAdapter.Fill(table);
            CerrarConexion();
            return table;
        }


        public int Cantidades(string query)
        {
            AbrirConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Connection = conexion;
            SqlDataReader reader = cmd.ExecuteReader();
            int cantidad = 0;
            while (reader.Read())
            {
                cantidad = Convert.ToInt32(reader[0]);
            }
            return cantidad;
        }

        public bool EscribirDatos(string query)
        {
            try
            {
                AbrirConexion();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Connection = conexion;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CerrarConexion();
            }
            
        }
    }
}
