namespace DiscosAPP
{
    partial class frmDiscosApp
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
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.pcbDiscos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscos.Location = new System.Drawing.Point(26, 25);
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.Size = new System.Drawing.Size(567, 223);
            this.dgvDiscos.TabIndex = 0;
            this.dgvDiscos.SelectionChanged += new System.EventHandler(this.dgvDiscos_SelectionChanged);
            // 
            // pcbDiscos
            // 
            this.pcbDiscos.Location = new System.Drawing.Point(637, 25);
            this.pcbDiscos.Name = "pcbDiscos";
            this.pcbDiscos.Size = new System.Drawing.Size(237, 223);
            this.pcbDiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDiscos.TabIndex = 1;
            this.pcbDiscos.TabStop = false;
            // 
            // frmDiscosApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 305);
            this.Controls.Add(this.pcbDiscos);
            this.Controls.Add(this.dgvDiscos);
            this.Name = "frmDiscosApp";
            this.Text = "DiscosApp";
            this.Load += new System.EventHandler(this.frmDiscosApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDiscos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscos;
        private System.Windows.Forms.PictureBox pcbDiscos;
    }
}

