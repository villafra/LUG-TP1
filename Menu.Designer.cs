namespace LUG_TP1
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.ListaImagenes = new System.Windows.Forms.ImageList(this.components);
            this.panelMenuIzq = new System.Windows.Forms.Panel();
            this.mStripMenu = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MozosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IngredientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BebidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.picboxPanel = new System.Windows.Forms.PictureBox();
            this.btnLayout = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.panelMenuIzq.SuspendLayout();
            this.mStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaImagenes
            // 
            this.ListaImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListaImagenes.ImageStream")));
            this.ListaImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.ListaImagenes.Images.SetKeyName(0, "bebidas.png");
            this.ListaImagenes.Images.SetKeyName(1, "cocina.png");
            this.ListaImagenes.Images.SetKeyName(2, "reserva.png");
            this.ListaImagenes.Images.SetKeyName(3, "logout.png");
            this.ListaImagenes.Images.SetKeyName(4, "pedido-en-linea.png");
            // 
            // panelMenuIzq
            // 
            this.panelMenuIzq.Controls.Add(this.btnPedidos);
            this.panelMenuIzq.Controls.Add(this.btnPersonal);
            this.panelMenuIzq.Controls.Add(this.btnSalir);
            this.panelMenuIzq.Controls.Add(this.picboxPanel);
            this.panelMenuIzq.Controls.Add(this.btnLayout);
            this.panelMenuIzq.Controls.Add(this.btnReservas);
            this.panelMenuIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuIzq.Location = new System.Drawing.Point(0, 30);
            this.panelMenuIzq.Name = "panelMenuIzq";
            this.panelMenuIzq.Size = new System.Drawing.Size(260, 623);
            this.panelMenuIzq.TabIndex = 0;
            // 
            // mStripMenu
            // 
            this.mStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.MesasToolStripMenuItem,
            this.MozosToolStripMenuItem,
            this.TurnosToolStripMenuItem,
            this.IngredientesToolStripMenuItem,
            this.PlatosToolStripMenuItem,
            this.BebidasToolStripMenuItem});
            this.mStripMenu.Location = new System.Drawing.Point(0, 0);
            this.mStripMenu.Name = "mStripMenu";
            this.mStripMenu.Size = new System.Drawing.Size(1116, 30);
            this.mStripMenu.TabIndex = 1;
            this.mStripMenu.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 28);
            this.toolStripMenuItem1.Text = "Menu Principal";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 28);
            this.toolStripMenuItem2.Text = "Salir";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // MesasToolStripMenuItem
            // 
            this.MesasToolStripMenuItem.Name = "MesasToolStripMenuItem";
            this.MesasToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.MesasToolStripMenuItem.Text = "Mesas";
            this.MesasToolStripMenuItem.Click += new System.EventHandler(this.MesasToolStripMenuItem_Click);
            // 
            // MozosToolStripMenuItem
            // 
            this.MozosToolStripMenuItem.Name = "MozosToolStripMenuItem";
            this.MozosToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.MozosToolStripMenuItem.Text = "Mozos";
            this.MozosToolStripMenuItem.Click += new System.EventHandler(this.MozosToolStripMenuItem_Click);
            // 
            // TurnosToolStripMenuItem
            // 
            this.TurnosToolStripMenuItem.Name = "TurnosToolStripMenuItem";
            this.TurnosToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.TurnosToolStripMenuItem.Text = "Turnos";
            this.TurnosToolStripMenuItem.Click += new System.EventHandler(this.TurnosToolStripMenuItem_Click);
            // 
            // IngredientesToolStripMenuItem
            // 
            this.IngredientesToolStripMenuItem.Name = "IngredientesToolStripMenuItem";
            this.IngredientesToolStripMenuItem.Size = new System.Drawing.Size(105, 26);
            this.IngredientesToolStripMenuItem.Text = "Ingredientes";
            this.IngredientesToolStripMenuItem.Click += new System.EventHandler(this.IngredientesToolStripMenuItem_Click);
            // 
            // PlatosToolStripMenuItem
            // 
            this.PlatosToolStripMenuItem.Name = "PlatosToolStripMenuItem";
            this.PlatosToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.PlatosToolStripMenuItem.Text = "Platos";
            this.PlatosToolStripMenuItem.Click += new System.EventHandler(this.PlatosToolStripMenuItem_Click);
            // 
            // BebidasToolStripMenuItem
            // 
            this.BebidasToolStripMenuItem.Name = "BebidasToolStripMenuItem";
            this.BebidasToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.BebidasToolStripMenuItem.Text = "Bebidas";
            this.BebidasToolStripMenuItem.Click += new System.EventHandler(this.BebidasToolStripMenuItem_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.ImageIndex = 4;
            this.btnPedidos.ImageList = this.ListaImagenes;
            this.btnPedidos.Location = new System.Drawing.Point(26, 410);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(204, 54);
            this.btnPedidos.TabIndex = 15;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            // 
            // btnPersonal
            // 
            this.btnPersonal.ImageIndex = 1;
            this.btnPersonal.ImageList = this.ListaImagenes;
            this.btnPersonal.Location = new System.Drawing.Point(26, 276);
            this.btnPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(204, 54);
            this.btnPersonal.TabIndex = 14;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.ImageIndex = 3;
            this.btnSalir.ImageList = this.ListaImagenes;
            this.btnSalir.Location = new System.Drawing.Point(26, 536);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(204, 54);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // picboxPanel
            // 
            this.picboxPanel.Image = global::LUG_TP1.Properties.Resources.Picture4;
            this.picboxPanel.Location = new System.Drawing.Point(22, 13);
            this.picboxPanel.Margin = new System.Windows.Forms.Padding(4);
            this.picboxPanel.Name = "picboxPanel";
            this.picboxPanel.Size = new System.Drawing.Size(217, 166);
            this.picboxPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPanel.TabIndex = 10;
            this.picboxPanel.TabStop = false;
            // 
            // btnLayout
            // 
            this.btnLayout.ImageIndex = 0;
            this.btnLayout.ImageList = this.ListaImagenes;
            this.btnLayout.Location = new System.Drawing.Point(26, 209);
            this.btnLayout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLayout.Name = "btnLayout";
            this.btnLayout.Size = new System.Drawing.Size(204, 54);
            this.btnLayout.TabIndex = 6;
            this.btnLayout.Text = "Layout";
            this.btnLayout.UseVisualStyleBackColor = true;
            this.btnLayout.Click += new System.EventHandler(this.btnLayout_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.ImageIndex = 2;
            this.btnReservas.ImageList = this.ListaImagenes;
            this.btnReservas.Location = new System.Drawing.Point(26, 343);
            this.btnReservas.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(204, 54);
            this.btnReservas.TabIndex = 7;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 653);
            this.Controls.Add(this.panelMenuIzq);
            this.Controls.Add(this.mStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mStripMenu;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restó";
            this.panelMenuIzq.ResumeLayout(false);
            this.mStripMenu.ResumeLayout(false);
            this.mStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnLayout;
        private System.Windows.Forms.PictureBox picboxPanel;
        private System.Windows.Forms.Panel panelMenuIzq;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MenuStrip mStripMenu;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MozosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem IngredientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BebidasToolStripMenuItem;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.ImageList ListaImagenes;
        private System.Windows.Forms.Button btnPedidos;
    }
}

