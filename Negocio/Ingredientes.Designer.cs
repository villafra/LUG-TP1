namespace Negocio
{
    partial class frmIngredientes
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
            this.dgvIngredientes = new System.Windows.Forms.DataGridView();
            this.grpIngredientes = new System.Windows.Forms.GroupBox();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.lblRefrigeracion = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.prgCantidad = new System.Windows.Forms.ProgressBar();
            this.lblCantidadIng = new System.Windows.Forms.Label();
            this.dgvIngredientesPlato = new System.Windows.Forms.DataGridView();
            this.btnEliminarIngrediente = new System.Windows.Forms.Button();
            this.btnModificarIngrediente = new System.Windows.Forms.Button();
            this.btnNuevoIngrediente = new System.Windows.Forms.Button();
            this.txtUM = new System.Windows.Forms.TextBox();
            this.lblUM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            this.grpIngredientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientesPlato)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.AllowUserToAddRows = false;
            this.dgvIngredientes.AllowUserToDeleteRows = false;
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientes.Location = new System.Drawing.Point(17, 53);
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.ReadOnly = true;
            this.dgvIngredientes.RowHeadersWidth = 51;
            this.dgvIngredientes.RowTemplate.Height = 24;
            this.dgvIngredientes.Size = new System.Drawing.Size(512, 254);
            this.dgvIngredientes.TabIndex = 0;
            this.dgvIngredientes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredientes_RowEnter);
            // 
            // grpIngredientes
            // 
            this.grpIngredientes.Controls.Add(this.txtUM);
            this.grpIngredientes.Controls.Add(this.lblUM);
            this.grpIngredientes.Controls.Add(this.rdbSi);
            this.grpIngredientes.Controls.Add(this.lblRefrigeracion);
            this.grpIngredientes.Controls.Add(this.txtStock);
            this.grpIngredientes.Controls.Add(this.txtTipo);
            this.grpIngredientes.Controls.Add(this.lblStock);
            this.grpIngredientes.Controls.Add(this.lblTipo);
            this.grpIngredientes.Controls.Add(this.txtNombre);
            this.grpIngredientes.Controls.Add(this.lblNombre);
            this.grpIngredientes.Controls.Add(this.txtCodigo);
            this.grpIngredientes.Controls.Add(this.lblCodigo);
            this.grpIngredientes.Controls.Add(this.lblCantidad);
            this.grpIngredientes.Controls.Add(this.prgCantidad);
            this.grpIngredientes.Controls.Add(this.lblCantidadIng);
            this.grpIngredientes.Location = new System.Drawing.Point(12, 313);
            this.grpIngredientes.Name = "grpIngredientes";
            this.grpIngredientes.Size = new System.Drawing.Size(826, 185);
            this.grpIngredientes.TabIndex = 1;
            this.grpIngredientes.TabStop = false;
            this.grpIngredientes.Text = "Turnos";
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Location = new System.Drawing.Point(514, 77);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(40, 20);
            this.rdbSi.TabIndex = 32;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "Si";
            this.rdbSi.UseVisualStyleBackColor = true;
            // 
            // lblRefrigeracion
            // 
            this.lblRefrigeracion.AutoSize = true;
            this.lblRefrigeracion.Location = new System.Drawing.Point(476, 33);
            this.lblRefrigeracion.Name = "lblRefrigeracion";
            this.lblRefrigeracion.Size = new System.Drawing.Size(88, 16);
            this.lblRefrigeracion.TabIndex = 31;
            this.lblRefrigeracion.Text = "Refrigeración";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(361, 145);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(102, 22);
            this.txtStock.TabIndex = 30;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(27, 145);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(131, 22);
            this.txtTipo.TabIndex = 29;
            this.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(381, 117);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(41, 16);
            this.lblStock.TabIndex = 28;
            this.lblStock.Text = "Stock";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(34, 117);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 16);
            this.lblTipo.TabIndex = 26;
            this.lblTipo.Text = "Tipo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(201, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(181, 22);
            this.txtNombre.TabIndex = 14;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(211, 33);
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
            this.lblCodigo.Location = new System.Drawing.Point(34, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(696, 91);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(14, 16);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "0";
            // 
            // prgCantidad
            // 
            this.prgCantidad.BackColor = System.Drawing.SystemColors.HotTrack;
            this.prgCantidad.Location = new System.Drawing.Point(629, 125);
            this.prgCantidad.Maximum = 10;
            this.prgCantidad.Name = "prgCantidad";
            this.prgCantidad.Size = new System.Drawing.Size(157, 42);
            this.prgCantidad.Step = 1;
            this.prgCantidad.TabIndex = 9;
            // 
            // lblCantidadIng
            // 
            this.lblCantidadIng.AutoSize = true;
            this.lblCantidadIng.Location = new System.Drawing.Point(626, 33);
            this.lblCantidadIng.Name = "lblCantidadIng";
            this.lblCantidadIng.Size = new System.Drawing.Size(128, 32);
            this.lblCantidadIng.TabIndex = 8;
            this.lblCantidadIng.Text = "Cantidad de Platos \r\ncon este Ingrediente";
            this.lblCantidadIng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvIngredientesPlato
            // 
            this.dgvIngredientesPlato.AllowUserToAddRows = false;
            this.dgvIngredientesPlato.AllowUserToDeleteRows = false;
            this.dgvIngredientesPlato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientesPlato.Location = new System.Drawing.Point(551, 53);
            this.dgvIngredientesPlato.Name = "dgvIngredientesPlato";
            this.dgvIngredientesPlato.ReadOnly = true;
            this.dgvIngredientesPlato.RowHeadersWidth = 51;
            this.dgvIngredientesPlato.RowTemplate.Height = 24;
            this.dgvIngredientesPlato.Size = new System.Drawing.Size(284, 254);
            this.dgvIngredientesPlato.TabIndex = 5;
            // 
            // btnEliminarIngrediente
            // 
            this.btnEliminarIngrediente.BackgroundImage = global::Negocio.Properties.Resources.Picture14;
            this.btnEliminarIngrediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarIngrediente.FlatAppearance.BorderSize = 0;
            this.btnEliminarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarIngrediente.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarIngrediente.ForeColor = System.Drawing.Color.Gold;
            this.btnEliminarIngrediente.Location = new System.Drawing.Point(738, 504);
            this.btnEliminarIngrediente.Name = "btnEliminarIngrediente";
            this.btnEliminarIngrediente.Size = new System.Drawing.Size(100, 93);
            this.btnEliminarIngrediente.TabIndex = 4;
            this.btnEliminarIngrediente.UseVisualStyleBackColor = true;
            this.btnEliminarIngrediente.Click += new System.EventHandler(this.btnEliminarIngrediente_Click);
            // 
            // btnModificarIngrediente
            // 
            this.btnModificarIngrediente.BackgroundImage = global::Negocio.Properties.Resources.Picture13;
            this.btnModificarIngrediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarIngrediente.FlatAppearance.BorderSize = 0;
            this.btnModificarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarIngrediente.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarIngrediente.ForeColor = System.Drawing.Color.Gold;
            this.btnModificarIngrediente.Location = new System.Drawing.Point(373, 504);
            this.btnModificarIngrediente.Name = "btnModificarIngrediente";
            this.btnModificarIngrediente.Size = new System.Drawing.Size(100, 93);
            this.btnModificarIngrediente.TabIndex = 3;
            this.btnModificarIngrediente.UseVisualStyleBackColor = true;
            this.btnModificarIngrediente.Click += new System.EventHandler(this.btnModificarIngrediente_Click);
            // 
            // btnNuevoIngrediente
            // 
            this.btnNuevoIngrediente.BackgroundImage = global::Negocio.Properties.Resources.agua;
            this.btnNuevoIngrediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoIngrediente.FlatAppearance.BorderSize = 0;
            this.btnNuevoIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoIngrediente.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoIngrediente.ForeColor = System.Drawing.Color.Gold;
            this.btnNuevoIngrediente.Location = new System.Drawing.Point(12, 504);
            this.btnNuevoIngrediente.Name = "btnNuevoIngrediente";
            this.btnNuevoIngrediente.Size = new System.Drawing.Size(100, 93);
            this.btnNuevoIngrediente.TabIndex = 2;
            this.btnNuevoIngrediente.UseVisualStyleBackColor = true;
            this.btnNuevoIngrediente.Click += new System.EventHandler(this.btnNuevoIngrediente_Click);
            // 
            // txtUM
            // 
            this.txtUM.Location = new System.Drawing.Point(214, 145);
            this.txtUM.Name = "txtUM";
            this.txtUM.Size = new System.Drawing.Size(102, 22);
            this.txtUM.TabIndex = 34;
            this.txtUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUM
            // 
            this.lblUM.AutoSize = true;
            this.lblUM.Location = new System.Drawing.Point(198, 117);
            this.lblUM.Name = "lblUM";
            this.lblUM.Size = new System.Drawing.Size(100, 16);
            this.lblUM.TabIndex = 33;
            this.lblUM.Text = "Unidad Medida";
            // 
            // frmIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 609);
            this.Controls.Add(this.btnEliminarIngrediente);
            this.Controls.Add(this.btnModificarIngrediente);
            this.Controls.Add(this.dgvIngredientesPlato);
            this.Controls.Add(this.btnNuevoIngrediente);
            this.Controls.Add(this.grpIngredientes);
            this.Controls.Add(this.dgvIngredientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIngredientes";
            this.Text = "Mesas";
            this.Load += new System.EventHandler(this.frmTurnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
            this.grpIngredientes.ResumeLayout(false);
            this.grpIngredientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientesPlato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIngredientes;
        private System.Windows.Forms.GroupBox grpIngredientes;
        private System.Windows.Forms.Label lblCantidadIng;
        private System.Windows.Forms.ProgressBar prgCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnNuevoIngrediente;
        private System.Windows.Forms.Button btnModificarIngrediente;
        private System.Windows.Forms.Button btnEliminarIngrediente;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.DataGridView dgvIngredientesPlato;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.Label lblRefrigeracion;
        private System.Windows.Forms.TextBox txtUM;
        private System.Windows.Forms.Label lblUM;
    }
}