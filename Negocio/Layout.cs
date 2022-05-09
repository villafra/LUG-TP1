using Aspecto;
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

namespace Negocio
{
    public partial class frmLayout : Form
    {
        public Restó restó = new Restó();
        public frmLayout()
        {
            InitializeComponent();
            Formatear.FormatearDGV(dgvMesasLibres);
            Formatear.FormatearDGV(dgvMesasOcupadas);
            Formatear.FormatearDGV(dgvPedidosAbiertos);
            Formatear.FormatearDGV(dgvTotalPlatos);
            Formatear.FormatearDGV(dgvTotalBebidas);
            Formatear.FormatearDGV(dgvPedidosAbiertos);
            Formatear.FormatearDGV(dgvPlatosActivos);
            Formatear.FormatearDGV(dgvBebidasActivas);
        }

        private void frmLayout_Activated(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void frmLayout_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            try
            {
                string query = @"select count(Mesa.Estado) as [Mesas Libres] from Mesa where Estado='Disponible'";
                Calculos.RefreshGrilla(dgvMesasLibres, restó.ActualizarLayout(query));
                query = @"select count(Mesa.Estado) as [Mesas Ocupadas] from Mesa where Estado='Ocupada'";
                Calculos.RefreshGrilla(dgvMesasOcupadas, restó.ActualizarLayout(query));
                query = @"select count (Codigo_Pedido) as [Pedidos Abiertos] from Pedido where Activo=1";
                Calculos.RefreshGrilla(dgvPedidosAbiertos, restó.ActualizarLayout(query));
                query = @"select Plato.Nombre as [Platos En Pedidos], count(Plato.Nombre) as [Cantidad] 
            from Pedido_Plato inner join Plato on Pedido_Plato.Codigo_Plato=Plato.Codigo_Plato
            inner join Pedido on Pedido_Plato.Codigo_Pedido=Pedido.Codigo_Pedido where Pedido.Activo=1 group by Plato.Nombre";
                Calculos.RefreshGrilla(dgvPlatosActivos, restó.ActualizarLayout(query));
                query = @"select Bebida.Nombre as [Bebidas En Pedidos], count(Bebida.Nombre) as [Cantidad] 
            from Pedido_Bebida inner join Bebida on Pedido_Bebida.Codigo_Bebida=Bebida.Codigo_Bebida 
            inner join Pedido on Pedido_Bebida.Codigo_Pedido=Pedido.Codigo_Pedido where Pedido.Activo=1 group by Bebida.Nombre";
                Calculos.RefreshGrilla(dgvBebidasActivas, restó.ActualizarLayout(query));
                query = @"select sum(Plato.Costo) as [Total Platos] from Plato inner join Pedido_Plato 
            on plato.Codigo_Plato=Pedido_Plato.Codigo_Plato inner join Pedido on Pedido.Codigo_Pedido=Pedido_Plato.Codigo_Pedido 
            where Pedido.Activo=1";
                Calculos.RefreshGrilla(dgvTotalPlatos, restó.ActualizarLayout(query));
                query = @"select sum(Bebida.Precio) as [Total Bebidas] from Bebida inner join Pedido_Bebida
            on Bebida.Codigo_Bebida=Pedido_Bebida.Codigo_Bebida inner join Pedido on Pedido.Codigo_Pedido=Pedido_Bebida.Codigo_Pedido 
            where Pedido.Activo=1";
                Calculos.RefreshGrilla(dgvTotalBebidas, restó.ActualizarLayout(query));
                restó.DGVGenerico(dgvMesasLibres);
                restó.DGVGenerico(dgvMesasOcupadas);
                restó.DGVGenerico(dgvPedidosAbiertos);
                restó.DGVGenerico(dgvPlatosActivos);
                restó.DGVGenerico(dgvBebidasActivas);
                restó.DGVGenerico(dgvTotalPlatos);
                restó.DGVGenerico(dgvTotalBebidas);
            }
            catch(SqlException sql)
            {
                Calculos.MsgBox(sql.Message);
            }
            catch(Exception ex)
            {
                Calculos.MsgBox(ex.Message);
            }
        }
    }
}
    