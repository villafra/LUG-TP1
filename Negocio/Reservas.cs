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

namespace Negocio
{
    public partial class Reservas : Form
    {
        public Restó restó = new Restó();
        public Reservas()
        {
            InitializeComponent();
            Formatear.FormatearDGV(dgvReservas);
            Formatear.FormatearDGV(dgvMesasDisponibles);
            Formatear.FormatearControlExterno(label1);
            Formatear.FormatearControlExterno(label2);
            Formatear.FormatearControlExterno(label3);
        }

        private void Reservas_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        public void ActualizarGrid()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = restó.QueryReservas();
            restó.DGVReservas(dgvReservas);
            dgvMesasDisponibles.DataSource = null;
            dgvMesasDisponibles.DataSource = restó.QueryMesasDisponibles();
            restó.DGVMesasDisponibles(dgvMesasDisponibles);
        }

        private void AsignarMesa()
        {
            Mesa mesa = (Mesa)dgvMesasDisponibles.SelectedRows[0].DataBoundItem;
            Reserva reserva = (Reserva)dgvReservas.SelectedRows[0].DataBoundItem;
            reserva.AsignarMesa(mesa);
            restó.AsignarMesaAReserva(reserva);
            ActualizarGrid();
          
        }

        private void btnAsignarMesa_Click(object sender, EventArgs e)
        {
            AsignarMesa();
            ActualizarGrid();
        }

        private void Reservas_Activated(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            Reserva reserva = (Reserva)dgvReservas.SelectedRows[0].DataBoundItem;
            restó.CancelarReserva(reserva);
            ActualizarGrid();
        }

        private void btnEditarMesa_Click(object sender, EventArgs e)
        {
            Mesa mesa = (Mesa)dgvMesasDisponibles.SelectedRows[0].DataBoundItem;
            Reserva reserva = (Reserva)dgvReservas.SelectedRows[0].DataBoundItem;
            restó.DesasignarMesa(reserva);
            reserva.AsignarMesa(mesa);
            restó.AsignarMesaAReserva(reserva);
            ActualizarGrid();
        }
    }
}
