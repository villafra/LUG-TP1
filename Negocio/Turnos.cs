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
    public partial class frmTurnos : Form
    {
        public Restó restó = new Restó();
        public frmTurnos()
        {
            InitializeComponent();
            restó.FillTurnos();
            comboTurno.DataSource = restó.ListarTurnos();
            Formatear.FormatearDGV(dgvMozos);
            Formatear.FormatearGRP(grpMozos);
            
            
        }

        private void btnNuevaMozo_Click(object sender, EventArgs e)
        {
            Mozo NuevoMozo = new Mozo(long.Parse(txtDNI.Text), txtNombre.Text, txtApellido.Text, dtpFechaNacimiento.Value,restó.DevolverTurno(comboTurno.SelectedItem.ToString()));
            restó.ABMAction(restó.ABMMozo("Alta",NuevoMozo));
            ActualizarGrid();

        }

        private void frmMozos_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
            
        }

        private void dgvMozos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Mozo VerMozo = (Mozo)dgvMozos.SelectedRows[0].DataBoundItem;
                txtLegajo.Text = VerMozo.Legajo.ToString();
                txtDNI.Text = VerMozo.DNI.ToString();
                txtNombre.Text = VerMozo.Nombre.ToString();
                txtApellido.Text = VerMozo.Apellido.ToString();
                dtpFechaNacimiento.Value = VerMozo.FechaNacimiento;
                txtEdad.Text = VerMozo.DevolverEdad(VerMozo.FechaNacimiento).ToString();
                comboTurno.Text = VerMozo.turno.NombreTurno;
                lblPuntuación.Text = VerMozo.Puntuación.ToString();
                prgBaRanking.Value = Convert.ToInt32(VerMozo.Puntuación);
            }
            catch { }
        }

        private void btnModificarMozo_Click(object sender, EventArgs e)
        {
            Mozo ModificarMozo = new Mozo(Int32.Parse(txtLegajo.Text), long.Parse(txtDNI.Text), txtNombre.Text, txtApellido.Text, dtpFechaNacimiento.Value, restó.DevolverTurno(comboTurno.SelectedItem.ToString()),Int32.Parse(lblPuntuación.Text));
            restó.ABMAction(restó.ABMMozo("Modificar", ModificarMozo));
            ActualizarGrid();
        }

        private void btnEliminarMozo_Click(object sender, EventArgs e)
        {
            Mozo EliminarMozo = new Mozo(Int32.Parse(txtLegajo.Text), long.Parse(txtDNI.Text), txtNombre.Text, txtApellido.Text);
            restó.ABMAction(restó.ABMMozo("Eliminar", EliminarMozo));
            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            dgvMozos.DataSource = null;
            dgvMozos.DataSource = restó.QueryMozos();
            restó.DGVMozos(dgvMozos);
        }

       
    }
}
