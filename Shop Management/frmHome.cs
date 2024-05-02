using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace Shop_Management
{
    public partial class frmHome : Form
    {
        public int UserId;
        public frmHome()
        {
            InitializeComponent();
        }
        public frmHome(int userid,string name,string email) 
        {
            InitializeComponent();
            UserId = userid;
            lblUserId.Text = "User Id:" +userid.ToString();
            lblUserName.Text= "Name:" +name;
            lblUserEmail.Text = "Email:" +email;
           
        
        }


        private void frmHome_Load(object sender, EventArgs e)
        {
            clsShopManagement objShowType = new clsShopManagement();
            DataTable dt = new DataTable();
            dt = objShowType.ShowType();
            cmbbxType.DisplayMember = "TypeName";
            cmbbxType.ValueMember = "TypeId";
            cmbbxType.DataSource = dt;
        }

        private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeId = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            clsShopManagement objShowProductName = new clsShopManagement(TypeId);
            DataTable dt = new DataTable();
            dt = objShowProductName.ShowProductName();
            cmbbxProductName.DisplayMember = "ProductName";
            cmbbxProductName.ValueMember = "ProductId";
            cmbbxProductName.DataSource = dt;
        }

        private void cmbbxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ProductNameId = Convert.ToInt32(cmbbxProductName.SelectedValue);
            DataTable dt = new DataTable();
            clsShopManagement objShowInGrid = new clsShopManagement();
           
            dt = objShowInGrid.ShowDataInGrid(ProductNameId);
            dgvShowDataInGridView.DataSource = dt;
            dgvShowDataInGridView.Columns[0].Visible = false;

            dgvShowDataInGridView.DataSource = dt;
        }

        private void dgvShowDataInGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvShowDataInGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clsShopManagement objFetchProductPrice = new clsShopManagement();
            if(e.RowIndex >= 0) 
            {
                DataGridViewRow row = this.dgvShowDataInGridView.Rows[e.RowIndex];
                int ProductSizeId = Convert.ToInt32(row.Cells["FinalProductId"].Value);
                DataTable dt = new DataTable();
                dt = objFetchProductPrice.FetchProductPrice(ProductSizeId);
                txtbxPrice.Text = dt.Rows[0]["Price"].ToString();
            }

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            string Size = (dgvShowDataInGridView.Rows[dgvShowDataInGridView.CurrentRow.Index].Cells["Size"].Value.ToString());
            string FinalProductId = (dgvShowDataInGridView.Rows[dgvShowDataInGridView.CurrentRow.Index].Cells["FinalProductId"].Value.ToString());
            string[] arr = new string[5];
            arr[0] = cmbbxType.Text;
            arr[1] = cmbbxProductName.Text;
            arr[2] = Size;
            arr[3] = txtbxPrice.Text;
            arr[4] = FinalProductId;
            ListViewItem im = new ListViewItem(arr);
            lstviewProductDetails.Items.Add(im);


            int Price = 0;
            foreach (ListViewItem item in lstviewProductDetails.Items)
            {
                int value = int.Parse(item.SubItems[3].Text);
                Price += value;


            }
            txtbxTotal.Text = Price.ToString();
        }

        private void btnRemoveToCart_Click(object sender, EventArgs e)
        {
            if (lstviewProductDetails.SelectedItems.Count > 0)
            {
                lstviewProductDetails.Items.Remove(lstviewProductDetails.SelectedItems[0]);
            }
            int Price = 0;
            foreach (ListViewItem item in lstviewProductDetails.Items)
            {
                int value = int.Parse(item.SubItems[3].Text);
                Price += value;


            }
            txtbxTotal.Text = Price.ToString();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (lstviewProductDetails.Items.Count > 0)
            {
                foreach (ListViewItem item in lstviewProductDetails.Items)
                {
                    DateTime Date = DateTime.Now;
                    int FinalProductID = Convert.ToInt32(item.SubItems[4].Text);
                    clsShopManagement objOrder = new clsShopManagement(FinalProductID,Date,UserId);
                    objOrder.SaveOrderDetails();
                }
            }
            MessageBox.Show("Order Confirmed....");
        }
    }
}





