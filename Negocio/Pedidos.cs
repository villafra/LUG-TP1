using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspecto;
using Estructura;
using Cocina;

namespace Negocio
{
    public partial class Pedidos : Form
    {
        public Restó restó = new Restó();
        public Pedidos()
        {
            InitializeComponent();
            Formatear.FormatearDGV(dgvPedidos);
            Formatear.FormatearDGV(dgvPlatos);
            Formatear.FormatearDGV(dgvBebidas);
            Formatear.FormatearControlExterno(label1);
            Formatear.FormatearControlExterno(label2);
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        public void ActualizarGrid()
        {
            Calculos.RefreshGrilla(dgvPedidos, restó.QueryPedidos());
            restó.DGVPedidos(dgvPedidos);
            
            
        }
        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            try
            {

                Pedido pedido = (Pedido)dgvPedidos.SelectedRows[0].DataBoundItem;
                DialogResult resultado = MessageBox.Show("Esta seguro que desea cancelar el pedido Nro: " + pedido.NumeroPedido + "\nCon un monto de: " + pedido.Monto.ToString(), "Restó", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    restó.CancelarPedido(pedido);
                }
            }
            catch
            {
                Calculos.MsgBox("No hay Pedidos Para Cancelar");
            }
            finally
            {
                ActualizarGrid();
}
        }

        private void btnCerrarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido pedido = (Pedido)dgvPedidos.SelectedRows[0].DataBoundItem;
                restó.CerrarPedido(pedido);
            }
            catch
            {
                Calculos.MsgBox("No hay Pedidos Para Cerrar");
            }
            finally
            {
                ActualizarGrid();
            }
            
        }

        private void Pedidos_Activated(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void dgvPedidos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Pedido pedido;
            try
            {
                pedido = (Pedido)dgvPedidos.SelectedRows[0].DataBoundItem;
                restó.DetallePlatos(pedido);
                dgvPlatos.DataSource = null;
                dgvPlatos.DataSource = pedido.Platos;
                restó.DGVPlatosPedidos(dgvPlatos);
                pedido.CalcularMonto();

            }
            catch { }
            try
            {
                pedido = (Pedido)dgvPedidos.SelectedRows[0].DataBoundItem;
                restó.DetalleBebidas(pedido);
                dgvBebidas.DataSource = null;
                dgvBebidas.DataSource = pedido.Bebidas;
                restó.DGVBebidasPedidos(dgvBebidas);
                pedido.CalcularMonto();
            }
            catch { }


            
        }
    }
}
