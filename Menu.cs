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

    }
}
