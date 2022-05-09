using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Aspecto;

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
            DataTable table = new DataTable();
            try
            {
                AbrirConexion();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Connection = conexion;
                SqlDataAdapter DataAdapter = new SqlDataAdapter(cmd);
                DataAdapter.Fill(table);
            }
            catch (SqlException sql)
            {
                Calculos.MsgBox(sql.Message);
            }
            catch (Exception ex)
            {
                Calculos.MsgBox(ex.Message);
            }
            finally
            {
                CerrarConexion(); 
            }
            return table;
        }


        public int Cantidades(string query)
        {
            int cantidad = 0;
            try
            {
                AbrirConexion();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Connection = conexion;
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        cantidad = Convert.ToInt32(reader[0]);
                    }

                }
            }
            catch (SqlException sql)
            {
                Calculos.MsgBox(sql.Message);
            }
            catch (Exception ex)
            {
                Calculos.MsgBox(ex.Message);
            }
            finally
            {
                CerrarConexion();
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
