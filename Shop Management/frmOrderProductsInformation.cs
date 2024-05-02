using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Shop_Management
{
    public partial class frmOrderProductsInformation : Form
    {
        public frmOrderProductsInformation()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Name = txtbxSearchByName.Text;
            string ProductName = txtbxSearchByProduct.Text;


            if (ProductName == "")
            {
                clsShopManagement objSearchByName = new clsShopManagement(Name, ProductName);
                DataTable dt = objSearchByName.SearchByName();
                dgvShowOrderProductDetails.DataSource = dt;
                dgvShowOrderProductDetails.Show();
            }
            else if (Name == "")
            {
                clsShopManagement objSearchByProductName = new clsShopManagement(Name, ProductName);
                DataTable dt = objSearchByProductName.SearchByProduct();
                dgvShowOrderProductDetails.DataSource = dt;
                dgvShowOrderProductDetails.Show();
            }
            else
            {
                clsShopManagement objSearchByNameandProductName = new clsShopManagement(Name, ProductName);
                DataTable dt = objSearchByNameandProductName.SearchByNameandProductName();
                dgvShowOrderProductDetails.DataSource = dt;
                dgvShowOrderProductDetails.Show();
            }

        }

        private void dgvShowOrderProductDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmOrderProductsInformation_Load(object sender, EventArgs e)
        {
            clsShopManagement objBlankNameandProductName = new clsShopManagement();
            DataTable dt = objBlankNameandProductName.ShowOrderProductsDetails();
            dgvShowOrderProductDetails.DataSource = dt;
            //dgvShowOrderProductDetails.Columns[1].Visible = false;

            //dgvShowOrderProductDetails.Show();
            //dt.Columns.Add("RealPrice", typeof(decimal));
            //dgvShowOrderProductDetails.DataSource = dt;
            DataGridViewCheckBoxColumn cbxcolumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "SelectColumn",
                Name = "SelectColumn",
                DataPropertyName = "SelectColumn"
            };
            dgvShowOrderProductDetails.Columns.Insert(0, cbxcolumn);

        }

        private void dgvShowOrderProductDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dgvShowOrderProductDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            int offerColumnIndex = dgvShowOrderProductDetails.Columns["Discount"].Index;
            if (e.ColumnIndex == offerColumnIndex && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvShowOrderProductDetails.Rows[e.RowIndex];
                string offerValue = selectedRow.Cells["Discount"].Value.ToString();
                string customerName = selectedRow.Cells["UserName"].Value.ToString();
                string productName = selectedRow.Cells["ProductName"].Value.ToString();
                int OrderID = Convert.ToInt32(selectedRow.Cells["OrderId"].Value.ToString());
                int productPrice = Convert.ToInt32(selectedRow.Cells["Price"].Value.ToString());
                if (offerValue == "Discount")
                {

                    frmOffer objDiscount = new frmOffer(customerName, productName, productPrice, OrderID);
                    objDiscount.Show();
                    selectedRow.Cells["RealPrice"].Value = objDiscount.RealPrice;
                    dgvShowOrderProductDetails.Refresh();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsShopManagement objDelete = new clsShopManagement();
            foreach(DataGridViewRow row in dgvShowOrderProductDetails.Rows)
            {
                if (Convert.ToBoolean(row.Cells["SelectColumn"].Value)) 
                {
                    int OrderId = Convert.ToInt32(row.Cells["OrderId"].Value);
                    objDelete.IsDeleted(OrderId);
                
                
                }
            }
            MessageBox.Show("Deleted successfully");
            this.Hide();
        }
    }
}




























