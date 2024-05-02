namespace Shop_Management
{
    partial class frmAllProducts
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
            this.dgvShowAllProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAllProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowAllProducts
            // 
            this.dgvShowAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowAllProducts.Location = new System.Drawing.Point(47, 56);
            this.dgvShowAllProducts.Name = "dgvShowAllProducts";
            this.dgvShowAllProducts.RowHeadersWidth = 51;
            this.dgvShowAllProducts.RowTemplate.Height = 24;
            this.dgvShowAllProducts.Size = new System.Drawing.Size(677, 341);
            this.dgvShowAllProducts.TabIndex = 0;
            // 
            // frmAllProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvShowAllProducts);
            this.Name = "frmAllProducts";
            this.Text = "frmAllProducts";
            this.Load += new System.EventHandler(this.frmAllProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAllProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowAllProducts;
    }
}