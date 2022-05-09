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
using Negocio;

namespace LUG_TP1
{
    public partial class Informes : Form
    {
        Restó restó = new Restó();
        public Informes()
        {
            InitializeComponent();
            Formatear.FormatearDGV(dgvBebidas);
            Formatear.FormatearDGV(dgvMesas);
            Formatear.FormatearDGV(dgvMozos);
            Formatear.FormatearDGV(dgvPlatos);
            Formatear.FormatearDGV(dgvTransacciones);
        }

        private void Informes_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            try
            {
                string query = @"select Mesa.Nro_Mesa, count (Mesa.Nro_Mesa) as 
                [Ranking Mesas] from Transacciones inner join Mesa on Transacciones.Codigo_Mesa=Mesa.Nro_Mesa 
                group by Mesa.Nro_Mesa";
                Calculos.RefreshGrilla(dgvMesas, restó.ActualizarLayout(query));
                query = @"select Mozo.Nombre, Mozo.Apellido, count (Mozo.Legajo) as [Ranking Mozo] from 
                Transacciones inner join Mozo on Transacciones.Codigo_Mozo=mozo.Legajo group by Mozo.Nombre, 
                Mozo.Apellido";
                Calculos.RefreshGrilla(dgvMozos, restó.ActualizarLayout(query));
                query = @"select [ID transaccion],FechayHora,Monto from Transacciones";
                Calculos.RefreshGrilla(dgvTransacciones, restó.ActualizarLayout(query));
                query = @"select Plato.Nombre, count (Plato.Nombre) as [Ranking Plato] from Transacciones 
                inner join Pedido on Transacciones.Codigo_Pedido=Pedido.Codigo_Pedido inner join Pedido_Plato 
                on Pedido_Plato.Codigo_Pedido=Pedido.Codigo_Pedido inner join Plato on 
                Pedido_Plato.Codigo_Plato=plato.Codigo_Plato group by Plato.Nombre";
                Calculos.RefreshGrilla(dgvPlatos, restó.ActualizarLayout(query));
                query = @"select Bebida.Nombre, count (Bebida.Nombre) as [Ranking Bebida] from Transacciones 
                inner join Pedido on Transacciones.Codigo_Pedido=Pedido.Codigo_Pedido inner join Pedido_Bebida 
                on Pedido_Bebida.Codigo_Pedido=Pedido.Codigo_Pedido inner join Bebida on 
                Pedido_Bebida.Codigo_Bebida=Bebida.Codigo_Bebida group by Bebida.Nombre";
                Calculos.RefreshGrilla(dgvBebidas, restó.ActualizarLayout(query));
                
                restó.DGVGenerico(dgvMesas);
                restó.DGVGenerico(dgvMozos);
                restó.DGVGenerico(dgvBebidas);
                restó.DGVGenerico(dgvPlatos);
                restó.DGVGenerico(dgvTransacciones);
            }
            catch (SqlException sql)
            {
                Calculos.MsgBox(sql.Message);
            }
            catch (Exception ex)
            {
                Calculos.MsgBox(ex.Message);
            }
        }

        private void Informes_Activated(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
    }
}
