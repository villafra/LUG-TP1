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
using Cocina;

namespace Negocio
{
    public partial class frmPlatos : Form
    {
        public Restó restó = new Restó();
        public frmPlatos()
        {
            InitializeComponent();
            restó.FillTurnos();
            Formatear.FormatearDGV(dgvPlatos);
            Formatear.FormatearGRP(grpPlatos);
            Formatear.FormatearDGV(dgvPedidosConPlat);
            
            
        }

        private void btnNuevoPlato_Click(object sender, EventArgs e)
        {
            Plato nuevoPlato = new Plato(txtNombre.Text, ComboTipo.SelectedItem.ToString(), ComboClase.SelectedItem.ToString(), Convert.ToDecimal(txtCosto.Text));
            restó.ABMAction(restó.ABMPlato("Alta",nuevoPlato));
            ActualizarGrid();

        }

        private void frmPlatos_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
            
        }

        private void dgvPlatos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Plato VerPlato = (Plato)dgvPlatos.SelectedRows[0].DataBoundItem;
                txtCodigo.Text = VerPlato.Codigo.ToString();
                txtNombre.Text = VerPlato.Nombre;
                ComboTipo.Text = VerPlato.Tipo; 
                ComboClase.Text = VerPlato.Clase;
                txtCosto.Text = VerPlato.Costo.ToString();
                lblCantidad.Text= restó.PromedioPlatosEnPedido(VerPlato).ToString();
                dgvPedidosConPlat.DataSource = null;
                dgvPedidosConPlat.DataSource = restó.FillPedidosconPlato(VerPlato);
                restó.DGVPedidosXPlatos(dgvPedidosConPlat);
            }
            catch { }
        }

        private void btnModificarPlato_Click(object sender, EventArgs e)
        {
            Plato modificarPlato = new Plato(Int32.Parse(txtCodigo.Text),txtNombre.Text, ComboTipo.SelectedItem.ToString(), ComboClase.SelectedItem.ToString(), Convert.ToDecimal(txtCosto.Text));
            restó.ABMAction(restó.ABMPlato("Modificar", modificarPlato));
            ActualizarGrid();
        }

        private void btnEliminarPlato_Click(object sender, EventArgs e)
        {
            Plato eliminarPlato = new Plato(Int32.Parse(txtCodigo.Text), txtNombre.Text, ComboTipo.SelectedItem.ToString(), ComboClase.SelectedItem.ToString(), Convert.ToDecimal(txtCosto.Text));
            restó.ABMAction(restó.ABMPlato("Eliminar", eliminarPlato));
            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            dgvPlatos.DataSource = null;
            dgvPlatos.DataSource = restó.QueryPlatos();
            restó.DGVPlatos(dgvPlatos);
        }

        private void frmPlatos_Activated(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
    }
}
