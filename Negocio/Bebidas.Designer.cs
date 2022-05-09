namespace Negocio
{
    partial class frmBebidas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBebidas = new System.Windows.Forms.DataGridView();
            this.grpBebidas = new System.Windows.Forms.GroupBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.txtABV = new System.Windows.Forms.TextBox();
            this.lblABV = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPresentacion = new System.Windows.Forms.TextBox();
            this.lblPresentación = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.prgCantidad = new System.Windows.Forms.ProgressBar();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnAgregarStock = new System.Windows.Forms.Button();
            this.btnEliminarTurno = new System.Windows.Forms.Button();
            this.btnModificarTurno = new System.Windows.Forms.Button();
            this.btnNuevoTurno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).BeginInit();
            this.grpBebidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBebidas
            // 
            this.dgvBebidas.AllowUserToAddRows = false;
            this.dgvBebidas.AllowUserToDeleteRows = false;
            this.dgvBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBebidas.Location = new System.Drawing.Point(49, 53);
            this.dgvBebidas.Name = "dgvBebidas";
            this.dgvBebidas.ReadOnly = true;
            this.dgvBebidas.RowHeadersWidth = 51;
            this.dgvBebidas.RowTemplate.Height = 24;
            this.dgvBebidas.Size = new System.Drawing.Size(612, 254);
            this.dgvBebidas.TabIndex = 0;
            this.dgvBebidas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBebidas_RowEnter);
            // 
            // grpBebidas
            // 
            this.grpBebidas.Controls.Add(this.comboTipo);
            this.grpBebidas.Controls.Add(this.txtABV);
            this.grpBebidas.Controls.Add(this.lblABV);
            this.grpBebidas.Controls.Add(this.txtPrecio);
            this.grpBebidas.Controls.Add(this.lblPrecio);
            this.grpBebidas.Controls.Add(this.txtPresentacion);
            this.grpBebidas.Controls.Add(this.lblPresentación);
            this.grpBebidas.Controls.Add(this.lblTipo);
            this.grpBebidas.Controls.Add(this.txtNombre);
            this.grpBebidas.Controls.Add(this.lblNombre);
            this.grpBebidas.Controls.Add(this.txtCodigo);
            this.grpBebidas.Controls.Add(this.lblCodigo);
            this.grpBebidas.Controls.Add(this.lblCantidad);
            this.grpBebidas.Controls.Add(this.prgCantidad);
            this.grpBebidas.Controls.Add(this.lblStock);
            this.grpBebidas.Location = new System.Drawing.Point(12, 313);
            this.grpBebidas.Name = "grpBebidas";
            this.grpBebidas.Size = new System.Drawing.Size(826, 185);
            this.grpBebidas.TabIndex = 1;
            this.grpBebidas.TabStop = false;
            this.grpBebidas.Text = "Bebidas";
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Agua",
            "Gaseosa",
            "Preparada",
            "Energizante",
            "Alcoholica"});
            this.comboTipo.Location = new System.Drawing.Point(205, 146);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(194, 24);
            this.comboTipo.TabIndex = 37;
            // 
            // txtABV
            // 
            this.txtABV.Location = new System.Drawing.Point(441, 146);
            this.txtABV.Name = "txtABV";
            this.txtABV.Size = new System.Drawing.Size(123, 22);
            this.txtABV.TabIndex = 36;
            this.txtABV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtABV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtABV_KeyPress);
            // 
            // lblABV
            // 
            this.lblABV.AutoSize = true;
            this.lblABV.Location = new System.Drawing.Point(438, 116);
            this.lblABV.Name = "lblABV";
            this.lblABV.Size = new System.Drawing.Size(34, 16);
            this.lblABV.TabIndex = 35;
            this.lblABV.Text = "ABV";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(441, 63);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(123, 22);
            this.txtPrecio.TabIndex = 34;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(438, 33);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 33;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.Location = new System.Drawing.Point(27, 146);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Size = new System.Drawing.Size(124, 22);
            this.txtPresentacion.TabIndex = 32;
            this.txtPresentacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPresentación
            // 
            this.lblPresentación.AutoSize = true;
            this.lblPresentación.Location = new System.Drawing.Point(24, 116);
            this.lblPresentación.Name = "lblPresentación";
            this.lblPresentación.Size = new System.Drawing.Size(86, 16);
            this.lblPresentación.TabIndex = 31;
            this.lblPresentación.Text = "Presentación";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(202, 116);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 16);
            this.lblTipo.TabIndex = 29;
            this.lblTipo.Text = "Tipo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(161, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 22);
            this.txtNombre.TabIndex = 14;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(181, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(37, 63);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(99, 22);
            this.txtCodigo.TabIndex = 12;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(24, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(703, 90);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(14, 16);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "0";
            // 
            // prgCantidad
            // 
            this.prgCantidad.BackColor = System.Drawing.SystemColors.HotTrack;
            this.prgCantidad.Location = new System.Drawing.Point(648, 125);
            this.prgCantidad.Maximum = 1200;
            this.prgCantidad.Name = "prgCantidad";
            this.prgCantidad.Size = new System.Drawing.Size(157, 42);
            this.prgCantidad.Step = 1;
            this.prgCantidad.TabIndex = 9;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(669, 33);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(81, 16);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Stock Actual";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarStock
            // 
            this.btnAgregarStock.BackgroundImage = global::Negocio.Properties.Resources.Picture22;
            this.btnAgregarStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarStock.FlatAppearance.BorderSize = 0;
            this.btnAgregarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarStock.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarStock.ForeColor = System.Drawing.Color.Gold;
            this.btnAgregarStock.Location = new System.Drawing.Point(717, 214);
            this.btnAgregarStock.Name = "btnAgregarStock";
            this.btnAgregarStock.Size = new System.Drawing.Size(100, 93);
            this.btnAgregarStock.TabIndex = 5;
            this.btnAgregarStock.UseVisualStyleBackColor = true;
            this.btnAgregarStock.Click += new System.EventHandler(this.btnAgregarStock_Click);
            // 
            // btnEliminarTurno
            // 
            this.btnEliminarTurno.BackgroundImage = global::Negocio.Properties.Resources.Picture18;
            this.btnEliminarTurno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarTurno.FlatAppearance.BorderSize = 0;
            this.btnEliminarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTurno.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTurno.ForeColor = System.Drawing.Color.Gold;
            this.btnEliminarTurno.Location = new System.Drawing.Point(738, 504);
            this.btnEliminarTurno.Name = "btnEliminarTurno";
            this.btnEliminarTurno.Size = new System.Drawing.Size(100, 93);
            this.btnEliminarTurno.TabIndex = 4;
            this.btnEliminarTurno.UseVisualStyleBackColor = true;
            this.btnEliminarTurno.Click += new System.EventHandler(this.btnEliminarBebida_Click);
            // 
            // btnModificarTurno
            // 
            this.btnModificarTurno.BackgroundImage = global::Negocio.Properties.Resources.Picture17;
            this.btnModificarTurno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarTurno.FlatAppearance.BorderSize = 0;
            this.btnModificarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTurno.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTurno.ForeColor = System.Drawing.Color.Gold;
            this.btnModificarTurno.Location = new System.Drawing.Point(373, 504);
            this.btnModificarTurno.Name = "btnModificarTurno";
            this.btnModificarTurno.Size = new System.Drawing.Size(100, 93);
            this.btnModificarTurno.TabIndex = 3;
            this.btnModificarTurno.UseVisualStyleBackColor = true;
            this.btnModificarTurno.Click += new System.EventHandler(this.btnModificarBebida_Click);
            // 
            // btnNuevoTurno
            // 
            this.btnNuevoTurno.BackgroundImage = global::Negocio.Properties.Resources.espiritu;
            this.btnNuevoTurno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoTurno.FlatAppearance.BorderSize = 0;
            this.btnNuevoTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoTurno.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoTurno.ForeColor = System.Drawing.Color.Gold;
            this.btnNuevoTurno.Location = new System.Drawing.Point(12, 504);
            this.btnNuevoTurno.Name = "btnNuevoTurno";
            this.btnNuevoTurno.Size = new System.Drawing.Size(100, 93);
            this.btnNuevoTurno.TabIndex = 2;
            this.btnNuevoTurno.UseVisualStyleBackColor = true;
            this.btnNuevoTurno.Click += new System.EventHandler(this.btnNuevaBebida_Click);
            // 
            // frmBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 609);
            this.Controls.Add(this.btnAgregarStock);
            this.Controls.Add(this.btnEliminarTurno);
            this.Controls.Add(this.btnModificarTurno);
            this.Controls.Add(this.btnNuevoTurno);
            this.Controls.Add(this.grpBebidas);
            this.Controls.Add(this.dgvBebidas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBebidas";
            this.Text = "Mesas";
            this.Activated += new System.EventHandler(this.frmBebidas_Activated);
            this.Load += new System.EventHandler(this.frmBebidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).EndInit();
            this.grpBebidas.ResumeLayout(false);
            this.grpBebidas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBebidas;
        private System.Windows.Forms.GroupBox grpBebidas;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.ProgressBar prgCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnNuevoTurno;
        private System.Windows.Forms.Button btnModificarTurno;
        private System.Windows.Forms.Button btnEliminarTurno;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtABV;
        private System.Windows.Forms.Label lblABV;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPresentacion;
        private System.Windows.Forms.Label lblPresentación;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Button btnAgregarStock;
    }
}