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
using Negocio;

namespace LUG_TP1
{
    public partial class frmMenu : Form
    {
        Restó restó = new Restó();
        public frmMenu()
        {
            InitializeComponent();
            Formatear.FormatearForm(this, panelMenuIzq, this.Width, this.Height);
            frmBienvenida frm = new frmBienvenida();
            Formatear.AbrirNuevoForm(this, frm);
            frmLogin login = new frmLogin();
            login.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnLayout_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmLayout);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmLayout();
                Formatear.AbrirNuevoForm(this, frm);
            }
           
            
        }

        private void MesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmMesas);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmMesas();
                Formatear.AbrirNuevoForm(this, frm);
            }
        }

        private void MozosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmMozos);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmMozos();
                Formatear.AbrirNuevoForm(this, frm);
            }
        }

        private void TurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmTurnos);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmTurnos();
                
                Formatear.AbrirNuevoForm(this, frm);
            }
        }

      
        private void PlatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmPlatos);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmPlatos();

                Formatear.AbrirNuevoForm(this, frm);
            }
        }

        private void BebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmBebidas);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmBebidas();

                Formatear.AbrirNuevoForm(this, frm);
            }
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Reservas);
            if (frm != null)
            {
                
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new Reservas();
                Formatear.AbrirNuevoForm(this, frm);
            }
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Pedidos);
            if (frm != null)
            {

                frm.BringToFront();
                return;
            }
            else
            {
                frm = new Pedidos();
                Formatear.AbrirNuevoForm(this, frm);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmBienvenida);
            if (frm != null)
            {

                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmBienvenida();
                Formatear.AbrirNuevoForm(this, frm);
            }
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Informes);
            if (frm != null)
            {

                frm.BringToFront();
                return;
            }
            else
            {
                frm = new Informes();
                Formatear.AbrirNuevoForm(this, frm);
            }
        }
    }
}
