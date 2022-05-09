﻿using System;
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
            Formatear.FormatearDGV(dgvTurnos);
            Formatear.FormatearGRP(grpTurnos);
            Formatear.FormatearDGV(dgvMozosEnturno);
            
            
        }

        private void btnNuevoTurno_Click(object sender, EventArgs e)
        {
            Turno nuevoTurno = new Turno(txtNombreTurno.Text, dtpHoraInicio.Value, dtpHoraFin.Value);
            if (restó.ExisteTurno(nuevoTurno.NombreTurno))
            {
                restó.ABMAction(restó.ABMTurno("Alta", nuevoTurno));
                ActualizarGrid();
            }
            else
            {
                Calculos.MsgBox("El nombre del turno ya existe!");
            }

        }

        private void frmTurnos_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
            
        }

        private void dgvTurnos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Turno VerTurno = (Turno)dgvTurnos.SelectedRows[0].DataBoundItem;
                txtCodigo.Text = VerTurno.Codigo.ToString();
                txtNombreTurno.Text = VerTurno.NombreTurno;
                dtpHoraInicio.Value = VerTurno.HoraInicio;
                dtpHoraFin.Value = VerTurno.HoraFin;
                lblCantidad.Text = restó.CantidadMozosXTurno(VerTurno).ToString();
                prgCantidad.Value = restó.CantidadMozosXTurno(VerTurno);
                Calculos.RefreshGrilla(dgvMozosEnturno, restó.FillListadoMozosEnTurno(VerTurno));
                restó.DGVTurnosMozos(dgvMozosEnturno);
            }
            catch { }
        }

        private void btnModificarTurno_Click(object sender, EventArgs e)
        {
            Turno modificarTurno = new Turno(Convert.ToInt32(txtCodigo.Text), txtNombreTurno.Text, dtpHoraInicio.Value, dtpHoraFin.Value);
            if(Calculos.EstaSeguro("Modificar Turno", modificarTurno.Codigo, modificarTurno.NombreTurno))
            {
                restó.ABMAction(restó.ABMTurno("Modificar", modificarTurno));
                ActualizarGrid();
            }
        }

        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            Turno eliminarTurno = new Turno(Convert.ToInt32(txtCodigo.Text), txtNombreTurno.Text, dtpHoraInicio.Value, dtpHoraFin.Value);
            if(Calculos.EstaSeguro("Eliminar Turno", eliminarTurno.Codigo, eliminarTurno.NombreTurno))
            {
                restó.ABMAction(restó.ABMTurno("Eliminar", eliminarTurno));
                ActualizarGrid();
            }
        }

        private void ActualizarGrid()
        {
            Calculos.RefreshGrilla(dgvTurnos, restó.QueryTurnos());
            restó.DGVTurnos(dgvTurnos);
        }

        private void frmTurnos_Activated(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
    }
}
