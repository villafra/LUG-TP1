namespace Negocio
{
    partial class frmLayout
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
            this.picboxPrincipal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxPrincipal
            // 
            this.picboxPrincipal.Image = global::Negocio.Properties.Resources.Picture6;
            this.picboxPrincipal.Location = new System.Drawing.Point(107, -1);
            this.picboxPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.picboxPrincipal.Name = "picboxPrincipal";
            this.picboxPrincipal.Size = new System.Drawing.Size(662, 377);
            this.picboxPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxPrincipal.TabIndex = 12;
            this.picboxPrincipal.TabStop = false;
            // 
            // frmLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 577);
            this.Controls.Add(this.picboxPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLayout";
            this.Text = "Layout";
            ((System.ComponentModel.ISupportInitialize)(this.picboxPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxPrincipal;
    }
}