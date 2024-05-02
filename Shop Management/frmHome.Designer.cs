namespace Shop_Management
{
    partial class frmHome
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
            this.cmbbxType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbbxProductName = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.dgvShowDataInGridView = new System.Windows.Forms.DataGridView();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.lstviewProductDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnRemoveToCart = new System.Windows.Forms.Button();
            this.txtbxTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDataInGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbbxType
            // 
            this.cmbbxType.FormattingEnabled = true;
            this.cmbbxType.Location = new System.Drawing.Point(190, 44);
            this.cmbbxType.Name = "cmbbxType";
            this.cmbbxType.Size = new System.Drawing.Size(121, 24);
            this.cmbbxType.TabIndex = 0;
            this.cmbbxType.SelectedIndexChanged += new System.EventHandler(this.cmbbxType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(57, 52);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(45, 16);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type :";
            // 
            // cmbbxProductName
            // 
            this.cmbbxProductName.FormattingEnabled = true;
            this.cmbbxProductName.Location = new System.Drawing.Point(190, 106);
            this.cmbbxProductName.Name = "cmbbxProductName";
            this.cmbbxProductName.Size = new System.Drawing.Size(121, 24);
            this.cmbbxProductName.TabIndex = 2;
            this.cmbbxProductName.SelectedIndexChanged += new System.EventHandler(this.cmbbxProductName_SelectedIndexChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(57, 114);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(99, 16);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Product Name :";
            // 
            // dgvShowDataInGridView
            // 
            this.dgvShowDataInGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowDataInGridView.Location = new System.Drawing.Point(60, 155);
            this.dgvShowDataInGridView.Name = "dgvShowDataInGridView";
            this.dgvShowDataInGridView.RowHeadersWidth = 51;
            this.dgvShowDataInGridView.RowTemplate.Height = 24;
            this.dgvShowDataInGridView.Size = new System.Drawing.Size(240, 150);
            this.dgvShowDataInGridView.TabIndex = 4;
            this.dgvShowDataInGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowDataInGridView_CellClick);
            this.dgvShowDataInGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowDataInGridView_CellContentClick);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(60, 333);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 16);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price :";
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Location = new System.Drawing.Point(190, 333);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.Size = new System.Drawing.Size(100, 22);
            this.txtbxPrice.TabIndex = 6;
            // 
            // lstviewProductDetails
            // 
            this.lstviewProductDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstviewProductDetails.HideSelection = false;
            this.lstviewProductDetails.Location = new System.Drawing.Point(898, 176);
            this.lstviewProductDetails.Name = "lstviewProductDetails";
            this.lstviewProductDetails.Size = new System.Drawing.Size(629, 273);
            this.lstviewProductDetails.TabIndex = 7;
            this.lstviewProductDetails.UseCompatibleStateImageBehavior = false;
            this.lstviewProductDetails.View = System.Windows.Forms.View.Details;
            this.lstviewProductDetails.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            this.columnHeader1.Width = 51;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Name";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product Size";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Product Price";
            this.columnHeader4.Width = 99;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(502, 212);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(122, 34);
            this.btnAddToCart.TabIndex = 8;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnRemoveToCart
            // 
            this.btnRemoveToCart.Location = new System.Drawing.Point(502, 281);
            this.btnRemoveToCart.Name = "btnRemoveToCart";
            this.btnRemoveToCart.Size = new System.Drawing.Size(122, 24);
            this.btnRemoveToCart.TabIndex = 9;
            this.btnRemoveToCart.Text = "Remove To Cart";
            this.btnRemoveToCart.UseVisualStyleBackColor = true;
            this.btnRemoveToCart.Click += new System.EventHandler(this.btnRemoveToCart_Click);
            // 
            // txtbxTotal
            // 
            this.txtbxTotal.Location = new System.Drawing.Point(898, 488);
            this.txtbxTotal.Name = "txtbxTotal";
            this.txtbxTotal.Size = new System.Drawing.Size(100, 22);
            this.txtbxTotal.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(673, 493);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 16);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total :";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(502, 26);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(0, 16);
            this.lblUserId.TabIndex = 12;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(502, 87);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 16);
            this.lblUserName.TabIndex = 13;
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(502, 155);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(0, 16);
            this.lblUserEmail.TabIndex = 14;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(378, 506);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 15;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 585);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblUserEmail);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtbxTotal);
            this.Controls.Add(this.btnRemoveToCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lstviewProductDetails);
            this.Controls.Add(this.txtbxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.dgvShowDataInGridView);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.cmbbxProductName);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbbxType);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDataInGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbxType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.DataGridView dgvShowDataInGridView;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtbxPrice;
        private System.Windows.Forms.ListView lstviewProductDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnRemoveToCart;
        private System.Windows.Forms.TextBox txtbxTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Button btnOrder;
    }
}