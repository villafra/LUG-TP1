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
using Cocina;

namespace Negocio
{
    public partial class frmIngredientes : Form
    {
        public Restó restó = new Restó();
        public frmIngredientes()
        {
            InitializeComponent();
            Formatear.FormatearDGV(dgvIngredientes);
            Formatear.FormatearGRP(grpIngredientes);
            Formatear.FormatearDGV(dgvIngredientesPlato);
            
            
        }

        private void btnNuevoIngrediente_Click(object sender, EventArgs e)
        {
            Ingrediente nuevoIngrediente = new Ingrediente(txtNombre.Text, txtTipo.Text, Refrigeracion(rdbSi), txtUM.Text, Int32.Parse(txtStock.Text));
            restó.ABMAction(restó.ABMIngrediente("Alta",nuevoIngrediente));
            ActualizarGrid();

        }

        private void frmTurnos_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
            
        }

        private void dgvIngredientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Ingrediente VerIngrediente = (Ingrediente)dgvIngredientes.SelectedRows[0].DataBoundItem;
                txtCodigo.Text = VerIngrediente.Codigo.ToString();
                txtNombre.Text = VerIngrediente.Nombre;
                txtTipo.Text = VerIngrediente.Tipo;
                txtUM.Text = VerIngrediente.UnidadMedida;
                txtStock.Text = VerIngrediente.Stock.ToString();
            }
            catch { }
        }

        private void btnModificarIngrediente_Click(object sender, EventArgs e)
        {
            Ingrediente modificarIngrediente = new Ingrediente(Int32.Parse(txtCodigo.Text), txtNombre.Text, txtTipo.Text, Refrigeracion(rdbSi), txtUM.Text, Int32.Parse(txtStock.Text));
            restó.ABMAction(restó.ABMIngrediente("Modificar", modificarIngrediente));
            ActualizarGrid();
        }

        private void btnEliminarIngrediente_Click(object sender, EventArgs e)
        {
            Ingrediente eliminarIngrediente = new Ingrediente(Int32.Parse(txtCodigo.Text), txtNombre.Text, txtTipo.Text, Refrigeracion(rdbSi), txtUM.Text, Int32.Parse(txtStock.Text));
            restó.ABMAction(restó.ABMIngrediente("Eliminar", eliminarIngrediente));
            ActualizarGrid();
        }

        public bool Refrigeracion(RadioButton si)
        {
            if (si.Checked) return true;
            else return false;
        }
        private void ActualizarGrid()
        {
            dgvIngredientes.DataSource = null;
            dgvIngredientes.DataSource = restó.QueryIngredientes();
            restó.DGVIngredientes(dgvIngredientes);
        }

       
    }
}
