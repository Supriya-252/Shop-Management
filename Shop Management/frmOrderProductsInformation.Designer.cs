namespace Shop_Management
{
    partial class frmOrderProductsInformation
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
            this.lblOrderProductsInformation = new System.Windows.Forms.Label();
            this.dgvShowOrderProductDetails = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchByName = new System.Windows.Forms.Label();
            this.lblSearchByProduct = new System.Windows.Forms.Label();
            this.txtbxSearchByName = new System.Windows.Forms.TextBox();
            this.txtbxSearchByProduct = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Discount = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOrderProductDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderProductsInformation
            // 
            this.lblOrderProductsInformation.AutoSize = true;
            this.lblOrderProductsInformation.Location = new System.Drawing.Point(558, 9);
            this.lblOrderProductsInformation.Name = "lblOrderProductsInformation";
            this.lblOrderProductsInformation.Size = new System.Drawing.Size(165, 16);
            this.lblOrderProductsInformation.TabIndex = 0;
            this.lblOrderProductsInformation.Text = "Order Products Information";
            // 
            // dgvShowOrderProductDetails
            // 
            this.dgvShowOrderProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowOrderProductDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Discount});
            this.dgvShowOrderProductDetails.Location = new System.Drawing.Point(115, 223);
            this.dgvShowOrderProductDetails.Name = "dgvShowOrderProductDetails";
            this.dgvShowOrderProductDetails.RowHeadersWidth = 51;
            this.dgvShowOrderProductDetails.RowTemplate.Height = 24;
            this.dgvShowOrderProductDetails.Size = new System.Drawing.Size(1353, 301);
            this.dgvShowOrderProductDetails.TabIndex = 1;
            this.dgvShowOrderProductDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowOrderProductDetails_CellClick);
            this.dgvShowOrderProductDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowOrderProductDetails_CellContentClick);
            this.dgvShowOrderProductDetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvShowOrderProductDetails_CellFormatting);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(591, 194);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchByName
            // 
            this.lblSearchByName.AutoSize = true;
            this.lblSearchByName.Location = new System.Drawing.Point(367, 80);
            this.lblSearchByName.Name = "lblSearchByName";
            this.lblSearchByName.Size = new System.Drawing.Size(115, 16);
            this.lblSearchByName.TabIndex = 3;
            this.lblSearchByName.Text = "Search By Name :";
            // 
            // lblSearchByProduct
            // 
            this.lblSearchByProduct.AutoSize = true;
            this.lblSearchByProduct.Location = new System.Drawing.Point(367, 148);
            this.lblSearchByProduct.Name = "lblSearchByProduct";
            this.lblSearchByProduct.Size = new System.Drawing.Size(124, 16);
            this.lblSearchByProduct.TabIndex = 4;
            this.lblSearchByProduct.Text = "Search By Product :";
            // 
            // txtbxSearchByName
            // 
            this.txtbxSearchByName.Location = new System.Drawing.Point(578, 80);
            this.txtbxSearchByName.Name = "txtbxSearchByName";
            this.txtbxSearchByName.Size = new System.Drawing.Size(100, 22);
            this.txtbxSearchByName.TabIndex = 5;
            // 
            // txtbxSearchByProduct
            // 
            this.txtbxSearchByProduct.Location = new System.Drawing.Point(578, 142);
            this.txtbxSearchByProduct.Name = "txtbxSearchByProduct";
            this.txtbxSearchByProduct.Size = new System.Drawing.Size(100, 22);
            this.txtbxSearchByProduct.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(279, 650);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.Text = "Discount";
            this.Discount.UseColumnTextForButtonValue = true;
            this.Discount.Width = 125;
            // 
            // frmOrderProductsInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 737);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtbxSearchByProduct);
            this.Controls.Add(this.txtbxSearchByName);
            this.Controls.Add(this.lblSearchByProduct);
            this.Controls.Add(this.lblSearchByName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvShowOrderProductDetails);
            this.Controls.Add(this.lblOrderProductsInformation);
            this.Name = "frmOrderProductsInformation";
            this.Text = "frmOrderProductsInformation";
            this.Load += new System.EventHandler(this.frmOrderProductsInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOrderProductDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderProductsInformation;
        private System.Windows.Forms.DataGridView dgvShowOrderProductDetails;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchByName;
        private System.Windows.Forms.Label lblSearchByProduct;
        private System.Windows.Forms.TextBox txtbxSearchByName;
        private System.Windows.Forms.TextBox txtbxSearchByProduct;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn Discount;
    }
}