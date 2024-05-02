namespace Shop_Management
{
    partial class frmUnorderedProducts
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
            this.dgvShowUnorderedProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowUnorderedProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowUnorderedProducts
            // 
            this.dgvShowUnorderedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowUnorderedProducts.Location = new System.Drawing.Point(62, 83);
            this.dgvShowUnorderedProducts.Name = "dgvShowUnorderedProducts";
            this.dgvShowUnorderedProducts.RowHeadersWidth = 51;
            this.dgvShowUnorderedProducts.RowTemplate.Height = 24;
            this.dgvShowUnorderedProducts.Size = new System.Drawing.Size(658, 269);
            this.dgvShowUnorderedProducts.TabIndex = 0;
            // 
            // frmUnorderedProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvShowUnorderedProducts);
            this.Name = "frmUnorderedProducts";
            this.Text = "frmUnorderedProducts";
            this.Load += new System.EventHandler(this.frmUnorderedProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowUnorderedProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowUnorderedProducts;
    }
}