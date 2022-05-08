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
    public partial class frmBebidas : Form
    {
        public Restó restó = new Restó();
        public frmBebidas()
        {
            InitializeComponent();
            restó.FillTurnos();
            Formatear.FormatearDGV(dgvBebidas);
            Formatear.FormatearGRP(grpBebidas);
            
            
        }

        private void btnNuevaBebida_Click(object sender, EventArgs e)
        {
            ElegirABM("Alta");
            ActualizarGrid();

        }

        private void frmBebidas_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
            
        }

        private void dgvBebidas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBebidas.SelectedRows[0].Cells[2].Value.ToString() == "Alcoholica")
                {
                    Bebida_Alcoholica VerBebida = (Bebida_Alcoholica)dgvBebidas.SelectedRows[0].DataBoundItem;
                    txtCodigo.Text = VerBebida.Codigo.ToString();
                    txtNombre.Text = VerBebida.Nombre;
                    txtPrecio.Text = VerBebida.Precio.ToString();
                    txtABV.Text = VerBebida.GraduaciónAlcoholica.ToString();
                    comboTipo.Text = VerBebida.Tipo.ToString();
                    txtPresentacion.Text = VerBebida.Presentación;
                    lblCantidad.Text = VerBebida.Stock.ToString();
                    prgCantidad.Value = VerBebida.Stock;
                }
                else
                {
                    Bebida VerBebida = (Bebida)dgvBebidas.SelectedRows[0].DataBoundItem;
                    txtCodigo.Text = VerBebida.Codigo.ToString();
                    txtNombre.Text = VerBebida.Nombre;
                    txtPrecio.Text = VerBebida.Precio.ToString();
                    comboTipo.Text = VerBebida.Tipo.ToString();
                    txtPresentacion.Text = VerBebida.Presentación;
                    lblCantidad.Text = VerBebida.Stock.ToString();
                    txtABV.Text = "";
                    prgCantidad.Value = VerBebida.Stock;
                }
                

                
            }
            catch { }
        }

        private void btnModificarBebida_Click(object sender, EventArgs e)
        {
            ElegirABM("Modificar");
            ActualizarGrid();
        }

        private void btnEliminarBebida_Click(object sender, EventArgs e)
        {
            ElegirABM("Eliminar");
            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            dgvBebidas.DataSource = null;
            dgvBebidas.DataSource = restó.QueryBebidas();
            restó.DGVBebidas(dgvBebidas);
        }

        private void ElegirABM(string accion)
        {
            if (comboTipo.SelectedItem.ToString() != "Alcoholica")
            {
                Bebida bebida = new Bebida(Int32.Parse(txtCodigo.Text),txtNombre.Text, comboTipo.SelectedItem.ToString(), txtPresentacion.Text, Convert.ToDecimal(txtPrecio.Text), Int32.Parse(lblCantidad.Text));
                restó.ABMAction(restó.ABMBebida(accion, bebida));
            }
            else
            {
                Bebida_Alcoholica bebida = new Bebida_Alcoholica(Int32.Parse(txtCodigo.Text), txtNombre.Text, comboTipo.SelectedItem.ToString(), txtPresentacion.Text, Convert.ToDecimal(txtPrecio.Text), Int32.Parse(lblCantidad.Text), Convert.ToDouble(txtABV.Text));
                restó.ABMAction(restó.ABMBebidaAlcoholica(accion, bebida));
            }
        }

        private void frmBebidas_Activated(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
    }
}
