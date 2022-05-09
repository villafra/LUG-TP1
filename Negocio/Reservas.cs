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
            Calculos.RefreshGrilla(dgvReservas, restó.QueryReservas());
            restó.DGVReservas(dgvReservas);
            Calculos.RefreshGrilla(dgvMesasDisponibles, restó.QueryMesasDisponibles());
            restó.DGVMesasDisponibles(dgvMesasDisponibles);
        }

        private void AsignarMesa()
        {
            try
            {
                Mesa mesa = (Mesa)dgvMesasDisponibles.SelectedRows[0].DataBoundItem;
                Reserva reserva = (Reserva)dgvReservas.SelectedRows[0].DataBoundItem;

               
                if (reserva.MesaReservada == null)
                {
                    if (reserva.CantidadDeComensales <= mesa.Capacidad)
                    {
                    reserva.AsignarMesa(mesa);
                    restó.AsignarMesaAReserva(reserva);
                    ActualizarGrid();
                    }
                    else
                    {
                        MessageBox.Show("La Cantidad de Comensales supera la\ncapacidad máxima de la mesa elegida");
                    }

                }
                else
                {
                    MessageBox.Show("La Reserva ya tiene una mesa asignada");
                }
 
            }
            catch(SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
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
            restó.DesasignarMesa(reserva);
            restó.CancelarReserva(reserva);
            ActualizarGrid();
        }

        private void btnEditarMesa_Click(object sender, EventArgs e)
        {
            Mesa mesa = (Mesa)dgvMesasDisponibles.SelectedRows[0].DataBoundItem;
            Reserva reserva = (Reserva)dgvReservas.SelectedRows[0].DataBoundItem;
            if (reserva.CantidadDeComensales <= mesa.Capacidad)
            {
                restó.DesasignarMesa(reserva);
                reserva.AsignarMesa(mesa);
                restó.AsignarMesaAReserva(reserva);
                ActualizarGrid();
            }
            else
            {
                MessageBox.Show("La Cantidad de Comensales supera la\ncapacidad máxima de la mesa elegida");
            }
        }

    }
}
