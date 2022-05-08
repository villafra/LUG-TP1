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
using Conexión;

namespace Negocio
{
    public partial class frmMesas : Form
    {
        Restó restó = new Restó();
       

        public frmMesas()
        {
            InitializeComponent();
            Formatear.FormatearDGV(dgvMesas);
            Formatear.FormatearGRP(grpMesas);
            
        }

        private void btnNuevaMesa_Click(object sender, EventArgs e)
        {
            Mesa NuevaMesa = new Mesa(Int32.Parse(txtNumeroMesa.Text), Int32.Parse(txtCapacidad.Text), VerChecked(rdbDisponible, RdbOcupada, rdbReservada).Text, 0);
            restó.ABMAction( restó.ABMMesa("Alta", NuevaMesa));
            ActualizarGrid();

        }

        private void frmMesas_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void dgvMesas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Mesa VerMesa = (Mesa)dgvMesas.SelectedRows[0].DataBoundItem;
                txtCapacidad.Text = VerMesa.Capacidad.ToString();
                txtNumeroMesa.Text = VerMesa.NroDeMesa.ToString();
                txtCodigoMesa.Text = VerMesa.Codigo.ToString();
                if (VerMesa.Estado == "Disponible")
                {
                    rdbDisponible.Checked = true;
                }
                else if (VerMesa.Estado == "Ocupada")
                {
                    RdbOcupada.Checked = true;
                }
                else
                {
                    rdbDisponible.Checked = true;
                }
                double porcentaje = Math.Round((double)VerMesa.CantidadComensales / VerMesa.Capacidad *100,1);
                lblPorcentaje.Text = Convert.ToString(porcentaje) + "%";
                prgBarOcupación.Maximum = VerMesa.Capacidad;
                prgBarOcupación.Value = VerMesa.CantidadComensales;
            }
            catch { }
        }

        private void btnModificarMesa_Click(object sender, EventArgs e)
        {
            Mesa ModificarMesa = new Mesa(Int32.Parse(txtCodigoMesa.Text), Int32.Parse(txtNumeroMesa.Text), Int32.Parse(txtCapacidad.Text), VerChecked(rdbDisponible, RdbOcupada, rdbReservada).Text);
            restó.ABMAction(restó.ABMMesa("Modificar", ModificarMesa));
            ActualizarGrid();
        }

        private void btnEliminarMesa_Click(object sender, EventArgs e)
        {
            Mesa EliminarMesa = new Mesa(Int32.Parse(txtCodigoMesa.Text), Int32.Parse(txtNumeroMesa.Text), Int32.Parse(txtCapacidad.Text), VerChecked(rdbDisponible, RdbOcupada, rdbReservada).Text);
            restó.ABMAction(restó.ABMMesa("Eliminar", EliminarMesa));
            ActualizarGrid();
        }

        private RadioButton VerChecked(RadioButton rdbDisponible, RadioButton RdbOcupada, RadioButton rdbReservada)
        {
            if (rdbDisponible.Checked == true)
            {
                return rdbDisponible;
            }
            else if (RdbOcupada.Checked == true)
            {
                return RdbOcupada;
            }
            else
            {
                return rdbReservada;
            }
        }
        private void ActualizarGrid()
        {
            dgvMesas.DataSource = null;
            dgvMesas.DataSource = restó.QueryMesas();
            restó.DGVMesas(dgvMesas);
        }

        private void frmMesas_Activated(object sender, EventArgs e)
        {
            dgvMesas.DataSource = null;
            dgvMesas.DataSource = restó.QueryMesas();
            restó.DGVMesas(dgvMesas);
        }
    }
}
