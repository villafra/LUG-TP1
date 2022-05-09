namespace LUG_TP1
{
    partial class Informes
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
            this.dgvTransacciones = new System.Windows.Forms.DataGridView();
            this.dgvPlatos = new System.Windows.Forms.DataGridView();
            this.dgvBebidas = new System.Windows.Forms.DataGridView();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.dgvMozos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMozos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransacciones
            // 
            this.dgvTransacciones.AllowUserToAddRows = false;
            this.dgvTransacciones.AllowUserToDeleteRows = false;
            this.dgvTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransacciones.Location = new System.Drawing.Point(174, 12);
            this.dgvTransacciones.Name = "dgvTransacciones";
            this.dgvTransacciones.ReadOnly = true;
            this.dgvTransacciones.RowHeadersWidth = 51;
            this.dgvTransacciones.RowTemplate.Height = 24;
            this.dgvTransacciones.Size = new System.Drawing.Size(512, 200);
            this.dgvTransacciones.TabIndex = 1;
            // 
            // dgvPlatos
            // 
            this.dgvPlatos.AllowUserToAddRows = false;
            this.dgvPlatos.AllowUserToDeleteRows = false;
            this.dgvPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatos.Location = new System.Drawing.Point(12, 397);
            this.dgvPlatos.Name = "dgvPlatos";
            this.dgvPlatos.ReadOnly = true;
            this.dgvPlatos.RowHeadersWidth = 51;
            this.dgvPlatos.RowTemplate.Height = 24;
            this.dgvPlatos.Size = new System.Drawing.Size(255, 111);
            this.dgvPlatos.TabIndex = 2;
            // 
            // dgvBebidas
            // 
            this.dgvBebidas.AllowUserToAddRows = false;
            this.dgvBebidas.AllowUserToDeleteRows = false;
            this.dgvBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBebidas.Location = new System.Drawing.Point(582, 397);
            this.dgvBebidas.Name = "dgvBebidas";
            this.dgvBebidas.ReadOnly = true;
            this.dgvBebidas.RowHeadersWidth = 51;
            this.dgvBebidas.RowTemplate.Height = 24;
            this.dgvBebidas.Size = new System.Drawing.Size(255, 111);
            this.dgvBebidas.TabIndex = 3;
            // 
            // dgvMesas
            // 
            this.dgvMesas.AllowUserToAddRows = false;
            this.dgvMesas.AllowUserToDeleteRows = false;
            this.dgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesas.Location = new System.Drawing.Point(296, 397);
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.ReadOnly = true;
            this.dgvMesas.RowHeadersWidth = 51;
            this.dgvMesas.RowTemplate.Height = 24;
            this.dgvMesas.Size = new System.Drawing.Size(255, 111);
            this.dgvMesas.TabIndex = 4;
            // 
            // dgvMozos
            // 
            this.dgvMozos.AllowUserToAddRows = false;
            this.dgvMozos.AllowUserToDeleteRows = false;
            this.dgvMozos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMozos.Location = new System.Drawing.Point(254, 249);
            this.dgvMozos.Name = "dgvMozos";
            this.dgvMozos.ReadOnly = true;
            this.dgvMozos.RowHeadersWidth = 51;
            this.dgvMozos.RowTemplate.Height = 24;
            this.dgvMozos.Size = new System.Drawing.Size(335, 111);
            this.dgvMozos.TabIndex = 5;
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 609);
            this.Controls.Add(this.dgvMozos);
            this.Controls.Add(this.dgvMesas);
            this.Controls.Add(this.dgvBebidas);
            this.Controls.Add(this.dgvPlatos);
            this.Controls.Add(this.dgvTransacciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Informes";
            this.Text = "Informes";
            this.Activated += new System.EventHandler(this.Informes_Activated);
            this.Load += new System.EventHandler(this.Informes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMozos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransacciones;
        private System.Windows.Forms.DataGridView dgvPlatos;
        private System.Windows.Forms.DataGridView dgvBebidas;
        private System.Windows.Forms.DataGridView dgvMesas;
        private System.Windows.Forms.DataGridView dgvMozos;
    }
}