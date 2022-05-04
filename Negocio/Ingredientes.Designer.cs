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
            this.dgvIngredientesPlato = new System.Windows.Forms.DataGridView();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNombreTurno = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.prgCantidad = new System.Windows.Forms.ProgressBar();
            this.lblCantidadPlatos = new System.Windows.Forms.Label();
            this.btnEliminarIngrediente = new System.Windows.Forms.Button();
            this.btnModificarIngrediente = new System.Windows.Forms.Button();
            this.btnNuevoIngrediente = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
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
            this.dgvIngredientes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnos_RowEnter);
            // 
            // grpIngredientes
            // 
            this.grpIngredientes.Controls.Add(this.radioButton2);
            this.grpIngredientes.Controls.Add(this.radioButton1);
            this.grpIngredientes.Controls.Add(this.label1);
            this.grpIngredientes.Controls.Add(this.textBox2);
            this.grpIngredientes.Controls.Add(this.textBox1);
            this.grpIngredientes.Controls.Add(this.lblStock);
            this.grpIngredientes.Controls.Add(this.lblTipo);
            this.grpIngredientes.Controls.Add(this.txtNombreTurno);
            this.grpIngredientes.Controls.Add(this.lblNombre);
            this.grpIngredientes.Controls.Add(this.txtCodigo);
            this.grpIngredientes.Controls.Add(this.lblCodigo);
            this.grpIngredientes.Controls.Add(this.lblCantidad);
            this.grpIngredientes.Controls.Add(this.prgCantidad);
            this.grpIngredientes.Controls.Add(this.lblCantidadPlatos);
            this.grpIngredientes.Location = new System.Drawing.Point(12, 313);
            this.grpIngredientes.Name = "grpIngredientes";
            this.grpIngredientes.Size = new System.Drawing.Size(826, 185);
            this.grpIngredientes.TabIndex = 1;
            this.grpIngredientes.TabStop = false;
            this.grpIngredientes.Text = "Turnos";
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
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(198, 117);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(41, 16);
            this.lblStock.TabIndex = 28;
            this.lblStock.Text = "Stock";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(24, 117);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 16);
            this.lblTipo.TabIndex = 26;
            this.lblTipo.Text = "Tipo";
            // 
            // txtNombreTurno
            // 
            this.txtNombreTurno.Location = new System.Drawing.Point(201, 63);
            this.txtNombreTurno.Name = "txtNombreTurno";
            this.txtNombreTurno.Size = new System.Drawing.Size(124, 22);
            this.txtNombreTurno.TabIndex = 14;
            this.txtNombreTurno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(198, 33);
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
            // lblCantidadPlatos
            // 
            this.lblCantidadPlatos.AutoSize = true;
            this.lblCantidadPlatos.Location = new System.Drawing.Point(626, 33);
            this.lblCantidadPlatos.Name = "lblCantidadPlatos";
            this.lblCantidadPlatos.Size = new System.Drawing.Size(104, 32);
            this.lblCantidadPlatos.TabIndex = 8;
            this.lblCantidadPlatos.Text = "Cantidad de \r\nMozos En Turno";
            this.lblCantidadPlatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnEliminarIngrediente.Click += new System.EventHandler(this.btnEliminarTurno_Click);
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
            this.btnModificarIngrediente.Click += new System.EventHandler(this.btnModificarTurno_Click);
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
            this.btnNuevoIngrediente.Click += new System.EventHandler(this.btnNuevoTurno_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 22);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(201, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 22);
            this.textBox2.TabIndex = 30;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Refrigeración";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(387, 125);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(40, 20);
            this.radioButton1.TabIndex = 32;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Si";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(471, 125);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 20);
            this.radioButton2.TabIndex = 33;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Label lblCantidadPlatos;
        private System.Windows.Forms.ProgressBar prgCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnNuevoIngrediente;
        private System.Windows.Forms.Button btnModificarIngrediente;
        private System.Windows.Forms.Button btnEliminarIngrediente;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombreTurno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.DataGridView dgvIngredientesPlato;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
    }
}